using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADProject1
{
    public partial class Home : Form
    {
        private newCus F1;
        private Register F2;
        private Canrent F3;
        private NewCar F4;
        private BackCar F5;
        public Home()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 10;
        }

        private void Blogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "SADman" && txtPass.Text == "Kumamo")
            {
                menuStrip1.Show();
                txtPass.Hide();
                txtUser.Hide();
                Blogin.Hide();
                Bclose.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                pictureBox1.Show();
                Bclose1.Show();
                working.Show();
                registerToolStripMenuItem.Visible = true;
                rentToolStripMenuItem.Visible = true;
                statusToolStripMenuItem.Visible = true;
            }
            else if (txtUser.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Please enter your Username and Password","Error");
            }
            else
            {
                MessageBox.Show("Invalid your Username and Password", "Error");
            }
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            F1 = new newCus();
            F1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F2 = new Register();
            F2.Show();
        }

        private void CarRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F3 = new Canrent();
            F3.Show();
        }

        private void NewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F4 = new NewCar();
            F4.Show();
        }

        private void BackCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F5 = new BackCar();
            F5.Show();
        }
    }
}
