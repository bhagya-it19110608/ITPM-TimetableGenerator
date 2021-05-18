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
    public partial class FormContentStudent : Form
    {
        public FormContentStudent()
        {
            InitializeComponent();
        }
        public int Stdid;
        String txt1;
        String txt2;
        String txt3;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        private Form activeForm = null;

        private void openContentStudent(Form contentStudent)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentStudent;
            contentStudent.TopLevel = false;
            contentStudent.FormBorderStyle = FormBorderStyle.None;
            contentStudent.Dock = DockStyle.Fill;
            panelContentStudent.Controls.Add(contentStudent);
            panelContentStudent.Tag = contentStudent;
            contentStudent.BringToFront();
            contentStudent.Show();
        }
        private void buttonStudentAddSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentStudent(new FormStudentAddSession());
        }

        private void FormContentStudent_Load(object sender, EventArgs e)
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

            //gridviewManageStdGroups.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentGroup_tb VALUES (@academicYearSemester, @degreeProgramme, @groupNumber, @subGroupNumber)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@academicYearSemester", txtAYS1.Text);
                cmd.Parameters.AddWithValue("@degreeProgramme", comboP1.Text);
                cmd.Parameters.AddWithValue("@groupNumber", ud11.Text);
                cmd.Parameters.AddWithValue("@subGroupNumber", ud12.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student Group is successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateStudentGroups();
                ResetDetails();
            }
        }
        private bool IsValid()
        {
            if (txtAYS1.Text == string.Empty)
            {
                MessageBox.Show("Academic Year Semester is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetDetails();
        }
        private void ResetDetails()
        {
            txtAYS1.Clear();
            txtGID1.Clear();
            txtGID2.Clear();
            //txtAYS2.Clear();
            //txtGID11.Clear();
            //txtGID22.Clear();
            ud11.ResetText();
            ud12.ResetText();
            //ud21.ResetText();
            //ud22.ResetText();

            comboP1.SelectedIndex = -1;
            //comboP2.SelectedIndex = -1;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txt1 = txtAYS1.Text;
            txt2 = ud11.Text;
            txt3 = ud12.Text;

            txtGID1.Text = txt1 + "." + txt2;
            txtGID2.Text = txt1 + "." + txt2 + "." + txt3;

        }

        private void buttonAddStudentGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonManageStudentGroup_Click(object sender, EventArgs e)
        {

            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentStudent(new FormManageStudentGroups());
        }
    }
}
