partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.btnManageGrades = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 237);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(620, 240);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم الأول:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(259, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(259, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "الاسم الأخير:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(259, 95);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(149, 20);
            this.txtClassName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "الفصل:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(149, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "العنوان:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(6, 56);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "رقم الهاتف:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(505, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(505, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "تحديث";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(505, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "مسح الحقول";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnManageCourses
            // 
            this.btnManageCourses.Location = new System.Drawing.Point(145, 20);
            this.btnManageCourses.Name = "btnManageCourses";
            this.btnManageCourses.Size = new System.Drawing.Size(117, 34);
            this.btnManageCourses.TabIndex = 0;
            this.btnManageCourses.Text = "إدارة المواد";
            this.btnManageCourses.UseVisualStyleBackColor = true;
            this.btnManageCourses.Click += new System.EventHandler(this.btnManageCourses_Click);
            // 
            // btnManageGrades
            // 
            this.btnManageGrades.Location = new System.Drawing.Point(22, 20);
            this.btnManageGrades.Name = "btnManageGrades";
            this.btnManageGrades.Size = new System.Drawing.Size(117, 34);
            this.btnManageGrades.TabIndex = 1;
            this.btnManageGrades.Text = "إدارة الدرجات";
            this.btnManageGrades.UseVisualStyleBackColor = true;
            this.btnManageGrades.Click += new System.EventHandler(this.btnManageGrades_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(620, 153);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الطالب";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnManageGrades);
            this.groupBox2.Controls.Add(this.btnManageCourses);
            this.groupBox2.Location = new System.Drawing.Point(350, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(282, 60);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "التنقل";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudents);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 528);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الإدارة الرئيسية - الطلاب";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtClassName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnManageCourses;
    private System.Windows.Forms.Button btnManageGrades;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dgvStudents;
}