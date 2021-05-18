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
    public partial class FormLecturerUnavailable : Form
    {
        public FormLecturerUnavailable()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private void buttonLecturerTimeSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO UnavailableLecturer VALUES (@LecturerName, @Group, @SubGroup, @SessionID, @Time)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@LecturerName", comboBoxLecturerSelectLecturer.Text);
                cmd.Parameters.AddWithValue("@Group", comboBoxLecturerSelectGroup.Text );
                cmd.Parameters.AddWithValue("@SubGroup", comboBoxLecturerSelectSubGroup.Text);
                cmd.Parameters.AddWithValue("@SessionID", comboBoxLecturerSelectSessionID.Text);
                cmd.Parameters.AddWithValue("@Time", comboBoxLecturerSelectTime.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFormControls();

            }
        }

        private bool IsValid()
        {
            if (comboBoxLecturerSelectLecturer.Text == string.Empty)
            {
                MessageBox.Show("Lecturer Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLecturerSelectGroup.Text == string.Empty)
            {
                MessageBox.Show("Student Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLecturerSelectSubGroup.Text == String.Empty)
            {
                MessageBox.Show("Sub Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLecturerSelectSessionID.Text == String.Empty)
            {
                MessageBox.Show("Session ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLecturerSelectTime.Text == String.Empty)
            {
                MessageBox.Show("Time is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }

        private void buttonLecturerTimeClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }

        private void ClearFormControls()
        {
            
            comboBoxLecturerSelectLecturer.Focus();
        }
    }
    
}
