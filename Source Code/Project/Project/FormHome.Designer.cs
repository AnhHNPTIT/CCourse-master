namespace Project
{
    partial class FormHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManagerStudent = new System.Windows.Forms.Button();
            this.btnManagerCourse = new System.Windows.Forms.Button();
            this.btnManagerLecturer = new System.Windows.Forms.Button();
            this.btnManagerYearStudy = new System.Windows.Forms.Button();
            this.btnManagerStudentStudy = new System.Windows.Forms.Button();
            this.btnManagerGradeComponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIVERSITY MANAGEMENT SYSTEM ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnManagerStudent
            // 
            this.btnManagerStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerStudent.Location = new System.Drawing.Point(56, 146);
            this.btnManagerStudent.Name = "btnManagerStudent";
            this.btnManagerStudent.Size = new System.Drawing.Size(147, 37);
            this.btnManagerStudent.TabIndex = 2;
            this.btnManagerStudent.Text = "Manager Student";
            this.btnManagerStudent.UseVisualStyleBackColor = true;
            this.btnManagerStudent.Click += new System.EventHandler(this.btnManagerStudent_Click);
            // 
            // btnManagerCourse
            // 
            this.btnManagerCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerCourse.Location = new System.Drawing.Point(56, 244);
            this.btnManagerCourse.Name = "btnManagerCourse";
            this.btnManagerCourse.Size = new System.Drawing.Size(147, 37);
            this.btnManagerCourse.TabIndex = 3;
            this.btnManagerCourse.Text = "Manager Course";
            this.btnManagerCourse.UseVisualStyleBackColor = true;
            this.btnManagerCourse.Click += new System.EventHandler(this.btnManagerCourse_Click);
            // 
            // btnManagerLecturer
            // 
            this.btnManagerLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerLecturer.Location = new System.Drawing.Point(321, 146);
            this.btnManagerLecturer.Name = "btnManagerLecturer";
            this.btnManagerLecturer.Size = new System.Drawing.Size(162, 37);
            this.btnManagerLecturer.TabIndex = 4;
            this.btnManagerLecturer.Text = "Manager Lecturer";
            this.btnManagerLecturer.UseVisualStyleBackColor = true;
            // 
            // btnManagerYearStudy
            // 
            this.btnManagerYearStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerYearStudy.Location = new System.Drawing.Point(321, 244);
            this.btnManagerYearStudy.Name = "btnManagerYearStudy";
            this.btnManagerYearStudy.Size = new System.Drawing.Size(162, 35);
            this.btnManagerYearStudy.TabIndex = 5;
            this.btnManagerYearStudy.Text = "Manager Year Study";
            this.btnManagerYearStudy.UseVisualStyleBackColor = true;
            // 
            // btnManagerStudentStudy
            // 
            this.btnManagerStudentStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerStudentStudy.Location = new System.Drawing.Point(565, 146);
            this.btnManagerStudentStudy.Name = "btnManagerStudentStudy";
            this.btnManagerStudentStudy.Size = new System.Drawing.Size(209, 37);
            this.btnManagerStudentStudy.TabIndex = 6;
            this.btnManagerStudentStudy.Text = "Manager Student Study";
            this.btnManagerStudentStudy.UseVisualStyleBackColor = true;
            this.btnManagerStudentStudy.Click += new System.EventHandler(this.btnManagerStudentStudy_Click);
            // 
            // btnManagerGradeComponent
            // 
            this.btnManagerGradeComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerGradeComponent.Location = new System.Drawing.Point(565, 244);
            this.btnManagerGradeComponent.Name = "btnManagerGradeComponent";
            this.btnManagerGradeComponent.Size = new System.Drawing.Size(209, 35);
            this.btnManagerGradeComponent.TabIndex = 7;
            this.btnManagerGradeComponent.Text = "Manager Grade Component";
            this.btnManagerGradeComponent.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManagerGradeComponent);
            this.Controls.Add(this.btnManagerStudentStudy);
            this.Controls.Add(this.btnManagerYearStudy);
            this.Controls.Add(this.btnManagerLecturer);
            this.Controls.Add(this.btnManagerCourse);
            this.Controls.Add(this.btnManagerStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManagerStudent;
        private System.Windows.Forms.Button btnManagerCourse;
        private System.Windows.Forms.Button btnManagerLecturer;
        private System.Windows.Forms.Button btnManagerYearStudy;
        private System.Windows.Forms.Button btnManagerStudentStudy;
        private System.Windows.Forms.Button btnManagerGradeComponent;
    }
}