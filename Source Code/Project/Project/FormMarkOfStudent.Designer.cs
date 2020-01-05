namespace Project
{
    partial class FormMarkOfStudent
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
            this.label8 = new System.Windows.Forms.Label();
            this.lstSemester = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstYear = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGradeNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLecturer = new System.Windows.Forms.ListBox();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentStudyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecturerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearStudyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(539, 37);
            this.label8.TabIndex = 37;
            this.label8.Text = "MANAGER MARK OF STUDENTS";
            // 
            // lstSemester
            // 
            this.lstSemester.FormattingEnabled = true;
            this.lstSemester.Location = new System.Drawing.Point(515, 187);
            this.lstSemester.Name = "lstSemester";
            this.lstSemester.Size = new System.Drawing.Size(120, 95);
            this.lstSemester.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Semester";
            // 
            // lstYear
            // 
            this.lstYear.FormattingEnabled = true;
            this.lstYear.Location = new System.Drawing.Point(209, 187);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(120, 95);
            this.lstYear.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Year";
            // 
            // txtGradeNumber
            // 
            this.txtGradeNumber.Location = new System.Drawing.Point(515, 300);
            this.txtGradeNumber.Name = "txtGradeNumber";
            this.txtGradeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtGradeNumber.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(623, 635);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(209, 300);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Grade Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "StudentID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 635);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lecturer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Course Name";
            // 
            // lstLecturer
            // 
            this.lstLecturer.FormattingEnabled = true;
            this.lstLecturer.Location = new System.Drawing.Point(515, 74);
            this.lstLecturer.Name = "lstLecturer";
            this.lstLecturer.Size = new System.Drawing.Size(120, 95);
            this.lstLecturer.TabIndex = 21;
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(209, 74);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(120, 95);
            this.lstCourse.TabIndex = 20;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(72, 635);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 635);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(486, 635);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentStudyID,
            this.StudentID,
            this.LecturerID,
            this.YearStudyID,
            this.CourseID,
            this.GradeNumber,
            this.GradeCharacter});
            this.dataGridView1.Location = new System.Drawing.Point(12, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 272);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // StudentStudyID
            // 
            this.StudentStudyID.DataPropertyName = "StudentStudyID";
            this.StudentStudyID.HeaderText = "StudentStudyID";
            this.StudentStudyID.Name = "StudentStudyID";
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            // 
            // LecturerID
            // 
            this.LecturerID.DataPropertyName = "LecturerID";
            this.LecturerID.HeaderText = "LecturerID";
            this.LecturerID.Name = "LecturerID";
            // 
            // YearStudyID
            // 
            this.YearStudyID.DataPropertyName = "YearStudyID";
            this.YearStudyID.HeaderText = "YearStudyID";
            this.YearStudyID.Name = "YearStudyID";
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.Name = "CourseID";
            // 
            // GradeNumber
            // 
            this.GradeNumber.DataPropertyName = "GradeNumber";
            this.GradeNumber.HeaderText = "GradeNumber";
            this.GradeNumber.Name = "GradeNumber";
            // 
            // GradeCharacter
            // 
            this.GradeCharacter.DataPropertyName = "GradeCharacter";
            this.GradeCharacter.HeaderText = "GradeCharacter";
            this.GradeCharacter.Name = "GradeCharacter";
            // 
            // FormMarkOfStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 667);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstSemester);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGradeNumber);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLecturer);
            this.Controls.Add(this.lstCourse);
            this.Name = "FormMarkOfStudent";
            this.Text = "FormMarkOfStudent";
            this.Load += new System.EventHandler(this.FormMarkOfStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstSemester;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGradeNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLecturer;
        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentStudyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearStudyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeCharacter;
    }
}