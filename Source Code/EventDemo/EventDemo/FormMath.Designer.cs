namespace EventDemo
{
    partial class FormMath
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnXOfN = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(97, 32);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(97, 92);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(13, 38);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(50, 13);
            this.labelNumber1.TabIndex = 2;
            this.labelNumber1.Text = "Number1";
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(12, 99);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(50, 13);
            this.labelNumber2.TabIndex = 3;
            this.labelNumber2.Text = "Number2";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(226, 63);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(93, 33);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(97, 175);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 6;
            this.btnMul.Text = "Mul";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnXOfN
            // 
            this.btnXOfN.Location = new System.Drawing.Point(178, 175);
            this.btnXOfN.Name = "btnXOfN";
            this.btnXOfN.Size = new System.Drawing.Size(75, 23);
            this.btnXOfN.TabIndex = 7;
            this.btnXOfN.Text = "X of N";
            this.btnXOfN.UseVisualStyleBackColor = true;
            this.btnXOfN.Click += new System.EventHandler(this.btnXOfN_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 373);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnXOfN);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "FormMath";
            this.Text = "FormMath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnXOfN;
        private System.Windows.Forms.Button button4;
    }
}