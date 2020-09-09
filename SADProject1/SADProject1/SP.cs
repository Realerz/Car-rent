using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADProject1
{
    public partial class SP : Form
    {
        public SP()
        {
            InitializeComponent();
        }

        private void SP_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(20);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
            Home H1 = new Home();
            H1.Show();
            timer1.Stop();
            this.Hide();
        }
    }
}
