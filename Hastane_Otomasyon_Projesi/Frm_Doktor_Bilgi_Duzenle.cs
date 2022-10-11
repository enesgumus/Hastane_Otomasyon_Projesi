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
    public partial class Frm_Doktor_Bilgi_Duzenle : Form
    {
        public Frm_Doktor_Bilgi_Duzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;

        private void Frm_Doktor_Bilgi_Duzenle_Load(object sender, EventArgs e)
        {
            msk_tc.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msk_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                cmb_brans.Text = dr[3].ToString();
                txt_sifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_bilgi_duzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 Where DoktorTC=@p5",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",txt_ad.Text);
            komut1.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut1.Parameters.AddWithValue("@p3",cmb_brans.Text);
            komut1.Parameters.AddWithValue("@p4",txt_sifre.Text);
            komut1.Parameters.AddWithValue("@p5",msk_tc.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
