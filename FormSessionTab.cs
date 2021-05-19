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
    public partial class FormSessionTab : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        public FormSessionTab()
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
            //dataaddmanage.DataSource = dt;

            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();
            {

                editbutton.FlatStyle = FlatStyle.Popup;

                editbutton.HeaderText = "Action";
                editbutton.Name = "Edit";
                editbutton.UseColumnTextForButtonValue = true;


                editbutton.Text = "Edit";

                editbutton.Width = 60;

              //  if (dataaddmanage.Columns.Contains(editbutton.Name = "Edit"))
                //{

                //}
                //else
                //{
                  //  dataaddmanage.Columns.Add(editbutton);
                //}
            }
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();
            {

                deletebutton.FlatStyle = FlatStyle.Popup;

                deletebutton.HeaderText = "Action";
                deletebutton.Name = "Delete";
                deletebutton.UseColumnTextForButtonValue = true;
                deletebutton.Text = "Delete";

                deletebutton.Width = 60;

                //if (dataaddmanage.Columns.Contains(deletebutton.Name = "Delete"))
                //{

                //}
                //else
                //{
                  //  dataaddmanage.Columns.Add(deletebutton);
                //}

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

        private void btnsgsubmit_Click(object sender, EventArgs e)
        {
            registersessions();
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

        private void btnaddback_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

    }
}
