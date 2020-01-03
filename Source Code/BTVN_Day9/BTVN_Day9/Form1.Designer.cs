namespace BTVN_Day9
{
    partial class Form1
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
            this.labelResult = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(282, 61);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(130, 25);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "labelResult";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(112, 103);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count Digit";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(136, 40);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 20);
            this.txtString.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a string";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 147);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label1;
    }
}

