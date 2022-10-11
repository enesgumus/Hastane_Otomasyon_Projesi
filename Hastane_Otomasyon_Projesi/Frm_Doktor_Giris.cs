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
    public partial class Frm_Doktor_Giris : Form
    {
        public Frm_Doktor_Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
                            

        private void Btn_Giris_Yap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTc=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            komut.Parameters.AddWithValue("@p2",txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_Doktor_Detay fdd = new Frm_Doktor_Detay();
                fdd.TC = msk_tc.Text;
                fdd.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya Şifre","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
            
        }
    }
}
