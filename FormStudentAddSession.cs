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
    public partial class FormStudentAddSession : Form
    {
        public FormStudentAddSession()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private void buttonStudentTimeSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO UnavailableStudent VALUES (@StudentGroup, @StudentSubGroup, @StudentSessionID, @StudentTime)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@StudentGroup", comboBoxStudentSelectGroup.Text);
                cmd.Parameters.AddWithValue("@StudentSubGroup", comboBoxStudentSelectSubGroup.Text);
                cmd.Parameters.AddWithValue("@StudentSessionID", comboBoxStudentSelectSessionID.Text);
                cmd.Parameters.AddWithValue("@StudentTime", comboBoxStudentSelectTime.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFormControls();

            }
        }
        private bool IsValid()
        {
            if (comboBoxStudentSelectGroup.Text == string.Empty)
            {
                MessageBox.Show("Student Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxStudentSelectSubGroup.Text == String.Empty)
            {
                MessageBox.Show("Sub Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxStudentSelectSessionID.Text == String.Empty)
            {
                MessageBox.Show("Session ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxStudentSelectTime.Text == String.Empty)
            {
                MessageBox.Show("Time is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }

        private void buttonStudentTimeClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }
        private void ClearFormControls()
        {

            comboBoxStudentSelectGroup.Focus();
        }
    }
}
