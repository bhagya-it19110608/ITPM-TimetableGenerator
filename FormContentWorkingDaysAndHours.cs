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
using System.Configuration;

namespace Member3
{
    public partial class FormContentDaysAndHours : Form
    {
        public FormContentDaysAndHours()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private Form activeForm = null;

        private void openContentWorkingDaysAndHours(Form contentWorkingDaysAndHours)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentWorkingDaysAndHours;
            contentWorkingDaysAndHours.TopLevel = false;
            contentWorkingDaysAndHours.FormBorderStyle = FormBorderStyle.None;
            contentWorkingDaysAndHours.Dock = DockStyle.Fill;
            panelContentWorkingDaysAndHours.Controls.Add(contentWorkingDaysAndHours);
            panelContentWorkingDaysAndHours.Tag = contentWorkingDaysAndHours;
            contentWorkingDaysAndHours.BringToFront();
            contentWorkingDaysAndHours.Show();
        }

        private void buttonManageWorkingDuration_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132,136,152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143,147,164);
            openContentWorkingDaysAndHours(new FormManageDuration());
        }

        private void buttonAddWorkingDays_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentWorkingDaysAndHours(new FormAddWorkingDays());
        }

        private void buttonManageWorkingDays_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164); 
            openContentWorkingDaysAndHours(new FormManageWorkingDays());
        }

        private void buttonAddWorkingDuration_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(143,147,164))
                ((Control)sender).BackColor = Color.FromArgb(143,147,164);
            else
                ((Control)sender).BackColor = Color.FromArgb(132,136,152);
        }

        private void buttonDurationSave_Click(object sender, EventArgs e)
        {
           if (IsValid())
            {
              SqlCommand cmd = new SqlCommand("INSERT INTO DurationStructure VALUES (@NumberOfWorkingDays, @Monday, @Tuesday, @Wednesday, @Thursday, @Friday, @Saturday, @Sunday, @WorkingTime_Hours, @WorkingTime_Minutes, @TimeSlots)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NumberOfWorkingDays", numericUpDownWorkingDays.Text);
                cmd.Parameters.AddWithValue("@Monday", checkBoxMonday.Text);
                cmd.Parameters.AddWithValue("@Tuesday", checkBoxTuesday.Text);
                cmd.Parameters.AddWithValue("@Wednesday", checkBoxWednesday.Text);
                cmd.Parameters.AddWithValue("@Thursday", checkBoxThursday.Text);
                cmd.Parameters.AddWithValue("@Friday", checkBoxFriday.Text);
                cmd.Parameters.AddWithValue("@Saturday", checkBoxSaturday.Text);
                cmd.Parameters.AddWithValue("@Sunday", checkBoxSunday.Text);
                cmd.Parameters.AddWithValue("@WorkingTime_Hours", numericUpDownWorkingTimePerDayHours.Text);
                cmd.Parameters.AddWithValue("@WorkingTime_Minutes", numericUpDownWorkingTimePerDayMinutes.Text);
                cmd.Parameters.AddWithValue("@TimeSlots", comboBoxTimeSlot.SelectedItem);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFormControl();

            }
        }

       private bool IsValid()
       {
            if (comboBoxTimeSlot.Text == string.Empty)
            {
             MessageBox.Show("Time Slot is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
             return false;
            }
   
           return true;
       }

        private void buttonDurationClear_Click(object sender, EventArgs e)
        {
            ClearFormControl();
        }

        private void ClearFormControl()
        {
            comboBoxTimeSlot.Text = string.Empty;
            checkBoxMonday.Checked = false;
            checkBoxTuesday.Checked = false;
            checkBoxWednesday.Checked = false;
            checkBoxThursday.Checked = false;
            checkBoxFriday.Checked = false;
            checkBoxSaturday.Checked = false;
            checkBoxSunday.Checked = false;

            comboBoxTimeSlot.Focus();

        }

        private void panelContentWorkingDaysAndHours_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

