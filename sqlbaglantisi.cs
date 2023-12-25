using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Proje_Hastane
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-9R5N0H2G\\SQLEXPRESS01;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=False ");
            baglan.Open();
            return baglan;
        }
    }
}
