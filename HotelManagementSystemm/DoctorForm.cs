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

namespace HotelManagementSystemm
{
    public partial class DoctorForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=laptop-dto6agc1\sqlexpress;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");
        public DoctorForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            conn.Open();
            string insertquery = "select * from DoctorTbl2";
            SqlDataAdapter da = new SqlDataAdapter(insertquery, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                conn.Open();

                string insertQuery = "INSERT INTO DoctorTbl2 VALUES (@DocId,@DocName,@DocExp,@DocPass)";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);

                cmd.Parameters.AddWithValue("@DocId", DocId.Text);
                cmd.Parameters.AddWithValue("@DocName", DocName.Text);
                cmd.Parameters.AddWithValue("@DocExp", DocExp.Text);
                cmd.Parameters.AddWithValue("@DocPass", DocPass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("register successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                conn.Close();

                populate();

            }

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
                MessageBox.Show("Enter the Doctor Id");
            else
            {
                conn.Open();
                string query = "Delete from DoctorTbl2 where DocId = " + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");

                conn.Close();

                populate();

            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "update DoctorTbl2 set DocName = '" + DocName.Text + "',DocExp = '" + DocExp.Text + "',DocPass = '" + DocPass.Text + "' where DocId = '" + DocId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Details SUccessfully Updated");

            conn.Close();
            populate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            string query = "update DoctorTbl2 set DocName = '" + DocName.Text + "',DocExp = '" + DocExp.Text + "',DocPass = '" + DocPass.Text + "' where DocId = '" + DocId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Details SUccessfully Updated");

            conn.Close();
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
