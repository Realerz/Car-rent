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

namespace SADProject1
{
    public partial class BackCar : Form
    {
        SqlCommand cmd, cmd1;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet dataSt;
        SqlDataReader mdr;

        public BackCar()
        {
            InitializeComponent();
        }

        private void BackCar_Load(object sender, EventArgs e)
        {
            ComS.Items.Add("Available");
            ComS.Items.Add("Not Available");
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REALERZ\Desktop\SADProject1\SADProject1\Data.mdf;Integrated Security=True");
            con.Open();
            selectData();
        }

        private void selectData()
        {
            string sql = "SELECT * FROM CarList ";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            dataSt = new DataSet();
            da.Fill(dataSt, "CarList");

            comboBox1.Items.Clear();
            for (int i = 0; i < dataSt.Tables["CarList"].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataSt.Tables["CarList"].Rows[i]["CarID"].ToString());
            }
        }

        private void EditData()
        {

            string sql2 = "SELECT * FROM CarList WHERE CarID =" + comboBox1.Text;

            cmd = new SqlCommand(sql2, con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue(comboBox1.Text, comboBox1.SelectedItem.ToString());

            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dataSt = new DataSet();
            adapter.Fill(dataSt, "CarList");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql2 = @"UPDATE CarList SET status = @S WHERE CarID =" + comboBox1.Text;
            string sql3 = @"UPDATE RentList SET Price = @P WHERE CarID =" + comboBox1.Text;

            cmd = new SqlCommand(sql2, con);
            cmd1 = new SqlCommand(sql3, con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("S", ComS.Text);
            cmd.ExecuteNonQuery();

            cmd1.Parameters.Clear();
            cmd1.Parameters.AddWithValue("P", txtprict.Text);
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Data Update");
            this.Close();
            selectData();
            con.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = "SELECT * FROM CarList Where CarID =" + comboBox1.Text;
            cmd = new SqlCommand(select, con);
            mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    MessageBox.Show("ID is true");
                    txtB.Text = mdr["Brand"].ToString();
                    txtC.Text = mdr["Color"].ToString();
                    txtT.Text = mdr["Type"].ToString();
                    ComS.Text = mdr["status"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid, Cheack your Car ID again!!", "Error");
                }
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "          -Choose Car-";
            txtB.Text = "";
            txtT.Text = "";
            txtC.Text = "";
            ComS.Text = "         -Choose Status-";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            txtprict.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            int n = 0;
            string select = "SELECT * FROM RentList Where CarID =" + comboBox1.Text;
            cmd = new SqlCommand(select, con);
            mdr = cmd.ExecuteReader();

            if (mdr.Read())
            {   
                txtprict.Text = mdr["Price"].ToString();
                n = Convert.ToInt32(txtprict.Text);
                if (checkBox1.Checked)
                {
                    n = n + 5000;
                }
                if (checkBox2.Checked)
                {
                    n = n + 1000;
                }
                if (checkBox3.Checked)
                {
                    n = n + 300000;
                }
                txtprict.Text = n.ToString();
            }
            con.Close();
        }
    }
}
