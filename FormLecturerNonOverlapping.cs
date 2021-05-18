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
    public partial class FormLecturerNonOverlapping : Form
    {
        public FormLecturerNonOverlapping()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private void FormLecturerNonOverlapping_Load(object sender, EventArgs e)
        {
            GenerateNonOverlap();
        }
        private void GenerateNonOverlap()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LecturerNonOverlapping_tb", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
        }
        private void ResetDetails()
        {
            

            comboSub1.SelectedIndex = -1;
            comboSub2.SelectedIndex = -1;
            comboLec1.SelectedIndex = -1;
            comboLec2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValid2())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LecturerNonOverlapping_tb VALUES (@Lecturer_1, @Lecturer_2, @Tag, @Subject_1, @Subject_2)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturer_1", comboLec1.Text);
                cmd.Parameters.AddWithValue("@Lecturer_2", comboLec2.Text);
                cmd.Parameters.AddWithValue("@Tag", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Subject_1", comboSub1.Text);
                cmd.Parameters.AddWithValue("@Subject_2", comboSub2.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New record is successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateNonOverlap();
                ResetDetails();
            }
        }
        private bool IsValid2()
        {
            if (comboSub1.Text == string.Empty)
            {
                MessageBox.Show("Subject 1 is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboSub2.Text == string.Empty)
            {
                MessageBox.Show("Subject 2 is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboLec1.Text == string.Empty)
            {
                MessageBox.Show("Lecturer 1 is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboLec2.Text == string.Empty)
            {
                MessageBox.Show("Lecturer 2 is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Tag is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
