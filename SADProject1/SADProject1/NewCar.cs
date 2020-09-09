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
using System.Data.Sql;

namespace SADProject1
{
    public partial class NewCar : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public NewCar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REALERZ\Desktop\SADProject1\SADProject1\Data.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO CarList(CarID,Brand,Color,Type,status) VALUES (@CarID,@Brand,@Color,@Type,@status)", con);
            cmd.Parameters.Add("@CarID", txtCarID.Text);
            cmd.Parameters.Add("@Brand", ComB.Text);
            cmd.Parameters.Add("@Color", ComC.Text);
            cmd.Parameters.Add("@Type", ComT.Text);
            cmd.Parameters.Add("@status", ComS.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            this.Close();
        }

        private void NewCar_Load(object sender, EventArgs e)
        {
            ComB.Items.Add("Toyota");
            ComB.Items.Add("Honda");
            ComB.Items.Add("BMW");
            ComB.Items.Add("Benz");
            ComC.Items.Add("white");
            ComC.Items.Add("Black");
            ComC.Items.Add("Red");
            ComC.Items.Add("Blue");
            ComT.Items.Add("A");
            ComT.Items.Add("B");
            ComT.Items.Add("C");
            ComT.Items.Add("D");
            ComS.Items.Add("Available");
            ComS.Items.Add("Not Available");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtCarID.Text = "";
            ComB.Text = "         -Choose Brand-";
            ComC.Text = "          -Choose Color-";
            ComT.Text = "          -Choose Type-";
            ComS.Text = "         -Choose Status-";
        }
    }
}
