namespace ShoppingProject
{
    partial class odemeal
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
            this.odenen = new System.Windows.Forms.Label();
            this.tarihh = new System.Windows.Forms.Label();
            this.musno_tbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No:";
            // 
            // odenen
            // 
            this.odenen.AutoSize = true;
            this.odenen.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.odenen.ForeColor = System.Drawing.Color.OrangeRed;
            this.odenen.Location = new System.Drawing.Point(49, 102);
            this.odenen.Name = "odenen";
            this.odenen.Size = new System.Drawing.Size(125, 20);
            this.odenen.TabIndex = 1;
            this.odenen.Text = "Ödenen Tutar:";
            // 
            // tarihh
            // 
            this.tarihh.AutoSize = true;
            this.tarihh.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.tarihh.ForeColor = System.Drawing.Color.OrangeRed;
            this.tarihh.Location = new System.Drawing.Point(49, 161);
            this.tarihh.Name = "tarihh";
            this.tarihh.Size = new System.Drawing.Size(57, 20);
            this.tarihh.TabIndex = 2;
            this.tarihh.Text = "Tarih:";
            // 
            // musno_tbox
            // 
            this.musno_tbox.Location = new System.Drawing.Point(192, 49);
            this.musno_tbox.Name = "musno_tbox";
            this.musno_tbox.Size = new System.Drawing.Size(222, 20);
            this.musno_tbox.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(459, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ödemeyi Tamamla";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ShoppingProject.Properties.Resources._1492025430_Accept_check_data_storage_folder_ok;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(459, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 104);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // odemeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.musno_tbox);
            this.Controls.Add(this.tarihh);
            this.Controls.Add(this.odenen);
            this.Controls.Add(this.label1);
            this.Name = "odemeal";
            this.Text = "odemeal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label odenen;
        private System.Windows.Forms.Label tarihh;
        private System.Windows.Forms.TextBox musno_tbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}