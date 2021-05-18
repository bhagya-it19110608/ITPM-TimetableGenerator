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

namespace Member3
{
    public partial class FormSessionExtend : Form
    {
        public FormSessionExtend()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        int id, id2;

        private Form activeForm = null;

        private void openContentSessionContent(Form contentSessionContent)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentSessionContent;
            contentSessionContent.TopLevel = false;
            contentSessionContent.FormBorderStyle = FormBorderStyle.None;
            contentSessionContent.Dock = DockStyle.Fill;
            panelContentSessionContent.Controls.Add(contentSessionContent);
            panelContentSessionContent.Tag = contentSessionContent;
            contentSessionContent.BringToFront();
            contentSessionContent.Show();
        }

        private void buttonSessionNotAvailableTimes_Click(object sender, EventArgs e)
        {
            if (((Control)sender).ForeColor != Color.FromArgb(168, 168, 167))
                ((Control)sender).ForeColor = Color.FromArgb(168, 168, 167);
            else
                ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0);

           openContentSessionContent(new FormManageLecturerUnavailableTime());
        }

        private void FormSessionExtend_Load(object sender, EventArgs e)
        {
            GenerateConsecutive();
        }
        private void GenerateConsecutive()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LlecturerConsecutive_tb", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {

        }

        private void FormSessionExtend_Load_1(object sender, EventArgs e)
        {
            GenerateRecords2();
        }
        private void GenerateRecords2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LlecturerConsecutive_tb", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id2 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtsearch1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void ResetDetails()
        {
            txtsearch1.Clear();

            comboBox1.SelectedIndex = -1;
            
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            if (id2 > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE LlecturerConsecutive_tb SET Lecturer = @Lecturer WHERE ID_c = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturer", comboBox1.Text);
                cmd.Parameters.AddWithValue("@id", this.id2);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateRecords2();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Pleace select a row", "select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete12_Click(object sender, EventArgs e)
        {
            if (id2 > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM LlecturerConsecutive_tb WHERE ID_c = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.id2);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateRecords2();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Please select the row to delete", "selet?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete11_Click(object sender, EventArgs e)
        {
            if (id2 > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM LlecturerConsecutive_tb WHERE ID_c = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.id2);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateRecords2();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Please select the row to delete", "selet?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void buttonSessionNonOverlapping_Click(object sender, EventArgs e)
        {
            if (((Control)sender).ForeColor != Color.FromArgb(168, 168, 167))
                ((Control)sender).ForeColor = Color.FromArgb(168, 168, 167);
            else
                ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0);

            openContentSessionContent(new FormManageLecturerNonOverlapping());
        }
    }
}
