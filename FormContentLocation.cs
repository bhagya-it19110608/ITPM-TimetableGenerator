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
    public partial class FormContentLocation : Form
    {
        public FormContentLocation()
        {
            InitializeComponent();
        }
        string Type;
        int ID;
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private Form activeForm = null;

        private void openContentLocation(Form contentLocation)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentLocation;
            contentLocation.TopLevel = false;
            contentLocation.FormBorderStyle = FormBorderStyle.None;
            contentLocation.Dock = DockStyle.Fill;
            panelContentLocation.Controls.Add(contentLocation);
            panelContentLocation.Tag = contentLocation;
            contentLocation.BringToFront();
            contentLocation.Show();
        }

        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentLocation(new FormSessionExtendForLocation());
        }

        private void FormContentLocation_Load(object sender, EventArgs e)
        {
            GetLocationRecord();
        }
        private void GetLocationRecord()
        {


            SqlCommand cmd = new SqlCommand("Select * from Location", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

          

            radioButton1.Text = "Lecturer";
            radioButton2.Text = "Lab";

            Type = radioButton1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Location VALUES (@Building, @Room, @Room_Type, @Capacity)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Building", txtBuildingName.Text);
                cmd.Parameters.AddWithValue("@Room", Room.Text);
                cmd.Parameters.AddWithValue("@Room_Type", radioButton1.Text);
                cmd.Parameters.AddWithValue("@Capacity", Cap.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Location informations Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLocationRecord();
                ResetDetails();
            }
        }
        private bool IsValid()
        {
            if (txtBuildingName.Text == string.Empty)
            {
                MessageBox.Show("Building Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Room.Text == string.Empty)
            {
                MessageBox.Show("Room Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Cap.Text == string.Empty)
            {
                MessageBox.Show("Capacity is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetDetails();
        }
        private void ResetDetails()
        {
            Cap.ResetText();
            txtBuildingName.SelectedIndex = -1;
            Room.SelectedIndex = -1;

            


        }

        private void buttonManageLocation_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentLocation(new FormLocationManage());
            
        }

        private void buttonManageSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentLocation(new FormManageLocationSession());
        }
    }
}
