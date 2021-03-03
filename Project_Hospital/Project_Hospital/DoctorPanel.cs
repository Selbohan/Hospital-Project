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
    public partial class DoctorPanel : Form
    {
        public DoctorPanel()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From DoctorTbl", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branch To ComboBox
            SqlCommand komut2 = new SqlCommand("Select BranchName From BranchTbl", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CBBranch.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into DoctorTbl(DoctorName,DoctorSurName,DoctorBranch,DoctorCN,DoctorPassword) values(@d1,@d2,@d3,@d4,@d5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TXNAME.Text);
            komut.Parameters.AddWithValue("@d2", TXSURNAME.Text);
            komut.Parameters.AddWithValue("@d3", CBBranch.Text);
            komut.Parameters.AddWithValue("@d4", MTBCN.Text);
            komut.Parameters.AddWithValue("@d5", TXPassword.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor Added","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TXNAME.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TXSURNAME.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CBBranch.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MTBCN.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TXPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtRemv_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From DoctorTbl where DoctorCN=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MTBCN.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update DoctorTbl set DoctorName=@d1,DoctorSurName=@d2,DoctorBranch=@d3,DoctorPassword=@d5 where DoctorCN=@d6", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TXNAME.Text);
            komut.Parameters.AddWithValue("@d2", TXSURNAME.Text);
            komut.Parameters.AddWithValue("@d3", CBBranch.Text);
            komut.Parameters.AddWithValue("@d4", MTBCN.Text);
            komut.Parameters.AddWithValue("@d5", TXPassword.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
