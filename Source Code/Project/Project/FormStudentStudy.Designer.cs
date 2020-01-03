namespace Project
{
    partial class FormStudentStudy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.lstLecturer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGradeNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstYear = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstSemester = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(233, 65);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(120, 95);
            this.lstCourse.TabIndex = 0;
            // 
            // lstLecturer
            // 
            this.lstLecturer.FormattingEnabled = true;
            this.lstLecturer.Location = new System.Drawing.Point(539, 65);
            this.lstLecturer.Name = "lstLecturer";
            this.lstLecturer.Size = new System.Drawing.Size(120, 95);
            this.lstLecturer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lecturer Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(83, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 269);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "StudentStudyID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "StudentID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FirstName";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "LastName";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "GradeNumber";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "GradeCharacter";
            this.Column6.Name = "Column6";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(470, 679);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "StudentID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grade Number";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(233, 291);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 10;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(233, 349);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(299, 679);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtGradeNumber
            // 
            this.txtGradeNumber.Location = new System.Drawing.Point(539, 318);
            this.txtGradeNumber.Name = "txtGradeNumber";
            this.txtGradeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtGradeNumber.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Year";
            // 
            // lstYear
            // 
            this.lstYear.FormattingEnabled = true;
            this.lstYear.Location = new System.Drawing.Point(233, 178);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(120, 95);
            this.lstYear.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Semester";
            // 
            // lstSemester
            // 
            this.lstSemester.FormattingEnabled = true;
            this.lstSemester.Location = new System.Drawing.Point(539, 178);
            this.lstSemester.Name = "lstSemester";
            this.lstSemester.Size = new System.Drawing.Size(120, 95);
            this.lstSemester.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(539, 37);
            this.label8.TabIndex = 19;
            this.label8.Text = "MANAGER MARK OF STUDENTS";
            // 
            // FormStudentStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstSemester);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGradeNumber);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLecturer);
            this.Controls.Add(this.lstCourse);
            this.Name = "FormStudentStudy";
            this.Text = "FormStudentStudy";
            this.Load += new System.EventHandler(this.FormStudentStudy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.ListBox lstLecturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtGradeNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstSemester;
        private System.Windows.Forms.Label label8;
    }
}