namespace ShoppingProject
{
    partial class kuldüzen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.borcekle = new System.Windows.Forms.Button();
            this.odemeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 134);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖDEME AL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BORÇ EKLE";
            // 
            // borcekle
            // 
            this.borcekle.BackgroundImage = global::ShoppingProject.Properties.Resources._1492026480_sign_add;
            this.borcekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borcekle.FlatAppearance.BorderSize = 0;
            this.borcekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borcekle.Location = new System.Drawing.Point(631, 95);
            this.borcekle.Name = "borcekle";
            this.borcekle.Size = new System.Drawing.Size(117, 145);
            this.borcekle.TabIndex = 4;
            this.borcekle.UseVisualStyleBackColor = true;
            // 
            // odemeal
            // 
            this.odemeal.BackgroundImage = global::ShoppingProject.Properties.Resources._1493243100_06;
            this.odemeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.odemeal.FlatAppearance.BorderSize = 0;
            this.odemeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odemeal.Location = new System.Drawing.Point(485, 95);
            this.odemeal.Name = "odemeal";
            this.odemeal.Size = new System.Drawing.Size(117, 145);
            this.odemeal.TabIndex = 3;
            this.odemeal.UseVisualStyleBackColor = true;
            // 
            // kuldüzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.borcekle);
            this.Controls.Add(this.odemeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kuldüzen";
            this.Text = "kuldüzen";
            this.Load += new System.EventHandler(this.kuldüzen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button odemeal;
        private System.Windows.Forms.Button borcekle;
    }
}