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
    public partial class FormManageSessionLecturer : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        public FormManageSessionLecturer()
        {
            InitializeComponent();
        }
        public void TableLoadsessions()
        {

            SqlConnection con = new SqlConnection(myconstring);
            string sql = "select SelectLecturer,SelectTag,SelectedLecturer,SGroupIDMain,SGroupIDSub,SSubjectCode,SSubject,NoStudents,Duration from ManageSession";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adpter.Fill(ds);
            dt = ds.Tables[0];

            //Bind the fetched data to gridview
            dataaddmanage.DataSource = dt;



            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();
            {

                editbutton.FlatStyle = FlatStyle.Popup;

                editbutton.HeaderText = "Action";
                editbutton.Name = "Edit";
                editbutton.UseColumnTextForButtonValue = true;


                editbutton.Text = "Edit";

                editbutton.Width = 60;

                if (dataaddmanage.Columns.Contains(editbutton.Name = "Edit"))
                {

                }
                else
                {
                    dataaddmanage.Columns.Add(editbutton);
                }
            }

            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();
            {

                deletebutton.FlatStyle = FlatStyle.Popup;

                deletebutton.HeaderText = "Action";
                deletebutton.Name = "Delete";
                deletebutton.UseColumnTextForButtonValue = true;
                deletebutton.Text = "Delete";

                deletebutton.Width = 60;

                if (dataaddmanage.Columns.Contains(deletebutton.Name = "Delete"))
                {

                }
                else
                {
                    dataaddmanage.Columns.Add(deletebutton);
                }

            }

        }
        public void Update()
        {


            SqlConnection con = new SqlConnection(myconstring);
            string sql = " UPDATE ManageSession SET SelectLecturer = '" + cupdatesl1.Text + "', SelectTag = '" + cupdatetag.Text + "', SelectedLecturer = '" + textupdatesl2.Text + "', SGroupIDMain = '" + cupdatemain.Text + "', SGroupIDSub = '" + cupdatesub.Text + "', SSubjectCode = '" + cupdatescode.Text + "', SSubject = '" + cupdatesubject.Text + "', NoStudents = '" + nupdayenos.Text + "', Duration = '" + texupdated.Text + "' WHERE SelectedLecturer = '" + textupdatesl2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int rows = cmd.ExecuteNonQuery();


            if (rows > 0)
            {
                MessageBox.Show("Updated");

                con.Close();
                TableLoadsessions();
            }

            else
            {
                MessageBox.Show("Lecturer Name cannot be updated. !");
            }
        }
        public void Clearupdate()
        {
            cupdatesl1.SelectedIndex = -1;
            cupdatetag.SelectedIndex = -1;
            textupdatesl2.Text = "";
            cupdatemain.SelectedIndex = -1;
            cupdatesub.SelectedIndex = -1;
            cupdatescode.SelectedIndex = -1;
            cupdatesubject.SelectedIndex = -1;
            nupdayenos.Text = "";
            texupdated.Text = "";
        }
        public void Clearsearch()
        {
            searchdrop.SelectedIndex = -1;
        }

        private void FormManageSessionLecturer_Load(object sender, EventArgs e)
        {
            TableLoadsessions();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(1);
        }

        private void dataaddmanage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                cupdatesl1.Text = dataaddmanage.Rows[e.RowIndex].Cells[2].Value.ToString();
                cupdatetag.Text = dataaddmanage.Rows[e.RowIndex].Cells[3].Value.ToString();
                textupdatesl2.Text = dataaddmanage.Rows[e.RowIndex].Cells[4].Value.ToString();
                cupdatemain.Text = dataaddmanage.Rows[e.RowIndex].Cells[5].Value.ToString();
                cupdatesub.Text = dataaddmanage.Rows[e.RowIndex].Cells[6].Value.ToString();
                cupdatescode.Text = dataaddmanage.Rows[e.RowIndex].Cells[7].Value.ToString();
                cupdatesubject.Text = dataaddmanage.Rows[e.RowIndex].Cells[8].Value.ToString();
                nupdayenos.Text = dataaddmanage.Rows[e.RowIndex].Cells[9].Value.ToString();
                texupdated.Text = dataaddmanage.Rows[e.RowIndex].Cells[10].Value.ToString();

            }
            else if (e.ColumnIndex == 1)
            {

                Delete();

            }
            TableLoadsessions();
        }
        private void Delete()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = " delete from  ManageSession WHERE SelectedLecturer = '" + textupdatesl2.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Deleted");
                con.Close();
                TableLoadsessions();
            }
            else
            {
                MessageBox.Show("Please chick the edit button to your changes !");
            }
        }

        private void btnuupdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnaddsession_Click(object sender, EventArgs e)
        {
            FormSessionTab frmst = new FormSessionTab(); 
            frmst.Show();
        }

        private void btnupdateclear_Click(object sender, EventArgs e)
        {
            Clearupdate();
        }

        private void bsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "select * from ManageSession where SelectLecturer   = '" + searchdrop.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adpter.Fill(ds);
            dt = ds.Tables[0];

            //Bind the fetched data to gridview
            dataaddmanage.DataSource = dt;
        }

        private void brefresh_Click(object sender, EventArgs e)
        {
            Clearsearch();
            TableLoadsessions();
        }
    }
}
