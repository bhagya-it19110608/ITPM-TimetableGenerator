using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkingHoursAndDays
{
    public partial class AddSessions : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        public AddSessions()
        {
            InitializeComponent();
        }


        public void registersessions()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "Insert into ManageSession(SelectLecturer,SelectTag,SelectedLecturer,SGroupIDMain,SGroupIDSub,SSubjectCode,SSubject,NoStudents,Duration) values ('" + comboBoxsl1.Text + "','" + comboBoxstag.Text + "','" + textBoxselectlect.Text + "','" + comboBoxaddmain.Text + "','" + comboBoxaddsub.Text + "','" + cbaddcode.Text + "','" + cbaddssub.Text + "','" + nupnos.Text + "','" + tbadddu.Text + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection = con;
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Session is Registered");
                con.Close();
            }
            else
            {
                MessageBox.Show("Error for Registered");
            }
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


        private void ClearStep1()
        {
            comboBoxsl1.SelectedIndex = -1;
            comboBoxstag.SelectedIndex = -1;
            textBoxselectlect.Text = "";
            
        }

        public void ClearStep2()
        {
            comboBoxaddmain.SelectedIndex = -1;
            comboBoxaddsub.SelectedIndex = -1;
            cbaddcode.SelectedIndex = -1;
            cbaddssub.SelectedIndex = -1;
            nupnos.Text = "";
            tbadddu.Text = "";
           
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
                MessageBox.Show("Please check the Subject ID !");
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


       /* private void search()
        {
            SqlConnection con = new SqlConnection(myconstring);
            //string sqlquery = "SELECT * FROM ManageSession WHERE SelectedLecturer = '" + textmanages.Text + "'";




            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ManageSession WHERE SelectedLecturer = '" + textmanages.Text + "'",con);

            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            // SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataaddmanage.DataSource = dt;
            con.Close();

        }*/

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void labelselectlect1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addtab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsgsubmit_Click(object sender, EventArgs e)
        {
            registersessions();
            TableLoadsessions();

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(1);
        }

        private void addslectclear_Click(object sender, EventArgs e)
        {
            ClearStep1();
        }

        private void btnsgclear_Click(object sender, EventArgs e)
        {
            ClearStep2();
        }

        private void addslectsave_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(1);
        }

        private void tpmsession_Click(object sender, EventArgs e)
        {

        }

        private void dataaddmanage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                cupdatesl1.Text = dataaddmanage.Rows[e.RowIndex].Cells[3].Value.ToString();
                cupdatetag.Text = dataaddmanage.Rows[e.RowIndex].Cells[4].Value.ToString();
                textupdatesl2.Text = dataaddmanage.Rows[e.RowIndex].Cells[5].Value.ToString();
                cupdatemain.Text = dataaddmanage.Rows[e.RowIndex].Cells[6].Value.ToString();
                cupdatesub.Text = dataaddmanage.Rows[e.RowIndex].Cells[7].Value.ToString();
                cupdatescode.Text = dataaddmanage.Rows[e.RowIndex].Cells[8].Value.ToString();
                cupdatesubject.Text = dataaddmanage.Rows[e.RowIndex].Cells[9].Value.ToString();
                nupdayenos.Text = dataaddmanage.Rows[e.RowIndex].Cells[10].Value.ToString();
                texupdated.Text = dataaddmanage.Rows[e.RowIndex].Cells[11].Value.ToString();

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
                MessageBox.Show("Please check the Fileds !");
            }
        }

        private void btnuupdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnaddback_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnaddsession_Click(object sender, EventArgs e)
        {
            addtab.SelectTab(0);
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

        private void textmanages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
