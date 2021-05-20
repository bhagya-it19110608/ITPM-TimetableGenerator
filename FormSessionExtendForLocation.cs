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
    public partial class FormSessionExtendForLocation : Form
    {
        public FormSessionExtendForLocation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private Form activeForm = null;

        private void openContentLocationSessionContent(Form contentLocationSessionContent)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentLocationSessionContent;
            contentLocationSessionContent.TopLevel = false;
            contentLocationSessionContent.FormBorderStyle = FormBorderStyle.None;
            contentLocationSessionContent.Dock = DockStyle.Fill;
            panelContentLocationSessionContent.Controls.Add(contentLocationSessionContent);
            panelContentLocationSessionContent.Tag = contentLocationSessionContent;
            contentLocationSessionContent.BringToFront();
            contentLocationSessionContent.Show();
        }
        private void buttonLocationSessionNotAvailableTimes_Click(object sender, EventArgs e)
        {
            if (((Control)sender).ForeColor != Color.FromArgb(168, 168, 167))
                ((Control)sender).ForeColor = Color.FromArgb(168, 168, 167);
            else
                ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0);
            openContentLocationSessionContent(new FormLocationUnavailable());
        }

        private void buttonLocationSessionConsecutive_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO LocationConsecutive VALUES (@LecturerName, @SubjectName, @SessionID, @Room, @Tag)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LecturerName", comboBoxLecturer.Text);
                cmd.Parameters.AddWithValue("@SubjectName", comboBoxSubject.Text);
                cmd.Parameters.AddWithValue("@SessionID", comboBoxSession.Text);
                cmd.Parameters.AddWithValue("@Room", comboBoxRoom.Text);
                cmd.Parameters.AddWithValue("@Tag", comboBoxTag.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFormControls();

            }
        }
        private bool IsValid()
        {
            if (comboBoxLecturer.Text == string.Empty)
            {
                MessageBox.Show("Lecturer Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxSubject.Text == string.Empty)
            {
                MessageBox.Show("Subject Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxSession.Text == String.Empty)
            {
                MessageBox.Show("Session is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxRoom.Text == String.Empty)
            {
                MessageBox.Show("Room is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxTag.Text == String.Empty)
            {
                MessageBox.Show("Tag is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }
        private void ClearFormControls()
        {

            comboBoxLecturer.Focus();
        }

    }
}
