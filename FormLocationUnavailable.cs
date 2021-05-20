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
    public partial class FormLocationUnavailable : Form
    {
        public FormLocationUnavailable()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private void buttonLocationTimeAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO UnavailableLocation VALUES (@Room, @Day, @StartTime, @EndTime)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Room", comboBoxLocationSelectRoom.Text);
                cmd.Parameters.AddWithValue("@Day", comboBoxLocationSelectedDay.Text);
                cmd.Parameters.AddWithValue("@StartTime", comboBoxLocationStartTime.Text);
                cmd.Parameters.AddWithValue("@EndTime", comboBoxLocationEndTime.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFormControls();

            }
        }
        private bool IsValid()
        {
            if (comboBoxLocationSelectRoom.Text == string.Empty)
            {
                MessageBox.Show("Room is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLocationSelectedDay.Text == String.Empty)
            {
                MessageBox.Show("Day is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLocationStartTime.Text == String.Empty)
            {
                MessageBox.Show("Start Time is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLocationEndTime.Text == String.Empty)
            {
                MessageBox.Show("End Time is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }

        private void buttonLocationTimeClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();

        }
        private void ClearFormControls()
        {
            comboBoxLocationSelectRoom.SelectedIndex = -1;
            comboBoxLocationSelectedDay.SelectedIndex = -1;
            comboBoxLocationStartTime.SelectedIndex = -1;
            comboBoxLocationEndTime.SelectedIndex = -1;

            comboBoxLocationSelectRoom.Focus();
        }
    }
}
