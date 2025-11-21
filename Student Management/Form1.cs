using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

public partial class Form1 : Form
{
    // متغير لحفظ رقم الطالب المحدد حالياً
    private int selectedStudentId = 0;

    public Form1()
    {
        InitializeComponent();
    }

    // عند تحميل الفورم
    private void Form1_Load(object sender, EventArgs e)
    {
        try
        {
            if (DatabaseHelper.TestConnection())
            {
                // إذا نجح الاتصال، نقوم بتحميل بيانات الطلاب
                LoadStudentsGrid();
            }
            else
            {
                MessageBox.Show("فشل الاتصال بقاعدة بيانات SQL Server. تأكد من تشغيل السيرفر وصحة سلسلة الاتصال.", "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ غير متوقع: " + ex.Message, "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }

    // دالة لتحديث عرض بيانات الطلاب
    private void LoadStudentsGrid()
    {
        try
        {
            DataTable dt = DatabaseHelper.GetStudents();
            dgvStudents.DataSource = dt;

            // تعريب وتهيئة العرض لليمين باستخدام الـ helper
            var translations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "first_name", "الاسم الأول" },
                { "last_name", "الاسم الأخير" },
                { "class_name", "الصف" },
                { "address", "العنوان" },
                { "phone", "رقم الهاتف" },
                { "FullName", "الاسم الكامل" }
            };

            UiHelpers.ConfigureDataGrid(dgvStudents, translations, "student_id");

            // إزالة اختيار الصفوف بعد التحميل
            dgvStudents.ClearSelection();
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ في تحميل بيانات الطلاب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // دالة لمسح الحقول
    private void ClearFields()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtClassName.Text = "";
        txtAddress.Text = "";
        txtPhone.Text = "";
        selectedStudentId = 0; // إعادة تعيين الطالب المحدد
        dgvStudents.ClearSelection();
    }

    // عند الضغط على زر "إضافة"
    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
        {
            MessageBox.Show("الاسم الأول والاسم الأخير حقول إجبارية.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            DatabaseHelper.AddStudent(txtFirstName.Text, txtLastName.Text, txtClassName.Text, txtAddress.Text, txtPhone.Text);
            MessageBox.Show("تمت إضافة الطالب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadStudentsGrid();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ أثناء إضافة الطالب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // عند الضغط على زر "تحديث"
    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (selectedStudentId == 0)
        {
            MessageBox.Show("الرجاء تحديد طالب من القائمة أولاً لتعديله.", "لم يتم التحديد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
        {
            MessageBox.Show("الاسم الأول والاسم الأخير حقول إجبارية.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            DatabaseHelper.UpdateStudent(selectedStudentId, txtFirstName.Text, txtLastName.Text, txtClassName.Text, txtAddress.Text, txtPhone.Text);
            MessageBox.Show("تم تحديث بيانات الطالب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadStudentsGrid();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ أثناء تحديث الطالب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // عند الضغط على زر "حذف"
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (selectedStudentId == 0)
        {
            MessageBox.Show("الرجاء تحديد طالب من القائمة أولاً لحذفه.", "لم يتم التحديد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show("هل أنت متأكد من حذف هذا الطالب؟ سيتم حذف جميع درجاته المرتبطة به.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            try
            {
                DatabaseHelper.DeleteStudent(selectedStudentId);
                MessageBox.Show("تم حذف الطالب ودرجاته بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentsGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء حذف الطالب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // عند الضغط على زر "مسح الحقول"
    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    // عند النقر على خلية في الجدول (لعرض بياناتها في الحقول)
    private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            try
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                // تخزين رقم الطالب المحدد
                selectedStudentId = Convert.ToInt32(row.Cells["student_id"].Value);

                // ملء الحقول (نستخدم الأسماء المعروفة من قاعدة البيانات)
                txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtLastName.Text = row.Cells["last_name"].Value.ToString();
                txtClassName.Text = row.Cells["class_name"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحديد الطالب: " + ex.Message);
                ClearFields();
            }
        }
    }

    // --- أزرار التنقل ---
    private void btnManageCourses_Click(object sender, EventArgs e)
    {
        FormCourses formCourses = new FormCourses();
        formCourses.Show();
    }

    private void btnManageGrades_Click(object sender, EventArgs e)
    {
        FormGrades formGrades = new FormGrades();
        formGrades.Show();
    }
}