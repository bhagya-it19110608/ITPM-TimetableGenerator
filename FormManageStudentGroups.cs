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
    public partial class FormManageStudentGroups : Form
    {
        public FormManageStudentGroups()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int Stdid;
        String txt1;
        String txt2;
        String txt3;

        private void FormManageStudentGroups_Load(object sender, EventArgs e)
        {
            GenerateStudentGroups();
        }
        private void GenerateStudentGroups()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentGroup_tb", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            gridviewManageStdGroups.DataSource = dt;
        }

        private void gridviewManageStdGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Stdid = Convert.ToInt32(gridviewManageStdGroups.SelectedRows[0].Cells[0].Value);
            txtAYS2.Text = gridviewManageStdGroups.SelectedRows[0].Cells[1].Value.ToString();
            comboP2.Text = gridviewManageStdGroups.SelectedRows[0].Cells[2].Value.ToString();
            ud21.Text = gridviewManageStdGroups.SelectedRows[0].Cells[3].Value.ToString();
            ud22.Text = gridviewManageStdGroups.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Stdid > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentGroup_tb SET academicYearSemester = @academicYearSemester, degreeProgramme = @degreeProgramme, groupNumber = @groupNumber, subGroupNumber = @subGroupNumber WHERE stID = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@academicYearSemester", txtAYS2.Text);
                cmd.Parameters.AddWithValue("@degreeProgramme", comboP2.Text);
                cmd.Parameters.AddWithValue("@groupNumber", ud21.Text);
                cmd.Parameters.AddWithValue("@subGroupNumber", ud22.Text);
                cmd.Parameters.AddWithValue("@id", this.Stdid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student Group is Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateStudentGroups();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Pleace select a row", "select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Stdid > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentGroup_tb WHERE stID = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Stdid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student Group is Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateStudentGroups();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Please select an student to delete", "selet?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Stdid > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentGroup_tb WHERE stID = @id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.Stdid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student Group is Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateStudentGroups();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Please select an student to delete", "selet?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetDetails();
        }
        private void ResetDetails()
        {
            
            txtAYS2.Clear();
            txtGID11.Clear();
            txtGID22.Clear();
            ud21.ResetText();
            ud22.ResetText();

            comboP2.SelectedIndex = -1;
        }

        private void gen1_Click(object sender, EventArgs e)
        {
            txt1 = txtAYS2.Text;
            txt2 = ud21.Text;
            txtGID11.Text = txt1 + "." + txt2;
        }

        private void gen2_Click(object sender, EventArgs e)
        {
            txt1 = txtAYS2.Text;
            txt2 = ud21.Text;
            txt3 = ud22.Text;
            txtGID22.Text = txt1 + "." + txt2 + "." + txt3;
        }
    }
}
