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
    public partial class FormSessionAddSessionExtend : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        public FormSessionAddSessionExtend()
        {
            InitializeComponent();
        }
        public void registersessions()
        {
            SqlConnection con = new SqlConnection(myconstring);
            string sql = "Insert into ManageSession(SelectLecturer,SelectTag,SelectedLecturer) values ('" + comboBoxsl1.Text + "','" + comboBoxstag.Text + "','" + textBoxselectlect.Text + "')";

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
        private void ClearStep1()
        {
            comboBoxsl1.SelectedIndex = -1;
            comboBoxstag.SelectedIndex = -1;
            textBoxselectlect.Text = "";

        }

        private void panelContentSessionContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
