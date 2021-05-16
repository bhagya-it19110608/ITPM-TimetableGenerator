using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Member3
{
    public partial class FormContentLecturer : Form
    {
        public FormContentLecturer()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BLNS6C85\SQLEXPRESS;Initial Catalog=automated-timetable;Integrated Security=True");

        private Form activeForm = null;

        private void openContentLecturer(Form contentLecturer)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentLecturer;
            contentLecturer.TopLevel = false;
            contentLecturer.FormBorderStyle = FormBorderStyle.None;
            contentLecturer.Dock = DockStyle.Fill;
            panelContentLecturer.Controls.Add(contentLecturer);
            panelContentLecturer.Tag = contentLecturer;
            contentLecturer.BringToFront();
            contentLecturer.Show();
        }


        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentLecturer(new FormAddNotAvailableTimeOfLecturer());
            
        }

        private void panelLecturerContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
