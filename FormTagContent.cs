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
    public partial class FormTagContent : Form
    {
        public FormTagContent()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void openContentTag(Form contentTag)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentTag;
            contentTag.TopLevel = false;
            contentTag.FormBorderStyle = FormBorderStyle.None;
            contentTag.Dock = DockStyle.Fill;
            panelContentTag.Controls.Add(contentTag);
            panelContentTag.Tag = contentTag;
            contentTag.BringToFront();
            contentTag.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int tagId;

        private void FormTagContent_Load(object sender, EventArgs e)
        {
            GetTagRecords();
        }
        private void GetTagRecords()
        {
            SqlCommand cmd = new SqlCommand("select * from Tags", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            //TagsdataGridView1.DataSource = dt;
        }

        private void AddTagsSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tags VALUES(@subjectName, @subjectCode, @relatedTag)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@subjectName", txtTagName.Text);
                cmd.Parameters.AddWithValue("@subjectCode", txtTagCode.Text);
                cmd.Parameters.AddWithValue("@relatedTag", comboTags.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Tag is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTagRecords();
                ResetFormControls();


            }
        }
        private bool IsValid()
        {
            if (txtTagName.Text == string.Empty)
            {
                MessageBox.Show("Tag Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTagCode.Text == string.Empty)
            {
                MessageBox.Show("Tag Code is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboTags.Text == string.Empty)
            {
                MessageBox.Show("Related Tag is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AddTagsClear_Click(object sender, EventArgs e)
        {
            ResetFormControls();            
        }
        private void ResetFormControls()
        {
            txtTagName.Clear();
            txtTagCode.Clear();
            comboTags.SelectedIndex = -1;

            txtTagName.Focus();
        }

        private void buttonManageTag_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentTag(new FormManageTags());
        }
    }
}
