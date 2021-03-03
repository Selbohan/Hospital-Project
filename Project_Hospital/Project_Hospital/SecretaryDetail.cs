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
    public partial class SecretaryDetail : Form
    {
        public SecretaryDetail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string CNNO;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void SecretaryDetail_Load(object sender, EventArgs e)
        {
            LblCN.Text = CNNO;

            //NameSurname
            SqlCommand komut1 = new SqlCommand("Select * From SecretaryTbl Where SecretaryCN=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblCN.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblNSN.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();


            //Branch TO DataGrid
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BranchName From BranchTbl", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doctor TO DataGrid
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName+' '+DoctorSurName) as 'Doctors',DoctorBranch as Branchs From DoctorTbl", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branch To ComboBox
            SqlCommand komut2 = new SqlCommand("Select BranchName From BranchTbl", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CBBranch.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            SqlCommand komutKayit = new SqlCommand("insert into RendezvousTbl (Date,Time,Branch,Doctor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutKayit.Parameters.AddWithValue("@r1", MTBDate.Text);
            komutKayit.Parameters.AddWithValue("@r2", MTBTime.Text);
            komutKayit.Parameters.AddWithValue("@r3", CBBranch.Text);
            komutKayit.Parameters.AddWithValue("@r4", CBDoctor.Text);
            komutKayit.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Rendezvous Added");
        }

        private void CBBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBDoctor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoctorName,DoctorSurname From DoctorTbl Where DoctorBranch=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CBBranch.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CBDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("insert into MessagesTbl (Message) values (@m1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@m1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Announcement Created");
        }

        private void BTNDocPanel_Click(object sender, EventArgs e)
        {
            DoctorPanel drp = new DoctorPanel();
            drp.Show();


        }

        private void BTNBranchPanel_Click(object sender, EventArgs e)
        {
            DoctorBranch br = new DoctorBranch();
            br.Show();
        }

        private void BtnRendezvousList_Click(object sender, EventArgs e)
        {
            RendezvousPanel Rp = new RendezvousPanel();
            Rp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Messages mp = new Messages();
            mp.Show();
        }
    }
}
