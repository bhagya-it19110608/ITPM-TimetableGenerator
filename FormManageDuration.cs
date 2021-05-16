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
    
    public partial class FormManageDuration : Form
    {
        public FormManageDuration()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int DurationID;
        
        private void FormManageDuration_Load(object sender, EventArgs e)
        {
            GetDurationRecord();
        }

        private void GetDurationRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from DurationStructure", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewManageDuration.DataSource = dt;
        }

        private void dataGridViewManageDuration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DurationID = Convert.ToInt32(dataGridViewManageDuration.SelectedRows[0].Cells[0].Value);
            numericUpDownManageDurationNumberOfWorkingDays.Text = dataGridViewManageDuration.SelectedRows[0].Cells[1].Value.ToString();
            checkBoxManageDurationMonday.Text = dataGridViewManageDuration.SelectedRows[0].Cells[2].Value.ToString();
            checkBoxManageDurationTuesday.Text = dataGridViewManageDuration.SelectedRows[0].Cells[3].Value.ToString();
            checkBoxManageDurationWednesday.Text = dataGridViewManageDuration.SelectedRows[0].Cells[4].Value.ToString();
            checkBoxManageDurationThursday.Text = dataGridViewManageDuration.SelectedRows[0].Cells[5].Value.ToString();
            checkBoxManageDurationFriday.Text = dataGridViewManageDuration.SelectedRows[0].Cells[6].Value.ToString();
            checkBoxManageDurationSaturday.Text = dataGridViewManageDuration.SelectedRows[0].Cells[7].Value.ToString();
            checkBoxManageDurationSunday.Text = dataGridViewManageDuration.SelectedRows[0].Cells[8].Value.ToString();
            numericUpDownWorkingTimePerDayHours.Text = dataGridViewManageDuration.SelectedRows[0].Cells[9].Value.ToString();
            numericUpDownWorkingTimePerDayMinutes.Text = dataGridViewManageDuration.SelectedRows[0].Cells[10].Value.ToString();
            comboBoxManageDurationTimeSlots.Text = dataGridViewManageDuration.SelectedRows[0].Cells[11].Value.ToString();

        }

        private void buttonManageDurationUpdate_Click(object sender, EventArgs e)
        {
            if (DurationID > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE DurationStructure SET NumberOfWorkingDays = @NumberOfWorkingDays, Monday = @Monday, Tuesday = @Tuesday, Wednesday =  @Wednesday, Thursday =  @Thursday, Friday = @Friday, Saturday = @Saturday, Sunday = @Sunday, WorkingTime_Hours = @WorkingTime_Hours, WorkingTime_Minutes = @WorkingTime_Minutes, TimeSlot = @TimeSlot WHERE DurationID = @ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NumberOfWorkingDays", numericUpDownManageDurationNumberOfWorkingDays.Text);
                cmd.Parameters.AddWithValue("@Monday", checkBoxManageDurationMonday.Text);
                cmd.Parameters.AddWithValue("@Tuesday", checkBoxManageDurationTuesday.Text);
                cmd.Parameters.AddWithValue("@Wednesday", checkBoxManageDurationWednesday.Text);
                cmd.Parameters.AddWithValue("@Thursday", checkBoxManageDurationThursday.Text);
                cmd.Parameters.AddWithValue("@Friday", checkBoxManageDurationFriday.Text);
                cmd.Parameters.AddWithValue("@Saturday", checkBoxManageDurationSaturday.Text);
                cmd.Parameters.AddWithValue("@Sunday", checkBoxManageDurationSunday.Text);
                cmd.Parameters.AddWithValue("@WorkingTime_Hours", numericUpDownWorkingTimePerDayHours.Text);
                cmd.Parameters.AddWithValue("@WorkingTime_Minutes", numericUpDownWorkingTimePerDayMinutes.Text);
                cmd.Parameters.AddWithValue("@TimeSlot", comboBoxManageDurationTimeSlots.SelectedItem);

                cmd.Parameters.AddWithValue("@ID", this.DurationID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetDurationRecord();

            }
            else
            {
                MessageBox.Show("Select Record to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonManageDurationClear_Click(object sender, EventArgs e)
        {
            ClearFormControl();
        }

        private void ClearFormControl()
        {
            DurationID = 0;
            comboBoxManageDurationTimeSlots.Text = String.Empty;
            checkBoxManageDurationMonday.Checked = false;
            checkBoxManageDurationTuesday.Checked = false;
            checkBoxManageDurationWednesday.Checked = false;
            checkBoxManageDurationThursday.Checked = false;
            checkBoxManageDurationFriday.Checked = false;
            checkBoxManageDurationSaturday.Checked = false;
            checkBoxManageDurationSunday.Checked = false;
            

        }

        private void buttonManageDurationDelete_Click(object sender, EventArgs e)
        {
            if (DurationID > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM DurationStructure WHERE DurationID = @ID", con);

                cmd.Parameters.AddWithValue("@ID", this.DurationID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetDurationRecord();
            }

            else
            {
                MessageBox.Show("Select Record to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
