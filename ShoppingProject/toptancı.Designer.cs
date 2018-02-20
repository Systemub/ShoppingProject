namespace ShoppingProject
{
    partial class toptancı
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
            this.button1 = new System.Windows.Forms.Button();
            this.top_isim = new System.Windows.Forms.Label();
            this.alinan_urun_mik = new System.Windows.Forms.Label();
            this.top_name_tbox = new System.Windows.Forms.TextBox();
            this.alinan_urun_miktbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Borç Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // top_isim
            // 
            this.top_isim.AutoSize = true;
            this.top_isim.Location = new System.Drawing.Point(101, 56);
            this.top_isim.Name = "top_isim";
            this.top_isim.Size = new System.Drawing.Size(73, 13);
            this.top_isim.TabIndex = 1;
            this.top_isim.Text = "Toptancı İsmi:";
            // 
            // alinan_urun_mik
            // 
            this.alinan_urun_mik.AutoSize = true;
            this.alinan_urun_mik.Location = new System.Drawing.Point(101, 92);
            this.alinan_urun_mik.Name = "alinan_urun_mik";
            this.alinan_urun_mik.Size = new System.Drawing.Size(29, 13);
            this.alinan_urun_mik.TabIndex = 2;
            this.alinan_urun_mik.Text = "Fiyat";
            // 
            // top_name_tbox
            // 
            this.top_name_tbox.Location = new System.Drawing.Point(253, 56);
            this.top_name_tbox.Name = "top_name_tbox";
            this.top_name_tbox.Size = new System.Drawing.Size(258, 20);
            this.top_name_tbox.TabIndex = 4;
            // 
            // alinan_urun_miktbox
            // 
            this.alinan_urun_miktbox.Location = new System.Drawing.Point(253, 92);
            this.alinan_urun_miktbox.Name = "alinan_urun_miktbox";
            this.alinan_urun_miktbox.Size = new System.Drawing.Size(258, 20);
            this.alinan_urun_miktbox.TabIndex = 5;
            // 
            // toptancı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.alinan_urun_miktbox);
            this.Controls.Add(this.top_name_tbox);
            this.Controls.Add(this.alinan_urun_mik);
            this.Controls.Add(this.top_isim);
            this.Controls.Add(this.button1);
            this.Name = "toptancı";
            this.Text = "toptancı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label top_isim;
        private System.Windows.Forms.Label alinan_urun_mik;
        private System.Windows.Forms.TextBox top_name_tbox;
        private System.Windows.Forms.TextBox alinan_urun_miktbox;
    }
}