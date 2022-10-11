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
    public partial class Frm_Hasta_Kayit : Form
    {
        public Frm_Hasta_Kayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btn_kayit_yap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txt_ad.Text);
            komut.Parameters.AddWithValue("@p2",txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3",msk_tc.Text);
            komut.Parameters.AddWithValue("@p4", msk_telefon.Text);
            komut.Parameters.AddWithValue("@p5", txt_sifre.Text);
            komut.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + txt_sifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
