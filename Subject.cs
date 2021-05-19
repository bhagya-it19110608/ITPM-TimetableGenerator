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

namespace WorkingHoursAndDays
{
    public partial class Subject : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        int subId;
        public Subject()
        {
            InitializeComponent();

        }
       

        public void registerSubject()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "Insert into AddSubject(OfferedYear,OfferedSemester,SubjectName,SubjectCode,LectureHours,TuteHours,LabHours,EvaluationHours) values ('" + casyear.Text + "','" + raddsemester.Text + "','" + name.Text + "','" + cascode.Text + "','" + upaslectureh.Text + "','" + upastuteh.Text + "','" + upaslabh.Text + "','" + upasevah.Text + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection = con;
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Subject is Registered");
                con.Close();
            }
            else
            {
                MessageBox.Show("Error for Registered");
            }
        }

        public void Clear()
        {
            casyear.SelectedIndex = -1;
            name.SelectedIndex = -1;
            cascode.Text = "";
            upaslectureh.Text = "";
            upastuteh.Text = "";
            upaslabh.Text = "";
            upasevah.Text = "";

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
             MessageBox.Show("Please check the Subject ID !");
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




private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
{

}

private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
{

}

private void form_Load(object sender, EventArgs e)
{

}



private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
{

}

private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
{

}

private void label4_Click(object sender, EventArgs e)
{

}

private void label2_Click(object sender, EventArgs e)
{

}

private void balgeneraterank_Click(object sender, EventArgs e)
{

}

private void panel2_Paint(object sender, PaintEventArgs e)
{

}

private void panel1_Paint(object sender, PaintEventArgs e)
{

}

private void lalname_Click(object sender, EventArgs e)
{

}

private void talname_TextChanged(object sender, EventArgs e)
{

}

private void lalid_Click(object sender, EventArgs e)
{

}

private void lalfaculty_Click(object sender, EventArgs e)
{

}

private void talid_TextChanged(object sender, EventArgs e)
{

}

private void calfaculty_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void caldepartment_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void lalcenter_Click(object sender, EventArgs e)
{

}

private void calcenter_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void lalbuilding_Click(object sender, EventArgs e)
{

}

private void lallevel_Click(object sender, EventArgs e)
{

}

private void lalrank_Click(object sender, EventArgs e)
{

}

private void calbuilding_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void callevel_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void talrank_TextChanged(object sender, EventArgs e)
{

}

private void balclear_Click(object sender, EventArgs e)
{

}

private void balsave_Click(object sender, EventArgs e)
{

}

private void lalavailblehours_Click(object sender, EventArgs e)
{

}

private void lalto_Click(object sender, EventArgs e)
{

}

private void lalday_Click(object sender, EventArgs e)
{

}

private void calday_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void calfrom_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void calto_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void baladdhours_Click(object sender, EventArgs e)
{

}


private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void lalname_Click_1(object sender, EventArgs e)
{

}

private void talname_TextChanged_1(object sender, EventArgs e)
{

}

private void balclear_Click_1(object sender, EventArgs e)
{
 Clear();
}



private void balsave_Click_1(object sender, EventArgs e)
{


registerSubject();
TableLoad();


}



private void label1_Click(object sender, EventArgs e)
{

}

private void tabmanagesubject_Click(object sender, EventArgs e)
{

}

private void tabmanagesubject_Click_1(object sender, EventArgs e)
{

}



private void cassemester_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void upaslectureh_SelectedItemChanged(object sender, EventArgs e)
{

}

private void raddsemester_CheckedChanged(object sender, EventArgs e)
{

}

private void bmsupdate_Click(object sender, EventArgs e)
{
            Update();
}

private void pictureBox2_Click(object sender, EventArgs e)
{

}

private void button1_Click(object sender, EventArgs e)
{

}

private void subjectdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}

        private void casyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bmsclear_Click(object sender, EventArgs e)
        {
            ManageClear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AddSessions f2 = new AddSessions();
            f2.ShowDialog();
        }
    }
}
