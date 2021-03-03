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
    public partial class PatientPage : Form
    {
        public PatientPage()
        {
            InitializeComponent();
        }
       
        sqlbaglantisi bgl = new sqlbaglantisi();
      
        private void LnKSıgnIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientSignIn fr = new PatientSignIn();
            fr.Show();

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand Komut = new SqlCommand("Select * From PatientTbl Where PatientCN=@p1 and PatientPassword=@p2", bgl.baglanti());
            Komut.Parameters.AddWithValue("@p1", MTBCN.Text);
            Komut.Parameters.AddWithValue("@p2", PasswordTxt.Text);
            SqlDataReader dr = Komut.ExecuteReader();
            if (dr.Read())
            {
                PatientDetails fr = new PatientDetails();
                fr.CN = MTBCN.Text;
                fr.Show();
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
