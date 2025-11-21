partial class FormGrades
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
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(12, 158);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(460, 241);
            this.dgvGrades.TabIndex = 0;
            this.dgvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "الطالب:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(188, 25);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(206, 21);
            this.cmbStudents.TabIndex = 0;
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(188, 49);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(206, 21);
            this.cmbCourses.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "المادة:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(294, 81);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "الدرجة:";
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(277, 107);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(117, 34);
            this.btnAddGrade.TabIndex = 3;
            this.btnAddGrade.Text = "إضافة درجة";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddGrade);
            this.groupBox1.Controls.Add(this.cmbStudents);
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCourses);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(460, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "رصد الدرجات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FormGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGrades);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "FormGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الدرجات";
            this.Load += new System.EventHandler(this.FormGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvGrades;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbStudents;
    private System.Windows.Forms.ComboBox cmbCourses;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtScore;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnAddGrade;
    private System.Windows.Forms.GroupBox groupBox1;
}