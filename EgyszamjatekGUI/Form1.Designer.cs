namespace EgyszamjatekGUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbDb = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbTippek = new System.Windows.Forms.TextBox();
            this.btnAd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Játékos tippjei";
            // 
            // lbDb
            // 
            this.lbDb.AutoSize = true;
            this.lbDb.Location = new System.Drawing.Point(322, 93);
            this.lbDb.Name = "lbDb";
            this.lbDb.Size = new System.Drawing.Size(36, 13);
            this.lbDb.TabIndex = 2;
            this.lbDb.Text = "## db";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(105, 52);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(142, 20);
            this.tbNev.TabIndex = 3;
            // 
            // tbTippek
            // 
            this.tbTippek.Location = new System.Drawing.Point(105, 90);
            this.tbTippek.Name = "tbTippek";
            this.tbTippek.Size = new System.Drawing.Size(192, 20);
            this.tbTippek.TabIndex = 4;
            this.tbTippek.TextChanged += new System.EventHandler(this.tbTippek_TextChanged);
            // 
            // btnAd
            // 
            this.btnAd.Location = new System.Drawing.Point(139, 157);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(149, 23);
            this.btnAd.TabIndex = 5;
            this.btnAd.Text = "Játékos hozzáadása";
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 192);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.tbTippek);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.lbDb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Egyszámjáték GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDb;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbTippek;
        private System.Windows.Forms.Button btnAd;
    }
}

