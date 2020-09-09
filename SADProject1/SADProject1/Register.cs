using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;

namespace SADProject1
{
    public partial class Register : Form
    {
        List<string> cultureList = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            foreach(CultureInfo culture in cultures)
            {
                region = new RegionInfo(culture.LCID);
                if(!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                    ComNa.Items.Add(region.EnglishName + " (" + region.ISOCurrencySymbol + ")");
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Rmale.Checked){
                label10.Text = Rmale.Text;
            }else if (Rfemale.Checked){
                label10.Text = Rfemale.Text;
            }

            if (txtID.Text == ""){
                MessageBox.Show("Please enter your Citizen ID", "!!Error");
                this.txtID.Focus();
            }
            else if (txtID.Text.Length != 13)
            {
                MessageBox.Show("Please check length", "!!Error");
                this.txtID.Focus();
            }
            else if(txtName.Text == "")
            {
                MessageBox.Show("Please enter your Name", "!!Error");
                this.txtName.Focus();
            }
            else if (txtTel.Text == ""){
                MessageBox.Show("Please enter your Tel.", "Error");
                this.txtTel.Focus();
            }
            else if (txtTel.Text.Length != 10)
            {
                MessageBox.Show("Please check length", "!!Error");
                this.txtTel.Focus();
            }
            else if (txtEmail.Text == ""){
                MessageBox.Show("Please enter your E-mail", "!!Error");
                this.txtEmail.Focus();
            }
            else if (ComNa.Text == " -Choose your Nationality-")
            {
                MessageBox.Show("Please enter your Nationality", "!!Error");
                this.ComNa.Focus();
            }
            else if (txtAddress.Text == ""){
                MessageBox.Show("Please enter your Address", "!!Error");
                this.txtAddress.Focus();
            }
            else if (txtPro.Text == "")
            {
                MessageBox.Show("Please enter your Province", "!!Error");
                this.txtPro.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Please enter your City", "!!Error");
                this.txtCity.Focus();
            }
            else if (txtPos.Text == "")
            {
                MessageBox.Show("Please enter your Postal", "!!Error");
                this.txtPro.Focus();
            }
            

            else
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REALERZ\Desktop\SADProject1\SADProject1\Data.mdf;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("INSERT INTO EmpList(EmpID,Name,BirthDay,Tel,Email,Gender,Nationality,Address,Province,City,Postal) VALUES (@EmpID,@Name,@BirthDay,@Tel,@Email,@Gender,@Nationality,@Address,@Province,@City,@Postal)", con);
                cmd.Parameters.Add("@EmpID", txtID.Text);
                cmd.Parameters.Add("@Name", txtName.Text);
                cmd.Parameters.Add("@BirthDay", DTbirth.Text);
                cmd.Parameters.Add("@Tel", txtTel.Text);
                cmd.Parameters.Add("@Email", txtEmail.Text);
                cmd.Parameters.Add("@Gender", label10.Text);
                cmd.Parameters.Add("@Nationality", ComNa.SelectedItem.ToString());
                cmd.Parameters.Add("@Address", txtAddress.Text);
                cmd.Parameters.Add("@Province", txtPro.Text);
                cmd.Parameters.Add("@City", txtCity.Text);
                cmd.Parameters.Add("@Postal", txtPos.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            ComNa.Text = "-Choose your Nationality-";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPos.Text = "";
            txtPro.Text = "";
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex email = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"+ @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"+ @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            if (!email.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please check your E-mail","!!Error");
                this.txtEmail.Focus();
            }
        }

        private void TxtPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
