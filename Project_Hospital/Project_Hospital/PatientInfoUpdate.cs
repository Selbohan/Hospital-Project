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
    public partial class PatientInfoUpdate : Form
    {
        public PatientInfoUpdate()
        {
            InitializeComponent();
        }

        public string CNo;
        
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void PatientInfoUpdate_Load(object sender, EventArgs e)
        {
            MTBCN.Text = CNo;
            SqlCommand komut = new SqlCommand("Select * From PatientTbl Where PatientCN=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MTBCN.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxTName.Text = dr[2].ToString();
                TxTSN.Text = dr[3].ToString();
                PhoneNumber.Text = dr[4].ToString();
                GENDER.Text = dr[5].ToString();
                TxTPasW.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update PatientTbl Set PatientName=@p1,PatientSurName=@p2,PatientPhone=@p3,PatientSex=@p4,PatientPassword=@p5 Where PatientCN=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxTName.Text);
            komut2.Parameters.AddWithValue("@p2", TxTSN.Text);
            komut2.Parameters.AddWithValue("@p3", PhoneNumber.Text);
            komut2.Parameters.AddWithValue("@p4", GENDER.Text);
            komut2.Parameters.AddWithValue("@p5", TxTPasW.Text);
            komut2.Parameters.AddWithValue("@p6", MTBCN.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("INFORMATION UPDATED","Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
