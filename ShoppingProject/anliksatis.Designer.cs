namespace ShoppingProject
{
    partial class anliksatis
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
            this.barkodlabel = new System.Windows.Forms.Label();
            this.barkodtextbox = new System.Windows.Forms.TextBox();
            this.adetlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eklebtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barkod_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_mik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_birim_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // barkodlabel
            // 
            this.barkodlabel.AutoSize = true;
            this.barkodlabel.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.barkodlabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.barkodlabel.Location = new System.Drawing.Point(71, 45);
            this.barkodlabel.Name = "barkodlabel";
            this.barkodlabel.Size = new System.Drawing.Size(70, 20);
            this.barkodlabel.TabIndex = 0;
            this.barkodlabel.Text = "Barkod:";
            // 
            // barkodtextbox
            // 
            this.barkodtextbox.Location = new System.Drawing.Point(178, 44);
            this.barkodtextbox.Name = "barkodtextbox";
            this.barkodtextbox.Size = new System.Drawing.Size(221, 20);
            this.barkodtextbox.TabIndex = 1;
            // 
            // adetlabel
            // 
            this.adetlabel.AutoSize = true;
            this.adetlabel.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.adetlabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.adetlabel.Location = new System.Drawing.Point(75, 93);
            this.adetlabel.Name = "adetlabel";
            this.adetlabel.Size = new System.Drawing.Size(49, 20);
            this.adetlabel.TabIndex = 2;
            this.adetlabel.Text = "Adet:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 3;
            // 
            // eklebtn
            // 
            this.eklebtn.BackgroundImage = global::ShoppingProject.Properties.Resources._1492019273_shopping_basket_add;
            this.eklebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eklebtn.FlatAppearance.BorderSize = 0;
            this.eklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eklebtn.Location = new System.Drawing.Point(310, 132);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(89, 65);
            this.eklebtn.TabIndex = 5;
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkod_no,
            this.urun_adi,
            this.urun_mik,
            this.urun_birim_fiyat});
            this.dataGridView2.Location = new System.Drawing.Point(24, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 138);
            this.dataGridView2.TabIndex = 6;
            // 
            // barkod_no
            // 
            this.barkod_no.HeaderText = "Barkod No";
            this.barkod_no.Name = "barkod_no";
            // 
            // urun_adi
            // 
            this.urun_adi.HeaderText = "Ürün Adı";
            this.urun_adi.Name = "urun_adi";
            // 
            // urun_mik
            // 
            this.urun_mik.HeaderText = "Ürün Miktarı";
            this.urun_mik.Name = "urun_mik";
            // 
            // urun_birim_fiyat
            // 
            this.urun_birim_fiyat.HeaderText = "Ürün Birim Fiyat";
            this.urun_birim_fiyat.Name = "urun_birim_fiyat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // anliksatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(844, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adetlabel);
            this.Controls.Add(this.barkodtextbox);
            this.Controls.Add(this.barkodlabel);
            this.Name = "anliksatis";
            this.Text = "anliksatis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label barkodlabel;
        private System.Windows.Forms.TextBox barkodtextbox;
        private System.Windows.Forms.Label adetlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_mik;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_birim_fiyat;
        private System.Windows.Forms.Button button1;
    }
}