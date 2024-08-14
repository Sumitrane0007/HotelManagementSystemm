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
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace HotelManagementSystemm
{
    public partial class DiagnosisForm : Form
    {



        public DiagnosisForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=laptop-dto6agc1\sqlexpress;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");

        void populatecombo()
        {
            string sql = "select * from PatientTbl2";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatCmbId.ValueMember = "PatId";
                PatCmbId.DataSource = dt;
                conn.Close();

            }
            catch
            {

            }
        }

        string patname;
        void fetchpatientname()
        {
            conn.Open();
            string mysql = "select * from PatientTbl2 where PatId = " + PatCmbId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(@mysql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatName.Text = patname;
            }
            conn.Close();

        }

        void populate()
        {
            conn.Open();
            string insertquery = "select * from DiagnosisTbl2";
            SqlDataAdapter da = new SqlDataAdapter(insertquery, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
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
            if (DiagId.Text == "" || Medicines.Text == "" || Diagnosis.Text == "" || PatName.Text == "" || Medicines.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                conn.Open();
                string insertquery = "insert into DiagnosisTbl2 values (@DiagId,@PatId,@PatName,@Symptoms,@Diagnosis,@Medicines)";
                SqlCommand cmd = new SqlCommand(insertquery, conn);
                cmd.Parameters.AddWithValue("@DiagId", DiagId.Text);
                cmd.Parameters.AddWithValue("@PatId", PatCmbId.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PatName", PatName.Text);
                cmd.Parameters.AddWithValue("@Symptoms", Symptoms.Text);
                cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis.Text);
                cmd.Parameters.AddWithValue("@Medicines", Medicines.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis added successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                populate();

            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void PatCmbId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
                MessageBox.Show("Enter the Diagnosis Id");
            else
            {
                conn.Open();
                string query = "Delete from DiagnosisTbl2 where DiagId = " + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis record Successfully Deleted");

                conn.Close();

                populate();

            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatCmbId.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatName.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptoms.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosis.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicines.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();

            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString(); ;
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "update DiagnosisTbl2 set PatId = '" + PatCmbId.SelectedValue.ToString() + "',PatName = '" + PatName.Text + "',Symptoms = '" + Symptoms.Text + "',Diagnosis = '" + Diagnosis.Text + "', Medicines = '" + Medicines.Text + "'  where DiagId = '" + DiagId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Successfully Updated");

            conn.Close();
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label3.Text + "", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(PatientNamelbl.Text + "\n" + Diagnosislbl.Text + "\n" + Symptomslbl.Text + "\n" + Medicineslbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130, 150));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
