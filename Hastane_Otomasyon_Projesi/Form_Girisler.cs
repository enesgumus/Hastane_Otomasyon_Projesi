using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon_Projesi
{
    public partial class Form_Girisler : Form
    {
        public Form_Girisler()
        {
            InitializeComponent();
        }

        private void btn_hasta_girisi_Click(object sender, EventArgs e)
        {
            Frm_Hasta_Giriş frg = new Frm_Hasta_Giriş();
            frg.Show();
            
        }

        private void btn_doktor_girisi_Click(object sender, EventArgs e)
        {
            Frm_Doktor_Giris fdg = new Frm_Doktor_Giris();
            fdg.Show();
            
        }

        private void btn_sekreter_girisi_Click(object sender, EventArgs e)
        {
            Frm_Sekreter_Giris fsg = new Frm_Sekreter_Giris();
            fsg.Show();
           
        }

        
    }
}
