using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Member3
{
    public partial class FormContentSubject : Form
    {
        string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        string sql;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataSet ds;
        int subId;
        public FormContentSubject()
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



        private Form activeForm = null;

        private void openContentSubject(Form contentSubject)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentSubject;
            contentSubject.TopLevel = false;
            contentSubject.FormBorderStyle = FormBorderStyle.None;
            contentSubject.Dock = DockStyle.Fill;
            panelContentSubject.Controls.Add(contentSubject);
            panelContentSubject.Tag = contentSubject;
            contentSubject.BringToFront();
            contentSubject.Show();
        }

        private void buttonManageSubject_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentSubject(new FormManageSubject());
        }

        private void basclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bassave_Click(object sender, EventArgs e)
        {
            registerSubject();
        }
    }
}
