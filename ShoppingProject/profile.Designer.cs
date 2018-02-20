namespace ShoppingProject
{
    partial class profile
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
            this.kulekle = new System.Windows.Forms.Button();
            this.kuldüzen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kulekle
            // 
            this.kulekle.BackgroundImage = global::ShoppingProject.Properties.Resources._1492023402_030;
            this.kulekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kulekle.FlatAppearance.BorderSize = 0;
            this.kulekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kulekle.Location = new System.Drawing.Point(89, 91);
            this.kulekle.Name = "kulekle";
            this.kulekle.Size = new System.Drawing.Size(219, 213);
            this.kulekle.TabIndex = 0;
            this.kulekle.UseVisualStyleBackColor = true;
            this.kulekle.Click += new System.EventHandler(this.kulekle_Click);
            // 
            // kuldüzen
            // 
            this.kuldüzen.BackgroundImage = global::ShoppingProject.Properties.Resources._1492023429_022;
            this.kuldüzen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kuldüzen.FlatAppearance.BorderSize = 0;
            this.kuldüzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuldüzen.Location = new System.Drawing.Point(400, 91);
            this.kuldüzen.Name = "kuldüzen";
            this.kuldüzen.Size = new System.Drawing.Size(219, 213);
            this.kuldüzen.TabIndex = 1;
            this.kuldüzen.UseVisualStyleBackColor = true;
            this.kuldüzen.Click += new System.EventHandler(this.kuldüzen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(129, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Kayıt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(438, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Düzenle";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kuldüzen);
            this.Controls.Add(this.kulekle);
            this.Name = "profile";
            this.Text = "profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kulekle;
        private System.Windows.Forms.Button kuldüzen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}