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
    public partial class FormAddNotAvailableTimeOfLecturer : Form
    {
        public FormAddNotAvailableTimeOfLecturer()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openContentLecturerContent(Form contentLecturerContent)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentLecturerContent;
            contentLecturerContent.TopLevel = false;
            contentLecturerContent.FormBorderStyle = FormBorderStyle.None;
            contentLecturerContent.Dock = DockStyle.Fill;
            panelContentLecturerContent.Controls.Add(contentLecturerContent);
            panelContentLecturerContent.Tag = contentLecturerContent;
            contentLecturerContent.BringToFront();
            contentLecturerContent.Show();
        }

        private void buttonLecturerNotAvailableTimes_Click(object sender, EventArgs e)
        {
            if (((Control)sender).ForeColor != Color.FromArgb(168, 168, 167))
                ((Control)sender).ForeColor = Color.FromArgb(168, 168, 167);
            else
                ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0);

            openContentLecturerContent(new FormLecturerUnavailable());
        }
    }
}
