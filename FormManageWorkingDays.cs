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
    public partial class FormManageWorkingDays : Form
    {
        public FormManageWorkingDays()
        {
            InitializeComponent();
            GetAddWorkingDaysRecord();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int AWDID;
        
        private void FormManageWorkingDays_Load(object sender, EventArgs e)
        {
            GetAddWorkingDaysRecord();
            LoadDropDown();
        }

        private void GetAddWorkingDaysRecord()
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM AddWorkingDays", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewManageWorkingDays.DataSource = dt;

            //DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();
            //editbutton.FlatStyle = FlatStyle.Popup;
            //editbutton.HeaderText = "Edit";
            //editbutton.Name = "Edit";
            //editbutton.UseColumnTextForButtonValue = true;
            //editbutton.Text = "Edit";

            //editbutton.Width = 60;
            //if (dataGridViewManageWorkingDays.Columns.Contains(editbutton.Name = "Edit"))
            //{

            //}
            //else
            //{
              //  dataGridViewManageWorkingDays.Columns.Add(editbutton);
            //}
            

            //DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();
            //deletebutton.FlatStyle = FlatStyle.Popup;
            //deletebutton.HeaderText = "Delete";
            //deletebutton.Name = "Delete";
            //deletebutton.UseColumnTextForButtonValue = true;
            //deletebutton.Text = "Delete";

            //deletebutton.Width = 60;
            //if (dataGridViewManageWorkingDays.Columns.Contains(deletebutton.Name = "Delete"))
            //{

            //}
            //else
            //{
              //  dataGridViewManageWorkingDays.Columns.Add(deletebutton);
           // }
            
        }

        private void dataGridViewManageWorkingDays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AWDID = Convert.ToInt32(dataGridViewManageWorkingDays.SelectedRows[0].Cells[0].Value);
            textBoxManageWorkingDaysLecID.Text = dataGridViewManageWorkingDays.SelectedRows[0].Cells[1].Value.ToString();
            textBoxManageWorkingDaysLecturerName.Text = dataGridViewManageWorkingDays.SelectedRows[0].Cells[2].Value.ToString();
            numericUpDownManageWorkingDaysNumber.Text = dataGridViewManageWorkingDays.SelectedRows[0].Cells[3].Value.ToString();
            domainUpDownManageWorkingDaysName.Text = dataGridViewManageWorkingDays.SelectedRows[0].Cells[4].Value.ToString();
            textBoxManageWorkingDaysWeekTime.Text = dataGridViewManageWorkingDays.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void buttonManageWorkingDaysUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (AWDID > 0)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE AddWorkingDays SET LecturerID = @LecturerID,LecturerName = @LecturerName,NumberOfWorkingDays = @NumberOfWorking,WorkingDays =  @WorkingDays,TimePerWeek =  @TimePerWeek WHERE AWDID = @ID", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@LecturerID", textBoxManageWorkingDaysLecID.Text);
                    cmd.Parameters.AddWithValue("@LecturerName", textBoxManageWorkingDaysLecturerName.Text);
                    cmd.Parameters.AddWithValue("@NumberOfWorking", numericUpDownManageWorkingDaysNumber.Text);
                    cmd.Parameters.AddWithValue("@WorkingDays", domainUpDownManageWorkingDaysName.Text);
                    cmd.Parameters.AddWithValue("@TimePerWeek", textBoxManageWorkingDaysWeekTime.Text);
                    cmd.Parameters.AddWithValue("@ID", this.AWDID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetAddWorkingDaysRecord();

                }

                else
                {
                  //  MessageBox.Show("Select Record to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        private bool IsValid()
        {
            if (textBoxManageWorkingDaysLecID.Text == string.Empty && textBoxManageWorkingDaysLecturerName.Text == string.Empty && textBoxManageWorkingDaysWeekTime.Text == string.Empty)
            {
                MessageBox.Show("Select Record to update", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxManageWorkingDaysLecID.Text == string.Empty)
            {
                MessageBox.Show("Lecturer ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxManageWorkingDaysLecturerName.Text == string.Empty)
            {
                MessageBox.Show("Lecture Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxManageWorkingDaysWeekTime.Text == string.Empty)
            {
                MessageBox.Show("Time Per Week is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void buttonManageWorkingDaysClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }

        private void ClearFormControls()
        {
            AWDID = 0;
            textBoxManageWorkingDaysLecID.Clear();
            textBoxManageWorkingDaysLecturerName.Clear();
            textBoxManageWorkingDaysWeekTime.Clear();

            textBoxManageWorkingDaysLecID.Focus();
        }

        private void buttonManageWorkingDaysDelete_Click(object sender, EventArgs e)
        {
            if(AWDID > 0) 
            {
                
                SqlCommand cmd = new SqlCommand("DELETE FROM AddWorkingDays WHERE AWDID = @ID", con);

               cmd.Parameters.AddWithValue("@ID", this.AWDID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAddWorkingDaysRecord();
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
            string sqlquery = " select distinct WorkingDays from AddWorkingDays";
            SqlCommand cmd = new SqlCommand(sqlquery, con);



            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            // SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dr = dt.NewRow();
            comboBoxManageWorkingDaysSearch.DisplayMember = "WorkingDays";
            comboBoxManageWorkingDaysSearch.DataSource = dt;
            con.Close();
        }
        private void buttonManageWorkingDaysSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxManageWorkingDaysSearch.Text == "")
            {
                GetAddWorkingDaysRecord();
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
                string sqlquery = "SELECT * FROM AddWorkingDays WHERE WorkingDays = '" + comboBoxManageWorkingDaysSearch.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, con);



                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                // SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridViewManageWorkingDays.DataSource = dt;
                con.Close();
            }
           

        }

        private void dataGridViewManageWorkingDays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
