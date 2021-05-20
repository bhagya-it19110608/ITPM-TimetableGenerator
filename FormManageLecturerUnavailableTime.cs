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
    public partial class FormManageLecturerUnavailableTime : Form
    {
        FormLecturerUnavailable frmLec = new FormLecturerUnavailable();
        public FormManageLecturerUnavailableTime()
        {
            InitializeComponent();
            GetUnavailableLecturerRecord();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int NATA_LEC;
        
        private Form activeForm = null;

        private void openContentUnavailableTime(Form contentUnavailableTime)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentUnavailableTime;
            contentUnavailableTime.TopLevel = false;
            contentUnavailableTime.FormBorderStyle = FormBorderStyle.None;
            contentUnavailableTime.Dock = DockStyle.Fill;
            panelContentUnavailableTime.Controls.Add(contentUnavailableTime);
            panelContentUnavailableTime.Tag = contentUnavailableTime;
            contentUnavailableTime.BringToFront();
            contentUnavailableTime.Show();
        }
        private void buttonManageLecTimeAllocation_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(53, 66, 119))
                ((Control)sender).BackColor = Color.FromArgb(53, 66, 119);
            else
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
        }

        private void buttonManageStudentTimeAllocation_Click(object sender, EventArgs e)
        {
            buttonManageLecTimeAllocation.BackColor= Color.FromArgb(132, 136, 152);
            if (((Control)sender).BackColor != Color.FromArgb(53, 66, 119))
                ((Control)sender).BackColor = Color.FromArgb(53, 66, 119);

            else
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            openContentUnavailableTime(new FormManageStudentUnavailableTime());
        }

        private void buttonManageLocationAllocation_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(53, 66, 119))
                ((Control)sender).BackColor = Color.FromArgb(53, 66, 119);
            else
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            openContentUnavailableTime(new FormManageLocationUnavailableTime());
        }

        private void buttonManageLecturerTimeAddSession_Click(object sender, EventArgs e)
        {
            frmLec.Show();
        }

        private void FormManageLecturerUnavailableTime_Load(object sender, EventArgs e)
        {
            GetUnavailableLecturerRecord();
            LoadDropDown();
        }

        private void GetUnavailableLecturerRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM UnavailableLecturer", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewManageLecturerUnavailableTime.DataSource = dt;
        }

        private void dataGridViewManageLecturerUnavailableTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NATA_LEC = Convert.ToInt32(dataGridViewManageLecturerUnavailableTime.SelectedRows[0].Cells[0].Value);
            comboBoxManageLecturerSelectLecturer.Text = dataGridViewManageLecturerUnavailableTime.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxManageLecturerSelectGroup.Text = dataGridViewManageLecturerUnavailableTime.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxManageLecturerSelectSubGroup.Text = dataGridViewManageLecturerUnavailableTime.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxManageLecturerSelectSessionID.Text = dataGridViewManageLecturerUnavailableTime.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxManageLecturerSelectTime.Text = dataGridViewManageLecturerUnavailableTime.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void buttonManageLecturerTimeUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (NATA_LEC > 0)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE UnavailableLecturer SET LecturerName = @LecturerName,LGroup = @LGroup,SubGroup = @SubGroup,SessionID =  @SessionID,Time =  @Time WHERE NATA_LEC = @ID", con);
                    //SqlCommand cmd = new SqlCommand("UPDATE UnavailableLecturer SET LecturerName = '"+ comboBoxManageLecturerSelectLecturer.Text + "',Group ='"+comboBoxManageLecturerSelectGroup.Text + "',SubGroup = '" +comboBoxManageLecturerSelectSubGroup.Text+ "',SessionID = '"+ comboBoxManageLecturerSelectSessionID.Text+"',Time =  '"+comboBoxManageLecturerSelectTime.Text+"' WHERE NATA_LEC = '"+this.NATA_LEC+"'", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@LecturerName", comboBoxManageLecturerSelectLecturer.Text);
                    cmd.Parameters.AddWithValue("@LGroup", comboBoxManageLecturerSelectGroup.Text);
                    cmd.Parameters.AddWithValue("@SubGroup", comboBoxManageLecturerSelectSubGroup.Text);
                    cmd.Parameters.AddWithValue("@SessionID", comboBoxManageLecturerSelectSessionID.Text);
                    cmd.Parameters.AddWithValue("@Time", comboBoxManageLecturerSelectTime.Text);
                    cmd.Parameters.AddWithValue("@ID", this.NATA_LEC);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUnavailableLecturerRecord();

                }

                else
                {
                    //  MessageBox.Show("Select Record to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        private bool IsValid()
        {
            if (comboBoxManageLecturerSelectLecturer.Text == string.Empty && comboBoxManageLecturerSelectGroup.Text == string.Empty && comboBoxManageLecturerSelectSubGroup.Text == string.Empty && comboBoxManageLecturerSelectSessionID.Text == string.Empty && comboBoxManageLecturerSelectTime.Text == string.Empty)
            {
                MessageBox.Show("Select Record to update", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxManageLecturerSelectLecturer.Text == string.Empty)
            {
                MessageBox.Show("Lecturer Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxManageLecturerSelectGroup.Text == string.Empty)
            {
                MessageBox.Show("Lecture Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxManageLecturerSelectSubGroup.Text == string.Empty)
            {
                MessageBox.Show("Sub Group is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxManageLecturerSelectSessionID.Text == string.Empty)
            {
                MessageBox.Show("Session ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxManageLecturerSelectTime.Text == string.Empty)
            {
                MessageBox.Show("Time is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void buttonManageLecturerTimeClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }
        private void ClearFormControls()
        {
            NATA_LEC = 0;
            
            comboBoxManageLecturerSelectLecturer.Focus();
        }

        private void buttonManageLecturerTimeDelete_Click(object sender, EventArgs e)
        {
            if(NATA_LEC > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM UnavailableLecturer WHERE NATA_LEC = @ID", con);

                cmd.Parameters.AddWithValue("@ID", this.NATA_LEC);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetUnavailableLecturerRecord();
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
            string sqlquery = " select distinct LecturerName from UnavailableLecturer";
            SqlCommand cmd = new SqlCommand(sqlquery, con);



            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            // SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dr = dt.NewRow();
            comboBoxManageLecturerTime.DisplayMember = "LecturerName";
            comboBoxManageLecturerTime.DataSource = dt;
            con.Close();
        }

        private void buttonManageLecturerTimeSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxManageLecturerTime.Text == "")
            {
                GetUnavailableLecturerRecord();
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
                string sqlquery = "SELECT * FROM UnavailableLecturer WHERE LecturerName = '" + comboBoxManageLecturerTime.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, con);



                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                // SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridViewManageLecturerUnavailableTime.DataSource = dt;
                con.Close();
            }


        }

        private void buttonManageLecturerSearchRefresh_Click(object sender, EventArgs e)
        {
            GetUnavailableLecturerRecord();
            LoadDropDown();
        }
    }
    
    
}
