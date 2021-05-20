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
    public partial class FormManageLocationSession : Form
    {
        FormSessionExtendForLocation frmle = new FormSessionExtendForLocation();
        public FormManageLocationSession()
        {
            InitializeComponent();
            GetConsecutiveLocationRecord();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int LC;

        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            frmle.Show();
        }

        private void FormManageLocationSession_Load(object sender, EventArgs e)
        {
            LoadDropDown();
            GetConsecutiveLocationRecord();
        }
        private void GetConsecutiveLocationRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT * FROM LocationConsecutive", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewLocation.DataSource = dt;
        }

        private void dataGridViewLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LC = Convert.ToInt32(dataGridViewLocation.SelectedRows[0].Cells[0].Value);
            comboBoxLec.Text = dataGridViewLocation.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxSub.Text = dataGridViewLocation.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxSession.Text = dataGridViewLocation.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxRoom.Text = dataGridViewLocation.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxTag.Text = dataGridViewLocation.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (LC > 0)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE  LocationConsecutive SET LecturerName = @LecturerName, SubjectName = @SubjectName, SessonID = @SessionID, Room =@Room, Tag = @Tag", con);
                    //SqlCommand cmd = new SqlCommand("UPDATE UnavailableLecturer SET LecturerName = '"+ comboBoxManageLecturerSelectLecturer.Text + "',Group ='"+comboBoxManageLecturerSelectGroup.Text + "',SubGroup = '" +comboBoxManageLecturerSelectSubGroup.Text+ "',SessionID = '"+ comboBoxManageLecturerSelectSessionID.Text+"',Time =  '"+comboBoxManageLecturerSelectTime.Text+"' WHERE NATA_LEC = '"+this.NATA_LEC+"'", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@LecturerName", comboBoxLec.Text);
                    cmd.Parameters.AddWithValue("@SubjectName", comboBoxSub.Text);
                    cmd.Parameters.AddWithValue("@SessionID", comboBoxSession.Text);
                    cmd.Parameters.AddWithValue("@Room", comboBoxRoom.Text);
                    cmd.Parameters.AddWithValue("@Tag", comboBoxTag.Text);
                    cmd.Parameters.AddWithValue("@ID", this.LC);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetConsecutiveLocationRecord();

                }

                else
                {
                    //  MessageBox.Show("Select Record to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
        private bool IsValid()
        {
            if (comboBoxLec.Text == string.Empty && comboBoxSub.Text == string.Empty && comboBoxSession.Text == string.Empty && comboBoxRoom.Text == string.Empty && comboBoxTag.Text == string.Empty)
            {
                MessageBox.Show("Select Record to update", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxLec.Text == string.Empty)
            {
                MessageBox.Show("Lecturer Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxSub.Text == string.Empty)
            {
                MessageBox.Show("Subject Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxSession.Text == string.Empty)
            {
                MessageBox.Show("Session ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxRoom.Text == string.Empty)
            {
                MessageBox.Show("Room is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxTag.Text == string.Empty)
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
            LC = 0;

            comboBoxLec.Focus();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (LC > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM LocationConsecutive WHERE LC = @ID", con);

                cmd.Parameters.AddWithValue("@ID", this.LC);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetConsecutiveLocationRecord();
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
            string sqlquery = " select distinct LecturerName from LocationConsecutive";
            SqlCommand cmd = new SqlCommand(sqlquery, con);



            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            // SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dr = dt.NewRow();
            comboBoxSearch.DisplayMember = "LecturerName";
            comboBoxSearch.DataSource = dt;
            con.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSearch.Text == "")
            {
                GetConsecutiveLocationRecord();
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
                string sqlquery = "SELECT * FROM LocationConsecutive WHERE LecturerName = '" + comboBoxSearch.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, con);



                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                // SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridViewLocation.DataSource = dt;
                con.Close();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetConsecutiveLocationRecord();
            LoadDropDown();
        }
    }
}
