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
    public partial class FormLocationManage : Form
    {
        public FormLocationManage()
        {
            InitializeComponent();
        }
        string Type;
        int ID;
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private void FormLocationManage_Load(object sender, EventArgs e)
        {
            GetLocationRecord();
        }
        private void GetLocationRecord()
        {


            SqlCommand cmd = new SqlCommand("Select * from Location", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            LocationGridView.DataSource = dt;

            

        }

        private void LocationGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(LocationGridView.SelectedRows[0].Cells[0].Value);
            comboBox2.Text = LocationGridView.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = LocationGridView.SelectedRows[0].Cells[2].Value.ToString();
            radioButton4.Text = LocationGridView.SelectedRows[0].Cells[3].Value.ToString();
            numericUpDown1.Text = LocationGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Location SET Building = @Building, Room = @Room , Room_Type = @Room_Type, Capacity = @Capacity WHERE ID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Building", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Room", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Room_Type", radioButton4.Text);
                cmd.Parameters.AddWithValue("@Capacity ", numericUpDown1.Text);
                cmd.Parameters.AddWithValue("@ID", this.ID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Location is Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLocationRecord();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Pleace select a row", "select ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Location WHERE ID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.ID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Location details Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetLocationRecord();
                ResetDetails();
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "selet?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetDetails()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            numericUpDown1.ResetText();


        }

    }
}
