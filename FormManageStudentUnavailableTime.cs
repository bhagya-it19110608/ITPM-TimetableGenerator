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
    public partial class FormManageStudentUnavailableTime : Form
    {
        FormStudentAddSession frmStu = new FormStudentAddSession();
        public FormManageStudentUnavailableTime()
        {
            InitializeComponent();
            GetUnavailableStudentRecord();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int NATA_STU;


        private void buttonManageStudentTimeAddSession_Click(object sender, EventArgs e)
        {
            frmStu.Show();
        }

        private void FormManageStudentUnavailableTime_Load(object sender, EventArgs e)
        {
            GetUnavailableStudentRecord();
            LoadDropDown();
        }
        private void GetUnavailableStudentRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM UnavailableStudent", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewManageStudentUnavailableTime.DataSource = dt;
        }

        private void dataGridViewManageStudentUnavailableTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NATA_STU = Convert.ToInt32(dataGridViewManageStudentUnavailableTime.SelectedRows[0].Cells[0].Value);
            //comboBoxManageLecturerSelectLecturer.Text = dataGridViewManageStudentUnavailableTime.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxManageStudentSelectGroup.Text = dataGridViewManageStudentUnavailableTime.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxManageStudentSelectSubGroup.Text = dataGridViewManageStudentUnavailableTime.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxManageStudentSelectSessionID.Text = dataGridViewManageStudentUnavailableTime.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxManageStudentSelectTime.Text = dataGridViewManageStudentUnavailableTime.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void buttonManageStudentTimeUpdate_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                if (NATA_STU > 0)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE UnavailableStudent SET StudentGroup = @StudentGroup,StudentSubGroup = @StudentSubGroup,StudentSessionID =  @StudentSessionID,StudentTime =  @StudentTime WHERE NATA_STU = @ID", con);
                    

                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@LecturerName", comboBoxManageLecturerSelectLecturer.Text);
                    cmd.Parameters.AddWithValue("@StudentGroup", comboBoxManageStudentSelectGroup.Text);
                    cmd.Parameters.AddWithValue("@StudentSubGroup", comboBoxManageStudentSelectSubGroup.Text);
                    cmd.Parameters.AddWithValue("@StudentSessionID", comboBoxManageStudentSelectSessionID.Text);
                    cmd.Parameters.AddWithValue("@StudentTime", comboBoxManageStudentSelectTime.Text);
                    cmd.Parameters.AddWithValue("@ID", this.NATA_STU);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUnavailableStudentRecord();

                }

                else
                {
                    //  MessageBox.Show("Select Record to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        private bool IsValid()
        {
            if (comboBoxManageStudentSelectGroup.Text == string.Empty && comboBoxManageStudentSelectSubGroup.Text == string.Empty && comboBoxManageStudentSelectSessionID.Text == string.Empty && comboBoxManageStudentSelectTime.Text == string.Empty)
            {
                MessageBox.Show("Select Record to update", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (comboBoxManageStudentSelectGroup.Text == string.Empty)
            {
                MessageBox.Show("Student Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxManageStudentSelectSubGroup.Text == string.Empty)
            {
                MessageBox.Show("Sub Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxManageStudentSelectSessionID.Text == string.Empty)
            {
                MessageBox.Show("Session ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxManageStudentSelectTime.Text == string.Empty)
            {
                MessageBox.Show("Time is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void buttonManageStudentTimeClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }
        private void ClearFormControls()
        {
            NATA_STU = 0;

            comboBoxManageStudentSelectGroup.Focus();
        }

        private void buttonManageStudentTimeDelete_Click(object sender, EventArgs e)
        {
            if (NATA_STU > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM UnavailableStudent WHERE NATA_STU = @ID", con);

                cmd.Parameters.AddWithValue("@ID", this.NATA_STU);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetUnavailableStudentRecord();
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
            string sqlquery = " select distinct StudentGroup from UnavailableStudent";
            SqlCommand cmd = new SqlCommand(sqlquery, con);



            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            // SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dr = dt.NewRow();
            comboBoxManageStudentTime.DisplayMember = "StudentGroup";
            comboBoxManageStudentTime.DataSource = dt;
            con.Close();
        }

        private void buttonManageStudentTimeSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxManageStudentTime.Text == "")
            {
                GetUnavailableStudentRecord();
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
                string sqlquery = "SELECT * FROM UnavailableStudent WHERE StudentGroup = '" + comboBoxManageStudentTime.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, con);



                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                // SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridViewManageStudentUnavailableTime.DataSource = dt;
                con.Close();
            }
        }

        private void buttonManageStudentSearchRefresh_Click(object sender, EventArgs e)
        {
            GetUnavailableStudentRecord();
            LoadDropDown();
        }
    }



}
