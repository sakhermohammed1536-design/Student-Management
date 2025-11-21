partial class FormCourses
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
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtProfessorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(12, 175);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(460, 224);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المادة:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(23, 26);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(183, 20);
            this.txtCourseName.TabIndex = 0;
            // 
            // txtProfessorName
            // 
            this.txtProfessorName.Location = new System.Drawing.Point(23, 59);
            this.txtProfessorName.Name = "txtProfessorName";
            this.txtProfessorName.Size = new System.Drawing.Size(183, 20);
            this.txtProfessorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم الأستاذ:";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(308, 28);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(117, 23);
            this.btnAddCourse.TabIndex = 2;
            this.btnAddCourse.Text = "إضافة مادة";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(308, 57);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(117, 23);
            this.btnUpdateCourse.TabIndex = 3;
            this.btnUpdateCourse.Text = "تحديث مادة";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(308, 86);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "حذف مادة";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDeleteCourse);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.btnUpdateCourse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddCourse);
            this.groupBox1.Controls.Add(this.txtProfessorName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(460, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المادة";
            // 
            // FormCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCourses);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "FormCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المواد";
            this.Load += new System.EventHandler(this.FormCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvCourses;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCourseName;
    private System.Windows.Forms.TextBox txtProfessorName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAddCourse;
    private System.Windows.Forms.Button btnUpdateCourse;
    private System.Windows.Forms.Button btnDeleteCourse;
    private System.Windows.Forms.GroupBox groupBox1;
}