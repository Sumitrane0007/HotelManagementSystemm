using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementSystemm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=laptop-dto6agc1\sqlexpress;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || DocPass.Text == "")
                MessageBox.Show("Enter a Username and Password");
            else
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTbl2 where DocName = '" + DocName.Text + "' and DocPass = '" + DocPass.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }


                conn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DocName.Text = "";
            DocPass.Text = "";
        }
    }
}
