using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class SecretaryPage : Form
    {
        public SecretaryPage()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From SecretaryTbl Where SecretaryCN=@P1 and SecretaryPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MTBCN.Text);
            komut.Parameters.AddWithValue("@p2", TXTPSW.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SecretaryDetail frs = new SecretaryDetail();
                frs.CNNO = MTBCN.Text;
                frs.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Information Try Again");
            }
            bgl.baglanti().Close();
        }
    }
}
