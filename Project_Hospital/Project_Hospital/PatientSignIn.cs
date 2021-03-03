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
    public partial class PatientSignIn : Form
    {
        public PatientSignIn()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtSignIn_Click(object sender, EventArgs e)
        {
            SqlCommand Komut = new SqlCommand("insert into PatientTbl (PatientCN,PatientName,PatientSurName,PatientPhone,PatientSex,PatientPassword) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            Komut.Parameters.AddWithValue("@p1", MTBCN.Text);
            Komut.Parameters.AddWithValue("@p2", TxTName.Text);
            Komut.Parameters.AddWithValue("@p3", TxTSN.Text);
            Komut.Parameters.AddWithValue("@p4", PhoneNumber.Text);
            Komut.Parameters.AddWithValue("@p5", GENDER.Text);
            Komut.Parameters.AddWithValue("@p6", TxTPasW.Text);
            Komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Succes !","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
