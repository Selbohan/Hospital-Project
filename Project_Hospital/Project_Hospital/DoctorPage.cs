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

namespace Project_Hospital
{
    public partial class DoctorPage : Form
    {
        public DoctorPage()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From DoctorTbl Where DoctorCN=@p1 and DoctorPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MTBCN.Text);
            komut.Parameters.AddWithValue("@p2", TxPsw.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                DoctorDetail fr = new DoctorDetail();
                fr.Cn = MTBCN.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Information");
            }
            bgl.baglanti().Close();
        }
    }
}
