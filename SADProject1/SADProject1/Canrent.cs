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
    public partial class Canrent : Form
    {
        SqlCommand cmd,cmd1;
        SqlConnection con;
        SqlDataReader mdr;

        public Canrent()
        {
            InitializeComponent();
        }

        private void Canrent_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REALERZ\Desktop\SADProject1\SADProject1\Data.mdf;Integrated Security=True");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string select = "SELECT * FROM CusList Where cusID =" + txtCusID.Text;
            cmd = new SqlCommand(select, con);
            mdr = cmd.ExecuteReader();

            if(mdr.Read())
            {
                MessageBox.Show("ID is true");
                label9.Text = mdr["Name"].ToString();
            }
            else
            {
                MessageBox.Show("Cheack your Customer ID again!!");
            }
            con.Close();
        }

        private string T;
        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string select = "SELECT * FROM CarList Where CarID =" + txtCarID.Text;
            cmd = new SqlCommand(select, con);
            mdr = cmd.ExecuteReader();
            
            if (mdr.Read())
            {
                MessageBox.Show("ID is true, Car is " + (mdr["status"].ToString()));
                T = (mdr["Type"].ToString());
                Cartype.Text = T;
                txtBrand.Text = mdr["Brand"].ToString();
                txtStatus.Text = mdr["status"].ToString();
                if(Cartype.Text == "A")
                {
                    txtPrice.Text = 1200.ToString();
                }
                if (Cartype.Text == "B")
                {
                    txtPrice.Text = 2000.ToString();
                }
                if (Cartype.Text == "C")
                {
                    txtPrice.Text = 4000.ToString();
                }
                if (Cartype.Text == "D")
                {
                    txtPrice.Text = 12000.ToString();
                }
            }
            else
            {
                MessageBox.Show("Cheack your Customer ID again!!");
            }
            con.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string select = "SELECT * FROM EmpList Where EmpID =" + txtEmpID.Text;
            cmd = new SqlCommand(select, con);
            mdr = cmd.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show("ID is true");
                label12.Text = mdr["Name"].ToString();
            }
            else
            {
                MessageBox.Show("Cheack your Customer ID again!!");
            }
            con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var D1 = (DTN.Value - DTS.Value).TotalDays;

            int P = Convert.ToInt32(txtPrice.Text);
            txtTotal.Text = (D1 * P).ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text == "")
            {
                MessageBox.Show("Please enter Customer ID", "!!Error");
                this.txtCusID.Focus();
            }
            else if (txtEmpID.Text == "")
            {
                MessageBox.Show("Please enter Employee ID", "!!Error");
                this.txtEmpID.Focus();
            }
            else if (txtCarID.Text == "")
            {
                MessageBox.Show("Please enter Car ID", "!!Error");
                this.txtCarID.Focus();
            }
            else if (txtBrand.Text == "")
            {
                MessageBox.Show("Please enter Brand", "!!Error");
                this.txtBrand.Focus();
            }
            else if (Cartype.Text == "")
            {
                MessageBox.Show("Please enter Cartype", "!!Error");
                this.Cartype.Focus();
            }
            else if (txtStatus.Text == "")
            {
                MessageBox.Show("Please enter Status", "!!Error");
                this.txtStatus.Focus();
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter Price", "!!Error");
                this.txtPrice.Focus();
            }
            else if (txtTotal.Text == "")
            {
                MessageBox.Show("Please enter Total", "!!Error");
                this.txtTotal.Focus();
            }
            else if (txtStatus.Text == "Not Available")
            {
                MessageBox.Show("Car is Not Available", "!!Error");
                this.txtStatus.Focus();
            }

            else
            {
                con.Open();

                string sql2 = @"UPDATE CarList SET status = @S WHERE CarID =" + txtCarID.Text;
                cmd1 = new SqlCommand(sql2, con);
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("S", "Not Available");//ตรงนี้กำหนดลงไปแล้วครับแต่เหมือนจะเปลี่ยนค่าไม่ได้
                
                cmd = new SqlCommand("INSERT INTO RentList(cusID,CarID,EmpID,DateS,DateN,Price) VALUES (@cusID,@CarID,@EmpID,@DateS,@DateN,@Price)", con);
                cmd.Parameters.Add("@cusID", txtCusID.Text);
                cmd.Parameters.Add("@CarID", txtCarID.Text);
                cmd.Parameters.Add("@EmpID", txtEmpID.Text);
                cmd.Parameters.Add("@DateS", DTS.Text);
                cmd.Parameters.Add("@DateN", DTN.Text);
                cmd.Parameters.Add("@Price", txtTotal.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                con.Close();
                this.Close();
            }
        }

        private void TxtCusID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            txtCusID.Text = "";
            txtEmpID.Text = "";
            txtCarID.Text = "";
            txtBrand.Text = "";
            Cartype.Text = "";
            txtStatus.Text = "";
            txtPrice.Text = "";
            txtTotal.Text = "";
            label9.Text = "-";
            label12.Text = "-";
        }
    }
}
