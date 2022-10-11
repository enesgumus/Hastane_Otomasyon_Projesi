namespace Hastane_Otomasyon_Projesi
{
    partial class Frm_Sekreter_Detay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sekreter_Detay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.rch_duyuru_olustur = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.chc_durum = new System.Windows.Forms.CheckBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.msk_saat = new System.Windows.Forms.MaskedTextBox();
            this.msk_tarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Btn_Randevu_listesi = new System.Windows.Forms.Button();
            this.Btn_brans_paneli = new System.Windows.Forms.Button();
            this.btn_doktor_paneli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(184, 121);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(119, 35);
            this.lbl_adsoyad.TabIndex = 4;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(184, 64);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(169, 35);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_olustur);
            this.groupBox2.Controls.Add(this.rch_duyuru_olustur);
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btn_olustur
            // 
            this.btn_olustur.BackColor = System.Drawing.Color.Lime;
            this.btn_olustur.Location = new System.Drawing.Point(74, 257);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(256, 44);
            this.btn_olustur.TabIndex = 2;
            this.btn_olustur.Text = "Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = false;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // rch_duyuru_olustur
            // 
            this.rch_duyuru_olustur.Location = new System.Drawing.Point(18, 39);
            this.rch_duyuru_olustur.Name = "rch_duyuru_olustur";
            this.rch_duyuru_olustur.Size = new System.Drawing.Size(358, 196);
            this.rch_duyuru_olustur.TabIndex = 2;
            this.rch_duyuru_olustur.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kaydet);
            this.groupBox3.Controls.Add(this.chc_durum);
            this.groupBox3.Controls.Add(this.msk_tc);
            this.groupBox3.Controls.Add(this.cmb_doktor);
            this.groupBox3.Controls.Add(this.cmb_brans);
            this.groupBox3.Controls.Add(this.msk_saat);
            this.groupBox3.Controls.Add(this.msk_tarih);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(463, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 604);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Lime;
            this.btn_kaydet.Location = new System.Drawing.Point(71, 461);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(256, 57);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // chc_durum
            // 
            this.chc_durum.AutoSize = true;
            this.chc_durum.Location = new System.Drawing.Point(132, 408);
            this.chc_durum.Name = "chc_durum";
            this.chc_durum.Size = new System.Drawing.Size(120, 39);
            this.chc_durum.TabIndex = 3;
            this.chc_durum.Text = "Durum";
            this.chc_durum.UseVisualStyleBackColor = true;
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(132, 353);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(189, 40);
            this.msk_tc.TabIndex = 13;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(132, 290);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(189, 41);
            this.cmb_doktor.TabIndex = 12;
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(132, 233);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(189, 41);
            this.cmb_brans.TabIndex = 11;
            this.cmb_brans.SelectedIndexChanged += new System.EventHandler(this.cmb_brans_SelectedIndexChanged);
            // 
            // msk_saat
            // 
            this.msk_saat.Location = new System.Drawing.Point(132, 174);
            this.msk_saat.Mask = "00:00";
            this.msk_saat.Name = "msk_saat";
            this.msk_saat.Size = new System.Drawing.Size(189, 40);
            this.msk_saat.TabIndex = 10;
            this.msk_saat.ValidatingType = typeof(System.DateTime);
            // 
            // msk_tarih
            // 
            this.msk_tarih.Location = new System.Drawing.Point(132, 116);
            this.msk_tarih.Mask = "00/00/0000";
            this.msk_tarih.Name = "msk_tarih";
            this.msk_tarih.Size = new System.Drawing.Size(189, 40);
            this.msk_tarih.TabIndex = 3;
            this.msk_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(132, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(189, 40);
            this.txt_id.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 35);
            this.label10.TabIndex = 8;
            this.label10.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 35);
            this.label9.TabIndex = 7;
            this.label9.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 35);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 35);
            this.label7.TabIndex = 5;
            this.label7.Text = "Saat:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(895, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 323);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(889, 343);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(487, 395);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(481, 356);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.Btn_Randevu_listesi);
            this.groupBox6.Controls.Add(this.Btn_brans_paneli);
            this.groupBox6.Controls.Add(this.btn_doktor_paneli);
            this.groupBox6.Location = new System.Drawing.Point(12, 622);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(834, 116);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // Btn_Randevu_listesi
            // 
            this.Btn_Randevu_listesi.Location = new System.Drawing.Point(425, 47);
            this.Btn_Randevu_listesi.Name = "Btn_Randevu_listesi";
            this.Btn_Randevu_listesi.Size = new System.Drawing.Size(217, 55);
            this.Btn_Randevu_listesi.TabIndex = 10;
            this.Btn_Randevu_listesi.Text = "Randevu Liste";
            this.Btn_Randevu_listesi.UseVisualStyleBackColor = true;
            this.Btn_Randevu_listesi.Click += new System.EventHandler(this.Btn_Randevu_listesi_Click);
            // 
            // Btn_brans_paneli
            // 
            this.Btn_brans_paneli.Location = new System.Drawing.Point(214, 47);
            this.Btn_brans_paneli.Name = "Btn_brans_paneli";
            this.Btn_brans_paneli.Size = new System.Drawing.Size(205, 55);
            this.Btn_brans_paneli.TabIndex = 9;
            this.Btn_brans_paneli.Text = "Branş Paneli";
            this.Btn_brans_paneli.UseVisualStyleBackColor = true;
            this.Btn_brans_paneli.Click += new System.EventHandler(this.Btn_brans_paneli_Click);
            // 
            // btn_doktor_paneli
            // 
            this.btn_doktor_paneli.Location = new System.Drawing.Point(6, 47);
            this.btn_doktor_paneli.Name = "btn_doktor_paneli";
            this.btn_doktor_paneli.Size = new System.Drawing.Size(202, 55);
            this.btn_doktor_paneli.TabIndex = 8;
            this.btn_doktor_paneli.Text = "Doktor Paneli";
            this.btn_doktor_paneli.UseVisualStyleBackColor = true;
            this.btn_doktor_paneli.Click += new System.EventHandler(this.btn_doktor_paneli_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Sekreter_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1417, 783);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Sekreter_Detay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.Frm_Sekreter_Detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.RichTextBox rch_duyuru_olustur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.MaskedTextBox msk_saat;
        private System.Windows.Forms.MaskedTextBox msk_tarih;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.CheckBox chc_durum;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Btn_Randevu_listesi;
        private System.Windows.Forms.Button Btn_brans_paneli;
        private System.Windows.Forms.Button btn_doktor_paneli;
        private System.Windows.Forms.Button button1;
    }
}