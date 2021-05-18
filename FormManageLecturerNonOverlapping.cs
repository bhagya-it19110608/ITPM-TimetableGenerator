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
    public partial class FormManageLecturerNonOverlapping : Form
    {
        public FormManageLecturerNonOverlapping()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        int id, id2;

        private void FormManageLecturerNonOverlapping_Load(object sender, EventArgs e)
        {
            GenerateRecords();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            txtSearch2.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            comboBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void ResetDetails()
        {
            txtSearch2.Clear();
            
            comboBox3.SelectedIndex = -1;
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE LecturerNonOverlapping_tb SET Lecturer_1 = @Lecturer1 WHERE ID = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturer_1", comboBox3.Text);
                cmd.Parameters.AddWithValue("@id", this.id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateRecords();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Pleace select a row", "select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete21_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM LecturerNonOverlapping_tb WHERE ID = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateRecords();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Please select an student to delete", "select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete22_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM LecturerNonOverlapping_tb WHERE ID = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateRecords();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Please select an student to delete", "select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LecturerNonOverlapping_tb", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView2.DataSource = dt;
        }
    }
}
