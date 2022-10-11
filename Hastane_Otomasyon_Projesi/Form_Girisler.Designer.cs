namespace Hastane_Otomasyon_Projesi
{
    partial class Form_Girisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Girisler));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sekreter_girisi = new System.Windows.Forms.Button();
            this.btn_doktor_girisi = new System.Windows.Forms.Button();
            this.btn_hasta_girisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(146, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 71);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gümüş Hastane";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sekreter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doktor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta";
            // 
            // btn_sekreter_girisi
            // 
            this.btn_sekreter_girisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sekreter_girisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekreter_girisi.BackgroundImage")));
            this.btn_sekreter_girisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sekreter_girisi.Location = new System.Drawing.Point(761, 262);
            this.btn_sekreter_girisi.Name = "btn_sekreter_girisi";
            this.btn_sekreter_girisi.Size = new System.Drawing.Size(308, 189);
            this.btn_sekreter_girisi.TabIndex = 4;
            this.btn_sekreter_girisi.UseVisualStyleBackColor = false;
            this.btn_sekreter_girisi.Click += new System.EventHandler(this.btn_sekreter_girisi_Click);
            // 
            // btn_doktor_girisi
            // 
            this.btn_doktor_girisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_doktor_girisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktor_girisi.BackgroundImage")));
            this.btn_doktor_girisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktor_girisi.Location = new System.Drawing.Point(430, 262);
            this.btn_doktor_girisi.Name = "btn_doktor_girisi";
            this.btn_doktor_girisi.Size = new System.Drawing.Size(305, 189);
            this.btn_doktor_girisi.TabIndex = 5;
            this.btn_doktor_girisi.UseVisualStyleBackColor = false;
            this.btn_doktor_girisi.Click += new System.EventHandler(this.btn_doktor_girisi_Click);
            // 
            // btn_hasta_girisi
            // 
            this.btn_hasta_girisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_hasta_girisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hasta_girisi.BackgroundImage")));
            this.btn_hasta_girisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hasta_girisi.Location = new System.Drawing.Point(83, 262);
            this.btn_hasta_girisi.Name = "btn_hasta_girisi";
            this.btn_hasta_girisi.Size = new System.Drawing.Size(302, 189);
            this.btn_hasta_girisi.TabIndex = 6;
            this.btn_hasta_girisi.UseVisualStyleBackColor = false;
            this.btn_hasta_girisi.Click += new System.EventHandler(this.btn_hasta_girisi_Click);
            // 
            // Form_Girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1113, 495);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sekreter_girisi);
            this.Controls.Add(this.btn_doktor_girisi);
            this.Controls.Add(this.btn_hasta_girisi);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form_Girisler";
            this.Text = "Gümüş Hastane Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sekreter_girisi;
        private System.Windows.Forms.Button btn_doktor_girisi;
        private System.Windows.Forms.Button btn_hasta_girisi;
    }
}