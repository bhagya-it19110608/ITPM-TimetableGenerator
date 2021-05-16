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
    public partial class FormAddWorkingDays : Form
    {
        public FormAddWorkingDays()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
       
            private void buttonAddWorkingDaysSave_Click(object sender, EventArgs e)
            {
                if (IsValid())
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO AddWorkingDays VALUES (@LecturerID, @LecturerName, @NumberOfWorking, @WorkingDays, @TimePerWeek)", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@LecturerID", textBoxAddWorkingDaysLecID.Text);
                    cmd.Parameters.AddWithValue("@LecturerName", textBoxAddWorkingDaysLecturerName.Text);
                    cmd.Parameters.AddWithValue("@NumberOfWorking", numericUpDownAddWorkingDaysNumber.Text);
                    cmd.Parameters.AddWithValue("@WorkingDays", domainUpDownAddWorkingDaysName.Text);
                    cmd.Parameters.AddWithValue("@TimePerWeek", textBoxAddWorkingDaysWeekTime.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFormControls();

                }
            }
        
        private bool IsValid()
        {
            if(textBoxAddWorkingDaysLecID.Text == string.Empty)
            {
                MessageBox.Show("Lecturer ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(textBoxAddWorkingDaysLecturerName.Text == string.Empty)
            {
                MessageBox.Show("Lecture Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(textBoxAddWorkingDaysWeekTime.Text == String.Empty)
            {
                MessageBox.Show("Time Per Week is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            

        }

        private void buttonAddWorkingDaysClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }

        private void ClearFormControls()
        {
            textBoxAddWorkingDaysLecID.Clear();
            textBoxAddWorkingDaysLecturerName.Clear();
            textBoxAddWorkingDaysWeekTime.Clear();

            textBoxAddWorkingDaysLecID.Focus();
        }
    }
}
