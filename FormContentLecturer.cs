using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Member3
{
    public partial class FormContentLecturer : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        public FormContentLecturer()
        {
            InitializeComponent();
        }
        private void TableLoad()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "select LecturerName,EmployeeID,Department,Center,Faculty,Building,LecturerLevel,Rank from AddLecturer";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adpter.Fill(ds);
            dt = ds.Tables[0];

            //Bind the fetched data to gridview
           // gridmanagelectrer.DataSource = dt;

            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();

            editbutton.FlatStyle = FlatStyle.Popup;

            editbutton.HeaderText = "Edit";
            editbutton.Name = "Edit";
            editbutton.UseColumnTextForButtonValue = true;
            editbutton.Text = "Edit";

            editbutton.Width = 60;

            //if (gridmanagelectrer.Columns.Contains(editbutton.Name = "Edit"))
            //{

            //}
            //else
            //{
              //  gridmanagelectrer.Columns.Add(editbutton);
            //}
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;

            deletebutton.HeaderText = "Delete";
            deletebutton.Name = "Delete";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Delete";

            deletebutton.Width = 60;

            //if (gridmanagelectrer.Columns.Contains(deletebutton.Name = "Delete"))
            //{

            //}
            //else
            //{
              //  gridmanagelectrer.Columns.Add(deletebutton);
            //}
        }
        public void registerLecturer()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "Insert into AddLecturer(LecturerName,EmployeeID,Faculty,Department,Center,Building,LecturerLevel,Rank) values ('" + talname.Text + "','" + talid.Text + "','" + calfaculty.Text + "','" + caldepartment.Text + "','" + calcenter.Text + "','" + calbuilding.Text + "','" + callevel.Text + "','" + talrank.Text + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection = con;
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Lecture is Registered");
                con.Close();
            }
            else
            {
                MessageBox.Show("Error for Registered");
            }
        }
        private void Generaterank()
        {
            string EmployeeId = talid.Text;
            string level = callevel.Text;
            string rank = level + "." + EmployeeId;
            talrank.Text = rank;
        }

        private void ManageGeneraterank()
        {
            //string EmployeeId = tmlid.Text;
            //string level = cmllevel.Text;
            //string rank = level + "." + EmployeeId;
            //tmlrank.Text = rank;
        }

        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private Form activeForm = null;

        private void openContentLecturer(Form contentLecturer)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentLecturer;
            contentLecturer.TopLevel = false;
            contentLecturer.FormBorderStyle = FormBorderStyle.None;
            contentLecturer.Dock = DockStyle.Fill;
            panelContentLecturer.Controls.Add(contentLecturer);
            panelContentLecturer.Tag = contentLecturer;
            contentLecturer.BringToFront();
            contentLecturer.Show();
        }


        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentLecturer(new FormAddNotAvailableTimeOfLecturer());
            
        }

        private void panelLecturerContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void balsave_Click(object sender, EventArgs e)
        {

        }

        private void balclear_Click(object sender, EventArgs e)
        {

        }

        private void balgeneraterank_Click(object sender, EventArgs e)
        {

        }

        private void talrank_TextChanged(object sender, EventArgs e)
        {

        }

        private void callevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void talname_TextChanged(object sender, EventArgs e)
        {

        }

        private void balgeneraterank_Click_1(object sender, EventArgs e)
        {
            if (talid.Text == "" && callevel.Text == "")
            {
                MessageBox.Show("Please fill Employee ID and Level");
            }
            else
            {
                Generaterank();
            }
        }

        private void balsave_Click_1(object sender, EventArgs e)
        {
            if (talid.Text.Length == 6)
            {
                registerLecturer();
            }
            else
            {
                MessageBox.Show("Please check the Employee id ");
            }
            TableLoad();
        }

        private void baladdhours_Click(object sender, EventArgs e)
        {
            AddLecturerHours();
        }
        private void AddLecturerHours()
        {
            SqlConnection con = new SqlConnection(myconstring);
            con.Open();
            string sql = "Insert into AddHours(SelectDay,EmployeeID,HoursFrom,HoursTo) values ('" + calday.Text + "','" + talid.Text + "','" + calfrom.Text + "','" + calto.Text + "')";


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection = con;
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Add Hours ");
                con.Close();
                addTableHousLoad();
            }
            else
            {
                MessageBox.Show("Error for Registered");
            }


        }
        private void addTableHousLoad()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "select SelectDay,HoursFrom,HoursTo from AddHours Where EmployeeID='" + talid.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adpter.Fill(ds);
            dt = ds.Tables[0];

            //Bind the fetched data to gridview
            dataGridView1.DataSource = dt;
        }

        private void balclear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            talname.Text = "";
            talid.Text = "";
            calfaculty.SelectedIndex = -1;
            caldepartment.SelectedIndex = -1;
            calcenter.SelectedIndex = -1;
            calbuilding.SelectedIndex = -1;
            callevel.SelectedIndex = -1;
            talrank.Text = "";
            calday.SelectedIndex = -1;
            calfrom.SelectedIndex = -1;
            calto.SelectedIndex = -1;
        }
        public void Update()
        {

            SqlConnection con = new SqlConnection(myconstring);
            string sql = " UPDATE AddLecturer SET LecturerName = '" + talname.Text + "', EmployeeID = '" + talid.Text + "', Faculty = '" + calfaculty.Text + "', Department = '" + caldepartment.Text + "', Center = '" + calcenter.Text + "', Building = '" + calcenter.Text + "', LecturerLevel = '" + callevel.Text + "', Rank = '" + talrank.Text + "' WHERE EmployeeID = '" + talid.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        private void gridmanagelectrer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //tmlname.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[2].Value.ToString();
                //tmlid.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[3].Value.ToString();
                //cmlfaculty.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[6].Value.ToString();
                //cmldepartment.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[4].Value.ToString();
                //cmlcenter.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[5].Value.ToString();
                //cmlbuilding.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[7].Value.ToString();
                //cmllevel.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[8].Value.ToString();
                //tmlrank.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
            else if (e.ColumnIndex == 1)
            {

                Delete();

            }
            TableLoad();
        }
        private void Delete()
        {
            SqlConnection con = new SqlConnection(myconstring);
            //string sql = " delete from AddLecturer WHERE EmployeeID = '" + tmlid.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Deleted");
                con.Close();
                TableLoad();
            }
            else
            {
                MessageBox.Show("Please check the Employee ID !");
            }
        }

        private void buttonManageLecturer_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentLecturer(new FormManageLecturer());
        }

        private void buttonAddLecturer_Click(object sender, EventArgs e)
        {

        }
    }

}
