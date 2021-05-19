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
    public partial class FormManageSubject : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        int subId;
        public FormManageSubject()
        {
            InitializeComponent();
        }
        public void ManageClear()
        {
            cmsyear.SelectedIndex = -1;
            cmsname.SelectedIndex = -1;
            cmscode.Text = "";
            upmslectureh.Text = "";
            upmstuteh.Text = "";
            upmslabh.Text = "";
            upmsevaluationh.Text = "";

        }

        public void TableLoad()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "select SubjectID,OfferedYear,OfferedSemester,SubjectName,SubjectCode,LectureHours,TuteHours,LabHours,EvaluationHours from AddSubject";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adpter.Fill(ds);
            dt = ds.Tables[0];

            //Bind the fetched data to gridview
            subjectdataGridView1.DataSource = dt;



            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();

            editbutton.FlatStyle = FlatStyle.Popup;

            editbutton.HeaderText = "Action";
            editbutton.Name = "Edit";
            editbutton.UseColumnTextForButtonValue = true;


            editbutton.Text = "Edit";

            editbutton.Width = 60;

            if (subjectdataGridView1.Columns.Contains(editbutton.Name = "Edit"))
            {

            }
            else
            {
                subjectdataGridView1.Columns.Add(editbutton);
            }
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;

            deletebutton.HeaderText = "Action";
            deletebutton.Name = "Delete";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Delete";

            deletebutton.Width = 60;

            if (subjectdataGridView1.Columns.Contains(deletebutton.Name = "Delete"))
            {

            }
            else
            {
                subjectdataGridView1.Columns.Add(deletebutton);
            }


        }
        public void Update()
        {


            SqlConnection con = new SqlConnection(myconstring);
            string sql = " UPDATE AddSubject SET OfferedYear = '" + cmsyear.Text + "', OfferedSemester = '" + radioButton2.Text + "', SubjectName = '" + cmsname.Text + "', SubjectCode = '" + cmscode.Text + "', LectureHours = '" + upmslectureh.Text + "', TuteHours = '" + upmstuteh.Text + "', LabHours = '" + upmslabh.Text + "', EvaluationHours = '" + upmsevaluationh.Text + "' WHERE SubjectCode = '" + cmscode.Text + "'";
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
                MessageBox.Show("Please click the Edit option before delete !");
            }

            /*SqlConnection con = new SqlConnection(myconstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateSubject", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subjectId", subId);
            cmd.Parameters.AddWithValue("@Offered_Year", cmsyear.Text.Trim());
            cmd.Parameters.AddWithValue("@Offered_Semester", radioButton2.Text.Trim());
            cmd.Parameters.AddWithValue("@Subject_Name", cmsname.Text.Trim());
            cmd.Parameters.AddWithValue("@Subject_Code", cmscode.Text.Trim());
            cmd.Parameters.AddWithValue("@Lecture_Hours", upmslectureh.Text.Trim());
            cmd.Parameters.AddWithValue("@Tute_Hours", upmstuteh.Text.Trim());
            cmd.Parameters.AddWithValue("@Lab_Hours", upmslabh.Text.Trim());
            cmd.Parameters.AddWithValue("@Evaluation_Hours", upmsevaluationh.Text.Trim());
            int rows = cmd.ExecuteNonQuery();

            con.Close();
            TableLoad();
            MessageBox.Show("Updated");*/

            /* if (rows > 0)
             {
                 MessageBox.Show("Updated");

                 con.Close();
                 TableLoad();
             }
             else
             {
                 MessageBox.Show("Please check the Subject ID !");
             }*/


        }




        private void FormManageSubject_Load(object sender, EventArgs e)
        {
            TableLoad();
        }

        private void subjectdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //SubjectID = Convert.ToInt32(subjectdataGridView1.Rows[e.RowIndex].Cells[0].Value);
                cmsyear.Text = subjectdataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                radioButton2.Text = subjectdataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmsname.Text = subjectdataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmscode.Text = subjectdataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                upmslectureh.Text = subjectdataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                upmstuteh.Text = subjectdataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                upmslabh.Text = subjectdataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                upmsevaluationh.Text = subjectdataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            else if (e.ColumnIndex == 1)
            {

                Delete();
            }
        }
        private void Delete()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = " delete from AddSubject WHERE SubjectCode = '" + cmscode.Text + "'";
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
                MessageBox.Show("Please check the Subject Code !");
            }
        }

        private void bmsclear_Click(object sender, EventArgs e)
        {
            ManageClear();
        }

        private void bmsupdate_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
