namespace ShoppingProject
{
    partial class depokayit
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
            this.barkodlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urunmiklbl = new System.Windows.Forms.Label();
            this.urunbrmfytlabel = new System.Windows.Forms.Label();
            this.barkodtbox = new System.Windows.Forms.TextBox();
            this.urunaditbox = new System.Windows.Forms.TextBox();
            this.urunmiktbox = new System.Windows.Forms.TextBox();
            this.urunbirimfiyattbox = new System.Windows.Forms.TextBox();
            this.depouruneklebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barkodlbl
            // 
            this.barkodlbl.AutoSize = true;
            this.barkodlbl.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.barkodlbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.barkodlbl.Location = new System.Drawing.Point(55, 46);
            this.barkodlbl.Name = "barkodlbl";
            this.barkodlbl.Size = new System.Drawing.Size(70, 20);
            this.barkodlbl.TabIndex = 0;
            this.barkodlbl.Text = "Barkod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(55, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // urunmiklbl
            // 
            this.urunmiklbl.AutoSize = true;
            this.urunmiklbl.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.urunmiklbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.urunmiklbl.Location = new System.Drawing.Point(55, 140);
            this.urunmiklbl.Name = "urunmiklbl";
            this.urunmiklbl.Size = new System.Drawing.Size(122, 20);
            this.urunmiklbl.TabIndex = 2;
            this.urunmiklbl.Text = "Ürün Miktarı:";
            // 
            // urunbrmfytlabel
            // 
            this.urunbrmfytlabel.AutoSize = true;
            this.urunbrmfytlabel.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.urunbrmfytlabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.urunbrmfytlabel.Location = new System.Drawing.Point(55, 188);
            this.urunbrmfytlabel.Name = "urunbrmfytlabel";
            this.urunbrmfytlabel.Size = new System.Drawing.Size(152, 20);
            this.urunbrmfytlabel.TabIndex = 3;
            this.urunbrmfytlabel.Text = "Ürün Birim Fiyatı:";
            // 
            // barkodtbox
            // 
            this.barkodtbox.Location = new System.Drawing.Point(221, 46);
            this.barkodtbox.Name = "barkodtbox";
            this.barkodtbox.Size = new System.Drawing.Size(219, 20);
            this.barkodtbox.TabIndex = 4;
            // 
            // urunaditbox
            // 
            this.urunaditbox.Location = new System.Drawing.Point(221, 91);
            this.urunaditbox.Name = "urunaditbox";
            this.urunaditbox.Size = new System.Drawing.Size(219, 20);
            this.urunaditbox.TabIndex = 5;
            // 
            // urunmiktbox
            // 
            this.urunmiktbox.Location = new System.Drawing.Point(221, 142);
            this.urunmiktbox.Name = "urunmiktbox";
            this.urunmiktbox.Size = new System.Drawing.Size(219, 20);
            this.urunmiktbox.TabIndex = 6;
            // 
            // urunbirimfiyattbox
            // 
            this.urunbirimfiyattbox.Location = new System.Drawing.Point(221, 187);
            this.urunbirimfiyattbox.Name = "urunbirimfiyattbox";
            this.urunbirimfiyattbox.Size = new System.Drawing.Size(219, 20);
            this.urunbirimfiyattbox.TabIndex = 7;
            // 
            // depouruneklebtn
            // 
            this.depouruneklebtn.BackgroundImage = global::ShoppingProject.Properties.Resources._1492025430_Accept_check_data_storage_folder_ok;
            this.depouruneklebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.depouruneklebtn.FlatAppearance.BorderSize = 0;
            this.depouruneklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depouruneklebtn.Location = new System.Drawing.Point(384, 284);
            this.depouruneklebtn.Name = "depouruneklebtn";
            this.depouruneklebtn.Size = new System.Drawing.Size(121, 65);
            this.depouruneklebtn.TabIndex = 8;
            this.depouruneklebtn.UseVisualStyleBackColor = true;
            this.depouruneklebtn.Click += new System.EventHandler(this.depouruneklebtn_Click);
            // 
            // depokayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.depouruneklebtn);
            this.Controls.Add(this.urunbirimfiyattbox);
            this.Controls.Add(this.urunmiktbox);
            this.Controls.Add(this.urunaditbox);
            this.Controls.Add(this.barkodtbox);
            this.Controls.Add(this.urunbrmfytlabel);
            this.Controls.Add(this.urunmiklbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barkodlbl);
            this.Name = "depokayit";
            this.Text = "depokayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label barkodlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label urunmiklbl;
        private System.Windows.Forms.Label urunbrmfytlabel;
        private System.Windows.Forms.TextBox barkodtbox;
        private System.Windows.Forms.TextBox urunaditbox;
        private System.Windows.Forms.TextBox urunmiktbox;
        private System.Windows.Forms.TextBox urunbirimfiyattbox;
        private System.Windows.Forms.Button depouruneklebtn;
    }
}