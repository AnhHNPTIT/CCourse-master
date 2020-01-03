namespace EventDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxOddNumbers = new System.Windows.Forms.ListBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnRemoveEvent = new System.Windows.Forms.Button();
            this.labelEventStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(129, 45);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxOddNumbers
            // 
            this.listBoxOddNumbers.FormattingEnabled = true;
            this.listBoxOddNumbers.Location = new System.Drawing.Point(129, 75);
            this.listBoxOddNumbers.Name = "listBoxOddNumbers";
            this.listBoxOddNumbers.Size = new System.Drawing.Size(120, 108);
            this.listBoxOddNumbers.TabIndex = 3;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(13, 217);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(141, 35);
            this.btnAddEvent.TabIndex = 4;
            this.btnAddEvent.Text = "Add Event Handler";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnRemoveEvent
            // 
            this.btnRemoveEvent.Location = new System.Drawing.Point(13, 281);
            this.btnRemoveEvent.Name = "btnRemoveEvent";
            this.btnRemoveEvent.Size = new System.Drawing.Size(141, 35);
            this.btnRemoveEvent.TabIndex = 5;
            this.btnRemoveEvent.Text = "Remove Event Handler";
            this.btnRemoveEvent.UseVisualStyleBackColor = true;
            this.btnRemoveEvent.Click += new System.EventHandler(this.btnRemoveEvent_Click);
            // 
            // labelEventStatus
            // 
            this.labelEventStatus.AutoSize = true;
            this.labelEventStatus.Location = new System.Drawing.Point(193, 261);
            this.labelEventStatus.Name = "labelEventStatus";
            this.labelEventStatus.Size = new System.Drawing.Size(35, 13);
            this.labelEventStatus.TabIndex = 6;
            this.labelEventStatus.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 389);
            this.Controls.Add(this.labelEventStatus);
            this.Controls.Add(this.btnRemoveEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.listBoxOddNumbers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxOddNumbers;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnRemoveEvent;
        private System.Windows.Forms.Label labelEventStatus;
    }
}

