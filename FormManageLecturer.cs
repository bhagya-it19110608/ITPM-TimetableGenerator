using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Member3
{
    public partial class FormManageLecturer : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        
        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        public FormManageLecturer()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void TableLoad()
        {
            //SqlConnection con = new SqlConnection(myconstring);
            //SqlCommand cmd = new SqlCommand("SELECT LecturerName,EmployeeID,Department,Center,Faculty,Building,LecturerLevel,Rank FROM AddLecturer", con);
            //DataTable dt = new DataTable();

            //con.Open();

            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();

            //dataGridView2.DataSource = dt;


            SqlConnection con = new SqlConnection(myconstring);
            string sql = "select LecturerName,EmployeeID,Department,Center,Faculty,Building,LecturerLevel,Rank from AddLecturer";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adpter.Fill(ds);
            dt = ds.Tables[0];

            //Bind the fetched data to gridview
            gridmanagelectrer.DataSource = dt;
            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();

            editbutton.FlatStyle = FlatStyle.Popup;

            editbutton.HeaderText = "Edit";
            editbutton.Name = "Edit";
            editbutton.UseColumnTextForButtonValue = true;
            editbutton.Text = "Edit";

            editbutton.Width = 60;

            if (gridmanagelectrer.Columns.Contains(editbutton.Name = "Edit"))
            {

            }
            else
            {
                gridmanagelectrer.Columns.Add(editbutton);
            }
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;

            deletebutton.HeaderText = "Delete";
            deletebutton.Name = "Delete";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Delete";

            deletebutton.Width = 60;

            if (gridmanagelectrer.Columns.Contains(deletebutton.Name = "Delete"))
            {

            }
            else
            {
                gridmanagelectrer.Columns.Add(deletebutton);
            }
        }
        private void ManageGeneraterank()
        {
            string EmployeeId = tmlid.Text;
            string level = cmllevel.Text;
            string rank = level + "." + EmployeeId;
            tmlrank.Text = rank;
        }
        //public void Update()
        //{

          //  SqlConnection con = new SqlConnection(myconstring);
            //string sql = " UPDATE AddLecturer SET LecturerName = '" + talname.Text + "', EmployeeID = '" + talid.Text + "', Faculty = '" + calfaculty.Text + "', Department = '" + caldepartment.Text + "', Center = '" + calcenter.Text + "', Building = '" + calcenter.Text + "', LecturerLevel = '" + callevel.Text + "', Rank = '" + talrank.Text + "' WHERE EmployeeID = '" + talid.Text + "'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //int rows = cmd.ExecuteNonQuery();
            //if (rows > 0)
            //{
              //  MessageBox.Show("Updated");
            //}
            //else
            //{
              //  MessageBox.Show("Error");
            //}

//        }

        private void gridmanagelectrer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                tmlname.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[2].Value.ToString();
                tmlid.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmlfaculty.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmldepartment.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmlcenter.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmlbuilding.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmllevel.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[8].Value.ToString();
                tmlrank.Text = gridmanagelectrer.Rows[e.RowIndex].Cells[9].Value.ToString();

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
            string sql = " delete from AddLecturer WHERE EmployeeID = '" + tmlid.Text + "'";
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
                MessageBox.Show("Please click the Edit button before deleting  !");
            }
        }

        private void bmlclear_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }
        public void ClearGrid()
        {
            tmlname.Text = "";
            tmlid.Text = "";
            cmlfaculty.SelectedIndex = -1;
            cmldepartment.SelectedIndex = -1;
            cmlcenter.SelectedIndex = -1;
            cmlbuilding.SelectedIndex = -1;
            cmllevel.SelectedIndex = -1;
            tmlrank.Text = "";
            cmlday.SelectedIndex = -1;
            cmlfrom.SelectedIndex = -1;
            cmlto.SelectedIndex = -1;
        }

        private void bmlupdate_Click(object sender, EventArgs e)
        {
            if (tmlid.Text.Length == 6)
            {
                ManageUpdate();
            }
            else
            {
                MessageBox.Show("Please check the Employee id ");
            }
        }
        public void ManageUpdate()
        {

            SqlConnection con = new SqlConnection(myconstring);
            string sql = " UPDATE AddLecturer SET LecturerName = '" + tmlname.Text + "', EmployeeID = '" + tmlid.Text + "', Faculty = '" + cmlfaculty.Text + "', Department = '" + cmldepartment.Text + "', Center = '" + cmlcenter.Text + "', Building = '" + cmlbuilding.Text + "', LecturerLevel = '" + cmllevel.Text + "', Rank = '" + tmlrank.Text + "' WHERE EmployeeID = '" + tmlid.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Updated");
                con.Close();
                TableLoad();
            }
            else
            {
                MessageBox.Show("Please check the Employee ID !");
            }

        }
        public void EditHours()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "Insert into AddHours(SelectDay,EmployeeID,HoursFrom,HoursTo) values ('" + cmlday.Text + "','" + tmlid.Text + "','" + cmlfrom.Text + "','" + cmlto.Text + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection = con;
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Edit Hours ");
                con.Close();
                EditTableHousLoad();


            }
            else
            {
                MessageBox.Show("Error for Edit");
            }
        }

        public void EditTableHousLoad()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "select SelectDay,HoursFrom,HoursTo from Addhours Where EmployeeID='" + tmlid.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adpter.Fill(ds);
            dt = ds.Tables[0];

            //Bind the fetched data to gridview
            dataGridView2.DataSource = dt;

        }

        private void tmlid_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tmlid.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tmlid.Text = tmlid.Text.Remove(tmlid.Text.Length - 1);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ManageGeneraterank();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditTableHousLoad();
        }

        private void bmledithours_Click(object sender, EventArgs e)
        {
            EditHours();
        }

        private void FormManageLecturer_Load(object sender, EventArgs e)
        {
            TableLoad();
        }

        private void FormManageLecturer_Load_1(object sender, EventArgs e)
        {
            TableLoad();
            EditTableHousLoad();
        }
    }
        
    
}
