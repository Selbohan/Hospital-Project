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
    public partial class DoctorBranch : Form
    {
        public DoctorBranch()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void DoctorBranch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From BranchTbl",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BranchTbl (BranchName) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TXID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TXID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TXNAME.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtRemv_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From BranchTbl Where BranchID=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TXID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update BranchTbl set BranchName=@p1 Where BranchID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TXID.Text);
            komut.Parameters.AddWithValue("@p2", TXNAME);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
