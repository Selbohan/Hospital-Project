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
    public partial class PatientDetails : Form
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        public string CN;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void label2_Click(object sender ,EventArgs e)
        {

        }

        private void PatientDetails_Load_1(object sender, EventArgs e)
        {
            LblCN.Text = CN;
            //Name+SurnamePart
            SqlCommand komut = new SqlCommand("Select PatientName,PatientSurName From PatientTbl Where PatientCN=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblCN.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblNSN.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();
            //Rendezvous Part
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*From RendezvousTbl Where PatientCN="+CN,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //Branch Part
            SqlCommand komut2 = new SqlCommand("Select BranchName From BranchTbl", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoc.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoctorName,DoctorSurname From DoctorTbl Where DoctorBranch=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBranch.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoc.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From RendezvousTbl Where Branch='" +CmbBranch.Text+"'"+"and Doctor='"+CmbDoc.Text+"'and Status=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientInfoUpdate PIU = new PatientInfoUpdate();
            PIU.CNo = LblCN.Text;
            PIU.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BTCnf_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update RendezvousTbl set Status=1,PatientCn=@p1,Info=@p2 where RendezvousID=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblCN.Text);
            komut.Parameters.AddWithValue("@p2", RTBInfo.Text);
            komut.Parameters.AddWithValue("@p3", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Rendezvous Added", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
