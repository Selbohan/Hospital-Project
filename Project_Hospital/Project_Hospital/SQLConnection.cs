using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Project_Hospital
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-5RV7IQ7\\SQLEXPRESS;Initial Catalog=ProjectHospital;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
