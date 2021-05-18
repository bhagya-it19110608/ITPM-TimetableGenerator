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
    public partial class FormManageTags : Form
    {
        public FormManageTags()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");
        public int tagId;
        private void FormManageTags_Load(object sender, EventArgs e)
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

            TagsdataGridView1.DataSource = dt;
        }

        private void TagsdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tagId = Convert.ToInt32(TagsdataGridView1.SelectedRows[0].Cells[0].Value);
            tagName.Text = TagsdataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tagCode.Text = TagsdataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboTags2.Text = TagsdataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void updateTag_Click(object sender, EventArgs e)
        {

            if (tagId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tags SET subjectName = @subjectName, subjectCode = @subjectCode, relatedTag = @relatedTag WHERE tagId = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@subjectName", tagName.Text);
                cmd.Parameters.AddWithValue("@subjectCode", tagCode.Text);
                cmd.Parameters.AddWithValue("@relatedTag", comboTags2.Text);
                cmd.Parameters.AddWithValue("@ID", this.tagId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Tag information is updated successfully saved in the database", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetTagRecords();
                ResetFormControls2();
            }
            else
            {
                MessageBox.Show("Please select the row, to update details", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTag_Click(object sender, EventArgs e)
        {
            ResetFormControls2();
        }
        private void ResetFormControls2()
        {
            tagName.Clear();
            tagCode.Clear();
            comboTags2.SelectedIndex = -1;

            tagName.Focus();
        }
    }
}
