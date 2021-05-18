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
    public partial class FormAddNotAvailableTimeOfLecturer : Form
    {
        public FormAddNotAvailableTimeOfLecturer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");


        private Form activeForm = null;

        private void openContentLecturerContent(Form contentLecturerContent)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentLecturerContent;
            contentLecturerContent.TopLevel = false;
            contentLecturerContent.FormBorderStyle = FormBorderStyle.None;
            contentLecturerContent.Dock = DockStyle.Fill;
            panelContentLecturerContent.Controls.Add(contentLecturerContent);
            panelContentLecturerContent.Tag = contentLecturerContent;
            contentLecturerContent.BringToFront();
            contentLecturerContent.Show();
        }

        private void buttonLecturerNotAvailableTimes_Click(object sender, EventArgs e)
        {
            if (((Control)sender).ForeColor != Color.FromArgb(168, 168, 167))
                ((Control)sender).ForeColor = Color.FromArgb(168, 168, 167);
            else
                ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0);

            openContentLecturerContent(new FormLecturerUnavailable());
        }

        private void FormAddNotAvailableTimeOfLecturer_Load(object sender, EventArgs e)
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
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LlecturerConsecutive_tb VALUES (@Lecturer, @Tag, @Subject)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturer", comboLecCon.Text);
                cmd.Parameters.AddWithValue("@Tag", comboTagCon.Text);
                cmd.Parameters.AddWithValue("@Subject", comboSubjectCon.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New record is successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateConsecutive();
                ResetDetails();
            }
        }
        private bool IsValid()
        {
            if (comboSubjectCon.Text == string.Empty)
            {
                MessageBox.Show("Subject is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboTagCon.Text == string.Empty)
            {
                MessageBox.Show("Tag is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboLecCon.Text == string.Empty)
            {
                MessageBox.Show("Lecturer is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void ResetDetails()
        {
            comboSubjectCon.SelectedIndex = -1;
            comboTagCon.SelectedIndex = -1;
            comboLecCon.SelectedIndex = -1;


        }

        private void buttonLecturerNonOverlapping_Click(object sender, EventArgs e)
        {
            if (((Control)sender).ForeColor != Color.FromArgb(168, 168, 167))
                ((Control)sender).ForeColor = Color.FromArgb(168, 168, 167);
            else
                ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0);

            openContentLecturerContent(new FormLecturerNonOverlapping());
        }
    }
}
