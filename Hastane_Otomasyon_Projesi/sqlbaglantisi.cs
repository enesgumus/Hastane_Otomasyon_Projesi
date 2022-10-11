using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyon_Projesi
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
          SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-UCTBOF1K\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
