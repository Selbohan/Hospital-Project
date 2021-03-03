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
    public partial class DoctorDetail : Form
    {
        public DoctorDetail()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
       
        public string Cn;
        private void DoctorDetail_Load(object sender, EventArgs e)
        {
            LblCN.Text = Cn;

            //Doctor Name To LBL
            SqlCommand komut = new SqlCommand("Select DoctorName,DoctorSurname From DoctorTbl Where DoctorCN=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblCN.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                LblNSN.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Rendezvous
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From RendezvousTbl Where Doctor='"+LblNSN.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtInfoUpdate_Click(object sender, EventArgs e)
        {
            DoctorInfoUpdate dıu = new DoctorInfoUpdate();
            dıu.Cn = LblCN.Text;
            dıu.Show();
        }

        private void BtMessages_Click(object sender, EventArgs e)
        {
            Messages fr = new Messages();
            fr.Show();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RCBDetail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
