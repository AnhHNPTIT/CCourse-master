namespace Day4
{
    partial class Form2
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fromFileCheckBox = new System.Windows.Forms.CheckBox();
            this.fromMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.searchButton = new System.Windows.Forms.Button();
            this.textSearchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text To Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From File";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(196, 77);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 3;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "From A Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(164, 133);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(229, 158);
            this.messageTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "From Table Customer";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(217, 331);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Table in a Database";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fromFileCheckBox
            // 
            this.fromFileCheckBox.AutoSize = true;
            this.fromFileCheckBox.Location = new System.Drawing.Point(457, 83);
            this.fromFileCheckBox.Name = "fromFileCheckBox";
            this.fromFileCheckBox.Size = new System.Drawing.Size(65, 17);
            this.fromFileCheckBox.TabIndex = 8;
            this.fromFileCheckBox.Text = "From file";
            this.fromFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // fromMessageCheckBox
            // 
            this.fromMessageCheckBox.AutoSize = true;
            this.fromMessageCheckBox.Location = new System.Drawing.Point(457, 135);
            this.fromMessageCheckBox.Name = "fromMessageCheckBox";
            this.fromMessageCheckBox.Size = new System.Drawing.Size(94, 17);
            this.fromMessageCheckBox.TabIndex = 9;
            this.fromMessageCheckBox.Text = "From message";
            this.fromMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(457, 30);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textSearchTextBox
            // 
            this.textSearchTextBox.Location = new System.Drawing.Point(164, 30);
            this.textSearchTextBox.Name = "textSearchTextBox";
            this.textSearchTextBox.Size = new System.Drawing.Size(229, 20);
            this.textSearchTextBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 361);
            this.Controls.Add(this.textSearchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fromMessageCheckBox);
            this.Controls.Add(this.fromFileCheckBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "SearchAString";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox fromFileCheckBox;
        private System.Windows.Forms.CheckBox fromMessageCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textSearchTextBox;
    }
}