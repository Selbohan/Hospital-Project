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
    public partial class DoctorInfoUpdate : Form
    {
        public DoctorInfoUpdate()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl =new sqlbaglantisi();
        public string Cn;

        private void DoctorInfoUpdate_Load(object sender, EventArgs e)
        {
            MTBCN.Text = Cn;

            SqlCommand komut = new SqlCommand("Select * From DoctorTbl Where DoctorCN=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MTBCN.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxTName.Text = dr[1].ToString();
                TxTSN.Text = dr[2].ToString();
                CmbBranch.Text = dr[3].ToString();
                TxTPasW.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update DoctorTbl set DoctorName=@p1,DoctorSurname=@p2,DoctorBranch=@p3,DoctorPassword=@p4 where DoctorCN=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxTName.Text);
            komut.Parameters.AddWithValue("@p2", TxTSN);
            komut.Parameters.AddWithValue("@p3", CmbBranch.Text);
            komut.Parameters.AddWithValue("@p4", TxTPasW.Text);
            komut.Parameters.AddWithValue("@p5", MTBCN.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Info Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
