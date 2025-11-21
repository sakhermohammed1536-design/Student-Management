using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

public partial class FormGrades : Form
{
    public FormGrades()
    {
        InitializeComponent();
    }

    private void FormGrades_Load(object sender, EventArgs e)
    {
        // تحميل القوائم المنسدلة
        LoadStudentsComboBox();
        LoadCoursesComboBox();
        // تحميل جدول الدرجات المسجلة
        LoadGradesGrid();
    }

    // تحميل قائمة الطلاب
    private void LoadStudentsComboBox()
    {
        try
        {
            cmbStudents.DataSource = DatabaseHelper.GetStudents();
            cmbStudents.DisplayMember = "FullName";
            cmbStudents.ValueMember = "student_id";
            cmbStudents.SelectedIndex = -1;
            UiHelpers.SetComboBoxRtl(cmbStudents);
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ تحميل الطلاب: " + ex.Message);
        }
    }

    // تحميل قائمة المواد
    private void LoadCoursesComboBox()
    {
        try
        {
            cmbCourses.DataSource = DatabaseHelper.GetCourses();
            cmbCourses.DisplayMember = "course_name";
            cmbCourses.ValueMember = "course_id";
            cmbCourses.SelectedIndex = -1;
            UiHelpers.SetComboBoxRtl(cmbCourses);
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ تحميل المواد: " + ex.Message);
        }
    }

    // تحميل جدول الدرجات المسجلة
    private void LoadGradesGrid()
    {
        try
        {
            // جلب البيانات بطريقة آمنة
            DataTable dt = DatabaseHelper.GetGradesDetailed();
                
            if (dt == null)
            {
                dgvGrades.DataSource = null;
                MessageBox.Show("لا يمكن تحميل الدرجات: لم يتم استرداد بيانات من قاعدة البيانات.", "لا توجد بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvGrades.DataSource = dt;

            // 2. ضبط محاذاة رؤوس الأعمدة والخلية إلى اليمين (ملائم للعربية)
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrades.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            foreach (DataGridViewColumn col in dgvGrades.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // 3. تعريب رؤوس الأعمدة بمرونة — نفحص أسماء الأعمدة بعدة احتمالات (حساس لحالة الأحرف)
            var colNames = dgvGrades.Columns.Cast<DataGridViewColumn>().Select(c => c.Name).ToList();

            // اسم الطالب
            string[] studentCandidates = { "StudentName", "student_name", "Student_Name", "FullName", "Student" };
            var studentCol = dgvGrades.Columns.Cast<DataGridViewColumn>()
                              .FirstOrDefault(c => studentCandidates.Any(p => string.Equals(c.Name, p, StringComparison.OrdinalIgnoreCase)));
            if (studentCol != null) studentCol.HeaderText = "اسم الطالب";

            // اسم المادة
            string[] courseCandidates = { "CourseName", "course_name", "Course_Name", "course", "Course" };
            var courseCol = dgvGrades.Columns.Cast<DataGridViewColumn>()
                             .FirstOrDefault(c => courseCandidates.Any(p => string.Equals(c.Name, p, StringComparison.OrdinalIgnoreCase)));
            if (courseCol != null) courseCol.HeaderText = "المادة";

            // الدرجة / النتيجة
            string[] scoreCandidates = { "score", "Score", "grade", "Grade", "mark", "Mark" };
            var scoreCol = dgvGrades.Columns.Cast<DataGridViewColumn>()
                            .FirstOrDefault(c => scoreCandidates.Any(p => string.Equals(c.Name, p, StringComparison.OrdinalIgnoreCase)));
            if (scoreCol != null) scoreCol.HeaderText = "الدرجة";

            // إخفاء أي عمود معرف للدرجة إذا وجد (مثلاً grade_id)
            var idCol = dgvGrades.Columns.Cast<DataGridViewColumn>()
                         .FirstOrDefault(c => string.Equals(c.Name, "grade_id", StringComparison.OrdinalIgnoreCase)
                                           || string.Equals(c.Name, "id", StringComparison.OrdinalIgnoreCase));
            if (idCol != null) idCol.Visible = false;
        }
        catch (Exception ex)
        {
            // عرض رسالة واضحة بالعربية بدلاً من خطأ NullReference غير مفيد
            MessageBox.Show("خطأ تحميل الدرجات: " + ex.Message, "خطأ تحميل الدرجات", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    private void btnAddGrade_Click(object sender, EventArgs e)
    {
        // التحقق من الاختيارات
        if (cmbStudents.SelectedValue == null)
        {
            MessageBox.Show("الرجاء اختيار طالب.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbCourses.SelectedValue == null)
        {
            MessageBox.Show("الرجاء اختيار مادة.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // التحقق من أن الدرجة رقم صحيح
        if (!int.TryParse(txtScore.Text, out int score))
        {
            MessageBox.Show("الرجاء إدخال درجة (رقم صحيح) صالحة.", "بيانات خاطئة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            int studentId = Convert.ToInt32(cmbStudents.SelectedValue);
            int courseId = Convert.ToInt32(cmbCourses.SelectedValue);

            // إضافة الدرجة
            DatabaseHelper.AddGrade(studentId, courseId, score);
            MessageBox.Show("تم رصد الدرجة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // تحديث الجدول
            LoadGradesGrid();

            // مسح الحقول
            cmbStudents.SelectedIndex = -1;
            cmbCourses.SelectedIndex = -1;
            txtScore.Text = "";
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطأ أثناء إضافة الدرجة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    
    private void dgvGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }

}