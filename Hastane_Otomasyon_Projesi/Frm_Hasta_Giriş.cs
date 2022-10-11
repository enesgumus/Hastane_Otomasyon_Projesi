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
    public partial class Frm_Hasta_Giriş : Form
    {
        public Frm_Hasta_Giriş()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void lnk_uye_ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Hasta_Kayit fhk = new Frm_Hasta_Kayit();
            fhk.Show();
        }

        private void Btn_Giris_Yap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",msk_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_Hasta_Detay fr = new Frm_Hasta_Detay();
                fr.tc=msk_tc.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();

        }
    }
}
