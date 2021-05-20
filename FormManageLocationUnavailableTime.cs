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
    public partial class FormManageLocationUnavailableTime : Form
    {
        FormLocationUnavailable frmLc = new FormLocationUnavailable();
        
        public FormManageLocationUnavailableTime()
        {
            InitializeComponent();
            GetUnavailableLocationRecord();
        }

        private void buttonManageLocationTimeAddSession_Click(object sender, EventArgs e)
        {
            frmLc.Show();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int NATA_LOC;

        private void FormManageLocationUnavailableTime_Load(object sender, EventArgs e)
        {
            GetUnavailableLocationRecord();
            LoadDropDown();
        }
        private void GetUnavailableLocationRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM UnavailableLocation", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewManageLocationUnavailableTime.DataSource = dt;
        }

        private void dataGridViewManageLocationUnavailableTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NATA_LOC = Convert.ToInt32(dataGridViewManageLocationUnavailableTime.SelectedRows[0].Cells[0].Value);
            //comboBoxManageLecturerSelectLecturer.Text = dataGridViewManageStudentUnavailableTime.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxLocationSelectRoom.Text = dataGridViewManageLocationUnavailableTime.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxLocationSelectedDay.Text = dataGridViewManageLocationUnavailableTime.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxLocationStartTime.Text = dataGridViewManageLocationUnavailableTime.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxLocationEndTime.Text = dataGridViewManageLocationUnavailableTime.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void buttonManageLocationTimeUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (NATA_LOC > 0)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE UnavailableLocation SET Room = @Room,Day = @Day,StartTime =  @StartTime,EndTime =  @EndTime WHERE NATA_LOC = @ID", con);


                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@LecturerName", comboBoxManageLecturerSelectLecturer.Text);
                    cmd.Parameters.AddWithValue("@Room", comboBoxLocationSelectRoom.Text);
                    cmd.Parameters.AddWithValue("@Day", comboBoxLocationSelectedDay.Text);
                    cmd.Parameters.AddWithValue("@StartTime", comboBoxLocationStartTime.Text);
                    cmd.Parameters.AddWithValue("@EndTime", comboBoxLocationEndTime.Text);
                    cmd.Parameters.AddWithValue("@ID", this.NATA_LOC);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUnavailableLocationRecord();

                }

                else
                {
                    //  MessageBox.Show("Select Record to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        private bool IsValid()
        {
            if (comboBoxLocationSelectRoom.Text == string.Empty && comboBoxLocationSelectedDay.Text == string.Empty && comboBoxLocationStartTime.Text == string.Empty && comboBoxLocationEndTime.Text == string.Empty)
            {
                MessageBox.Show("Select Record to update", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxLocationSelectRoom.Text == string.Empty)
            {
                MessageBox.Show("Room is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLocationSelectedDay.Text == string.Empty)
            {
                MessageBox.Show("Day is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLocationStartTime.Text == string.Empty)
            {
                MessageBox.Show("Start Time is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLocationEndTime.Text == string.Empty)
            {
                MessageBox.Show("End Time is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void buttonManageLocationTimeClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }
        private void ClearFormControls()
        {
            NATA_LOC = 0;

            comboBoxLocationSelectRoom.SelectedIndex = -1;
            comboBoxLocationSelectedDay.SelectedIndex = -1;
            comboBoxLocationStartTime.SelectedIndex = -1;
            comboBoxLocationEndTime.SelectedIndex = -1;

            comboBoxLocationSelectRoom.Focus();
        }

        private void buttonManageLocationTimeDelete_Click(object sender, EventArgs e)
        {
            if (NATA_LOC > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM UnavailableLocation WHERE NATA_LOC = @ID", con);

                cmd.Parameters.AddWithValue("@ID", this.NATA_LOC);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetUnavailableLocationRecord();
            }
            else
            {
                MessageBox.Show("Select Record to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDropDown()
        {
            DataRow dr;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
            string sqlquery = " select distinct Room from UnavailableLocation";
            SqlCommand cmd = new SqlCommand(sqlquery, con);



            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            // SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dr = dt.NewRow();
            comboBoxManageLocationTime.DisplayMember = "Room";
            comboBoxManageLocationTime.DataSource = dt;
            con.Close();
        }

        private void buttonManageLocationTimeSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxManageLocationTime.Text == "")
            {
                GetUnavailableLocationRecord();
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
                string sqlquery = "SELECT * FROM UnavailableLocation WHERE Room = '" + comboBoxManageLocationTime.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, con);



                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                // SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridViewManageLocationUnavailableTime.DataSource = dt;
                con.Close();
            }
        }

        private void buttonManageLocationSearchRefresh_Click(object sender, EventArgs e)
        {
            GetUnavailableLocationRecord();
            LoadDropDown();
        }
    }

}
