using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BankaHesabi
{
   public class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-INSQH5J \\SQLEXPRESS;Initial Catalog=BankaHesab;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
