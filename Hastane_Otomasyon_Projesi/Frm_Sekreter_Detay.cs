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
    public partial class Frm_Sekreter_Detay : Form
    {
        public Frm_Sekreter_Detay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCnumara;
        private void Frm_Sekreter_Detay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = TCnumara;

            //AdSoyad

            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lbl_tc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbl_adsoyad.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();



            //Branşları DataGride Aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd From Tbl_Brans",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //Doktorları Listeye Ekleme

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı Combobox'a aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();



        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",msk_tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msk_saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmb_doktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu...");

        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_doktor.Items.Add(dr[0] + " " + dr[1]);

            }
            bgl.baglanti().Close();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",rch_duyuru_olustur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturdu..");

        }

        private void btn_doktor_paneli_Click(object sender, EventArgs e)
        {
            Frm_Doktor_Paneli fdp = new Frm_Doktor_Paneli();
            fdp.Show();
        }

        private void Btn_brans_paneli_Click(object sender, EventArgs e)
        {
            Frm_Brans frb = new Frm_Brans();
            frb.Show();
        }

        private void Btn_Randevu_listesi_Click(object sender, EventArgs e)
        {
            Frm_Randevu_Listesi frd = new Frm_Randevu_Listesi();
            frd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fd = new Frm_Duyurular();
            fd.Show();
        }
    }
}
