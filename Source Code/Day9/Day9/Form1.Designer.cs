namespace Day9
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnElementAt = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnAllAny = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.btnLINQ = new System.Windows.Forms.Button();
            this.btnLINQ1 = new System.Windows.Forms.Button();
            this.btnLINQ2 = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(229, 34);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Query ";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(217, 73);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(100, 24);
            this.btnFirstOrDefault.TabIndex = 2;
            this.btnFirstOrDefault.Text = "First Or Default";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnElementAt
            // 
            this.btnElementAt.Location = new System.Drawing.Point(229, 112);
            this.btnElementAt.Name = "btnElementAt";
            this.btnElementAt.Size = new System.Drawing.Size(75, 23);
            this.btnElementAt.TabIndex = 3;
            this.btnElementAt.Text = "ElementAt";
            this.btnElementAt.UseVisualStyleBackColor = true;
            this.btnElementAt.Click += new System.EventHandler(this.btnElementAt_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(229, 150);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 4;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnAllAny
            // 
            this.btnAllAny.Location = new System.Drawing.Point(229, 186);
            this.btnAllAny.Name = "btnAllAny";
            this.btnAllAny.Size = new System.Drawing.Size(75, 23);
            this.btnAllAny.TabIndex = 5;
            this.btnAllAny.Text = "All Any";
            this.btnAllAny.UseVisualStyleBackColor = true;
            this.btnAllAny.Click += new System.EventHandler(this.btnAllAny_Click);
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(229, 228);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(75, 23);
            this.btnDistinct.TabIndex = 6;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // btnLINQ
            // 
            this.btnLINQ.Location = new System.Drawing.Point(336, 52);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new System.Drawing.Size(75, 23);
            this.btnLINQ.TabIndex = 7;
            this.btnLINQ.Text = "LINQ";
            this.btnLINQ.UseVisualStyleBackColor = true;
            this.btnLINQ.Click += new System.EventHandler(this.btnLINQ_Click);
            // 
            // btnLINQ1
            // 
            this.btnLINQ1.Location = new System.Drawing.Point(336, 112);
            this.btnLINQ1.Name = "btnLINQ1";
            this.btnLINQ1.Size = new System.Drawing.Size(75, 23);
            this.btnLINQ1.TabIndex = 8;
            this.btnLINQ1.Text = "LINQ1";
            this.btnLINQ1.UseVisualStyleBackColor = true;
            this.btnLINQ1.Click += new System.EventHandler(this.btnLINQ1_Click);
            // 
            // btnLINQ2
            // 
            this.btnLINQ2.Location = new System.Drawing.Point(336, 165);
            this.btnLINQ2.Name = "btnLINQ2";
            this.btnLINQ2.Size = new System.Drawing.Size(75, 23);
            this.btnLINQ2.TabIndex = 9;
            this.btnLINQ2.Text = "LINQ2";
            this.btnLINQ2.UseVisualStyleBackColor = true;
            this.btnLINQ2.Click += new System.EventHandler(this.btnLINQ2_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(336, 228);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 10;
            this.btnJoin.Text = "LINQ Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 289);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnLINQ2);
            this.Controls.Add(this.btnLINQ1);
            this.Controls.Add(this.btnLINQ);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnAllAny);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnElementAt);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button btnElementAt;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnAllAny;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.Button btnLINQ;
        private System.Windows.Forms.Button btnLINQ1;
        private System.Windows.Forms.Button btnLINQ2;
        private System.Windows.Forms.Button btnJoin;
    }
}

