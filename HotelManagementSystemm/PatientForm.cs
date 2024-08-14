using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementSystemm
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=laptop-dto6agc1\sqlexpress;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");


        void populate()
        {
            conn.Open();
            string insertquery = "select * from PatientTbl2";
            SqlDataAdapter da = new SqlDataAdapter(insertquery, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || PatDisease.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                conn.Open();
                string insertquery = "insert into PatientTbl2 values (@PatId,@PatName,@PatAddress,@PatPhone,@PatAge,@PatGender,@PatBlood,@PatDisease)";
                SqlCommand cmd = new SqlCommand(insertquery, conn);
                cmd.Parameters.AddWithValue("@PatId", PatId.Text);
                cmd.Parameters.AddWithValue("@PatName", PatName.Text);
                cmd.Parameters.AddWithValue("@PatAddress", PatAddress.Text);
                cmd.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
                cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                cmd.Parameters.AddWithValue("@PatGender", PatGenderCmb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PatBlood", PatBloodCmb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PatDisease", PatDisease.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient register successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                populate();

            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Enter the Doctor Id");
            else
            {
                conn.Open();
                string query = "Delete from PatientTbl2 where PatId = " + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");

                conn.Close();

                populate();

            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAddress.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            PatDisease.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            // have to add for gender and blood group
            string query = "update PatientTbl2 set PatName = '" + PatName.Text + "',PatAdd = '" + PatAddress.Text + "',PatPhone = '" + PatPhone.Text + "' , PatAge = '" + PatAge.Text + "', PatDisease = '" + PatDisease.Text + "'  where PatId = '" + PatId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Details SUccessfully Updated");

            conn.Close();
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

