namespace Project
{
    partial class FormCourse
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
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelFirstDateCreated = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtFirstDateCreated = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(55, 152);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(68, 13);
            this.labelCourseName.TabIndex = 1;
            this.labelCourseName.Text = "CourseName";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(339, 84);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(34, 13);
            this.labelCredit.TabIndex = 2;
            this.labelCredit.Text = "Credit";
            // 
            // labelFirstDateCreated
            // 
            this.labelFirstDateCreated.AutoSize = true;
            this.labelFirstDateCreated.Location = new System.Drawing.Point(339, 152);
            this.labelFirstDateCreated.Name = "labelFirstDateCreated";
            this.labelFirstDateCreated.Size = new System.Drawing.Size(86, 13);
            this.labelFirstDateCreated.TabIndex = 3;
            this.labelFirstDateCreated.Text = "FirstDateCreated";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(165, 81);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(100, 20);
            this.txtCourseID.TabIndex = 4;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(165, 152);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtCourseName.TabIndex = 5;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(448, 81);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 20);
            this.txtCredit.TabIndex = 6;
            // 
            // txtFirstDateCreated
            // 
            this.txtFirstDateCreated.Location = new System.Drawing.Point(448, 149);
            this.txtFirstDateCreated.Name = "txtFirstDateCreated";
            this.txtFirstDateCreated.Size = new System.Drawing.Size(100, 20);
            this.txtFirstDateCreated.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(48, 381);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(263, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 128);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Location = new System.Drawing.Point(55, 84);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(51, 13);
            this.labelCourseID.TabIndex = 13;
            this.labelCourseID.Text = "CourseID";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(473, 381);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "MANAGER COURSE";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(371, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 416);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.labelCourseID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtFirstDateCreated);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.labelFirstDateCreated);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.labelCourseName);
            this.Name = "FormCourse";
            this.Text = "FormCourse";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelFirstDateCreated;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtFirstDateCreated;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}

