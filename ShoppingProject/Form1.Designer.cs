namespace ShoppingProject
{
    partial class ShoppingMainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cirotooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cirobtn = new System.Windows.Forms.Button();
            this.anliksatistooltip = new System.Windows.Forms.ToolTip(this.components);
            this.anliksatisbtn = new System.Windows.Forms.Button();
            this.istatistiktooltip = new System.Windows.Forms.ToolTip(this.components);
            this.istatistikbtn = new System.Windows.Forms.Button();
            this.datealert = new System.Windows.Forms.Button();
            this.depobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cirobtn
            // 
            this.cirobtn.BackgroundImage = global::ShoppingProject.Properties.Resources._1492019209_store_building;
            this.cirobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cirobtn.FlatAppearance.BorderSize = 0;
            this.cirobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.cirobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.cirobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cirobtn.Location = new System.Drawing.Point(51, 24);
            this.cirobtn.Name = "cirobtn";
            this.cirobtn.Size = new System.Drawing.Size(172, 144);
            this.cirobtn.TabIndex = 0;
            this.cirotooltip.SetToolTip(this.cirobtn, "Ciro");
            this.cirobtn.UseVisualStyleBackColor = true;
            // 
            // anliksatisbtn
            // 
            this.anliksatisbtn.BackgroundImage = global::ShoppingProject.Properties.Resources._1492019352_shopping_basket_2;
            this.anliksatisbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anliksatisbtn.FlatAppearance.BorderSize = 0;
            this.anliksatisbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.anliksatisbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.anliksatisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anliksatisbtn.Location = new System.Drawing.Point(303, 12);
            this.anliksatisbtn.Name = "anliksatisbtn";
            this.anliksatisbtn.Size = new System.Drawing.Size(172, 144);
            this.anliksatisbtn.TabIndex = 1;
            this.anliksatistooltip.SetToolTip(this.anliksatisbtn, "ANLIK SATIŞ");
            this.anliksatisbtn.UseVisualStyleBackColor = true;
            this.anliksatisbtn.Click += new System.EventHandler(this.anliksatisbtn_Click);
            // 
            // istatistikbtn
            // 
            this.istatistikbtn.BackgroundImage = global::ShoppingProject.Properties.Resources._1492019246_cmyk_06;
            this.istatistikbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.istatistikbtn.FlatAppearance.BorderSize = 0;
            this.istatistikbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.istatistikbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.istatistikbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.istatistikbtn.Location = new System.Drawing.Point(554, 24);
            this.istatistikbtn.Name = "istatistikbtn";
            this.istatistikbtn.Size = new System.Drawing.Size(172, 144);
            this.istatistikbtn.TabIndex = 2;
            this.istatistiktooltip.SetToolTip(this.istatistikbtn, "İSTATİSTİK");
            this.istatistikbtn.UseVisualStyleBackColor = true;
            this.istatistikbtn.Click += new System.EventHandler(this.istatistikbtn_Click);
            // 
            // datealert
            // 
            this.datealert.BackgroundImage = global::ShoppingProject.Properties.Resources._1493164547_calendar;
            this.datealert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datealert.FlatAppearance.BorderSize = 0;
            this.datealert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datealert.Location = new System.Drawing.Point(303, 189);
            this.datealert.Name = "datealert";
            this.datealert.Size = new System.Drawing.Size(172, 144);
            this.datealert.TabIndex = 5;
            this.datealert.UseVisualStyleBackColor = true;
            this.datealert.Click += new System.EventHandler(this.datealert_Click);
            // 
            // depobtn
            // 
            this.depobtn.BackgroundImage = global::ShoppingProject.Properties.Resources._1492022893_self1;
            this.depobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.depobtn.FlatAppearance.BorderSize = 0;
            this.depobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.depobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.depobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depobtn.Location = new System.Drawing.Point(51, 205);
            this.depobtn.Name = "depobtn";
            this.depobtn.Size = new System.Drawing.Size(172, 144);
            this.depobtn.TabIndex = 3;
            this.depobtn.UseVisualStyleBackColor = true;
            this.depobtn.Click += new System.EventHandler(this.depobtn_Click);
            // 
            // ShoppingMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.datealert);
            this.Controls.Add(this.depobtn);
            this.Controls.Add(this.istatistikbtn);
            this.Controls.Add(this.anliksatisbtn);
            this.Controls.Add(this.cirobtn);
            this.Name = "ShoppingMainPage";
            this.Text = "                                                                                 " +
    "                 ShoppingProject";
            this.Load += new System.EventHandler(this.ShoppingMainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cirobtn;
        private System.Windows.Forms.Button anliksatisbtn;
        private System.Windows.Forms.Button istatistikbtn;
        private System.Windows.Forms.Button depobtn;
        private System.Windows.Forms.ToolTip istatistiktooltip;
        private System.Windows.Forms.ToolTip anliksatistooltip;
        private System.Windows.Forms.ToolTip cirotooltip;
        private System.Windows.Forms.Button datealert;
    }
}

