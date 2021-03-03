using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtPatient_Click(object sender, EventArgs e)
        {
            PatientPage fr = new PatientPage();
            fr.Show();
            this.Hide();
        }

        private void BtDoctor_Click(object sender, EventArgs e)
        {
            DoctorPage fr = new DoctorPage();
            fr.Show();
            this.Hide();
        }

        private void BtSecretary_Click(object sender, EventArgs e)
        {
            SecretaryPage fr = new SecretaryPage();
            fr.Show();
            this.Hide();
        }
    }
}
