using System;
using System.Windows.Forms;

public partial class FormCourses : Form
{
    private int selectedCourseId = 0;

    public FormCourses()
    {
        InitializeComponent();
    }

    private void FormCourses_Load(object sender, EventArgs e)
    {
        LoadCoursesGrid();
    }

    private void LoadCoursesGrid()
    {
        try
        {
           
            dgvCourses.DataSource = DatabaseHelper.GetCourses();

           

            // 3. تعريب العناوين (تغيير ما يظهر للمستخدم فقط)
            if (dgvCourses.Columns["course_name"] != null)
                dgvCourses.Columns["course_name"].HeaderText = "اسم المادة";

            if (dgvCourses.Columns["professor_name"] != null)
                dgvCourses.Columns["professor_name"].HeaderText = "اسم الأستاذ";

            // 4. إخفاء عمود الـ ID (اختياري، لكن يفضل إخفاؤه لأنه للمبرمج فقط)
            if (dgvCourses.Columns["course_id"] != null)
                dgvCourses.Columns["course_id"].Visible = false;

        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ في تحميل المواد: " + ex.Message);
        }
    }

    private void ClearFields()
    {
        txtCourseName.Text = "";
        txtProfessorName.Text = "";
        selectedCourseId = 0;
        dgvCourses.ClearSelection();
    }

    private void btnAddCourse_Click(object sender, EventArgs e)
    {
        // التحقق
        if (string.IsNullOrWhiteSpace(txtCourseName.Text))
        {
            MessageBox.Show("اسم المادة حقل إجباري.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            DatabaseHelper.AddCourse(txtCourseName.Text, txtProfessorName.Text);
            MessageBox.Show("تمت إضافة المادة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCoursesGrid();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ أثناء إضافة المادة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnUpdateCourse_Click(object sender, EventArgs e)
    {
        if (selectedCourseId == 0)
        {
            MessageBox.Show("الرجاء تحديد مادة لتعديلها.", "لم يتم التحديد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (string.IsNullOrWhiteSpace(txtCourseName.Text))
        {
            MessageBox.Show("اسم المادة حقل إجباري.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            DatabaseHelper.UpdateCourse(selectedCourseId, txtCourseName.Text, txtProfessorName.Text);
            MessageBox.Show("تم تحديث المادة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCoursesGrid();
            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ أثناء تحديث المادة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDeleteCourse_Click(object sender, EventArgs e)
    {
        if (selectedCourseId == 0)
        {
            MessageBox.Show("الرجاء تحديد مادة لحذفها.", "لم يتم التحديد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show("هل أنت متأكد من حذف هذه المادة؟ سيتم حذف جميع الدرجات المرتبطة بها.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            try
            {
                DatabaseHelper.DeleteCourse(selectedCourseId);
                MessageBox.Show("تم حذف المادة ودرجاتها بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCoursesGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء حذف المادة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            try
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];
                selectedCourseId = Convert.ToInt32(row.Cells["course_id"].Value);
                txtCourseName.Text = row.Cells["course_name"].Value.ToString();
                txtProfessorName.Text = row.Cells["professor_name"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحديد المادة: " + ex.Message);
                ClearFields();
            }
        }
    }
}