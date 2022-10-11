using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hastane_Otomasyon_Projesi
{
    public partial class Frm_Doktor_Detay : Form
    {
        public Frm_Doktor_Detay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void Frm_Doktor_Detay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = TC;


            //Doktor Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();


            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuDoktor='" + lbl_adsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);    
            dataGridView1.DataSource = dt;


        }

        private void btn_bilgi_duzenle_Click(object sender, EventArgs e)
        {
            Frm_Doktor_Bilgi_Duzenle fd = new Frm_Doktor_Bilgi_Duzenle();
            fd.TCNO = lbl_tc.Text;
            fd.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fr = new Frm_Duyurular();
            fr.Show();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rch_sikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();  
        }
    }
}
