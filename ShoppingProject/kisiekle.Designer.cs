namespace ShoppingProject
{
    partial class kisiekleform
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
            this.musterino = new System.Windows.Forms.Label();
            this.musteriadi = new System.Windows.Forms.Label();
            this.mussoyadi = new System.Windows.Forms.Label();
            this.musnotextbox = new System.Windows.Forms.TextBox();
            this.musaditextbox = new System.Windows.Forms.TextBox();
            this.mussoyaditextbox = new System.Windows.Forms.TextBox();
            this.kisieklebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musterino
            // 
            this.musterino.AutoSize = true;
            this.musterino.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.musterino.ForeColor = System.Drawing.Color.OrangeRed;
            this.musterino.Location = new System.Drawing.Point(73, 42);
            this.musterino.Name = "musterino";
            this.musterino.Size = new System.Drawing.Size(103, 20);
            this.musterino.TabIndex = 0;
            this.musterino.Text = "Müşteri No:";
            // 
            // musteriadi
            // 
            this.musteriadi.AutoSize = true;
            this.musteriadi.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.musteriadi.ForeColor = System.Drawing.Color.OrangeRed;
            this.musteriadi.Location = new System.Drawing.Point(73, 89);
            this.musteriadi.Name = "musteriadi";
            this.musteriadi.Size = new System.Drawing.Size(107, 20);
            this.musteriadi.TabIndex = 1;
            this.musteriadi.Text = "Müşteri Adı:";
            // 
            // mussoyadi
            // 
            this.mussoyadi.AutoSize = true;
            this.mussoyadi.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.mussoyadi.ForeColor = System.Drawing.Color.OrangeRed;
            this.mussoyadi.Location = new System.Drawing.Point(73, 140);
            this.mussoyadi.Name = "mussoyadi";
            this.mussoyadi.Size = new System.Drawing.Size(132, 20);
            this.mussoyadi.TabIndex = 2;
            this.mussoyadi.Text = "Müşteri Soyadı:";
            // 
            // musnotextbox
            // 
            this.musnotextbox.Location = new System.Drawing.Point(233, 44);
            this.musnotextbox.Name = "musnotextbox";
            this.musnotextbox.Size = new System.Drawing.Size(226, 20);
            this.musnotextbox.TabIndex = 3;
            // 
            // musaditextbox
            // 
            this.musaditextbox.Location = new System.Drawing.Point(233, 89);
            this.musaditextbox.Name = "musaditextbox";
            this.musaditextbox.Size = new System.Drawing.Size(226, 20);
            this.musaditextbox.TabIndex = 4;
            // 
            // mussoyaditextbox
            // 
            this.mussoyaditextbox.Location = new System.Drawing.Point(233, 142);
            this.mussoyaditextbox.Name = "mussoyaditextbox";
            this.mussoyaditextbox.Size = new System.Drawing.Size(226, 20);
            this.mussoyaditextbox.TabIndex = 5;
            // 
            // kisieklebtn
            // 
            this.kisieklebtn.BackgroundImage = global::ShoppingProject.Properties.Resources._1492026561_sign_add;
            this.kisieklebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kisieklebtn.FlatAppearance.BorderSize = 0;
            this.kisieklebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.kisieklebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.kisieklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kisieklebtn.Location = new System.Drawing.Point(367, 218);
            this.kisieklebtn.Name = "kisieklebtn";
            this.kisieklebtn.Size = new System.Drawing.Size(79, 59);
            this.kisieklebtn.TabIndex = 6;
            this.kisieklebtn.UseVisualStyleBackColor = true;
            this.kisieklebtn.Click += new System.EventHandler(this.kisieklebtn_Click);
            // 
            // kisiekleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.kisieklebtn);
            this.Controls.Add(this.mussoyaditextbox);
            this.Controls.Add(this.musaditextbox);
            this.Controls.Add(this.musnotextbox);
            this.Controls.Add(this.mussoyadi);
            this.Controls.Add(this.musteriadi);
            this.Controls.Add(this.musterino);
            this.Name = "kisiekleform";
            this.Text = "kisiekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musterino;
        private System.Windows.Forms.Label musteriadi;
        private System.Windows.Forms.Label mussoyadi;
        private System.Windows.Forms.TextBox musnotextbox;
        private System.Windows.Forms.TextBox musaditextbox;
        private System.Windows.Forms.TextBox mussoyaditextbox;
        private System.Windows.Forms.Button kisieklebtn;
    }
}