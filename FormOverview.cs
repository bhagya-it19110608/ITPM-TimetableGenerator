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
    public partial class FormOverview : Form
    {
        public FormOverview()
        {
            InitializeComponent();
        }

        private void buttonLecturer_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
            
            openContentForm(new FormContentLecturer());
        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
            openContentForm(new FormContentStudent());
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
            openContentForm(new FormContentLocation());
        }

        private void buttonTags_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }

        private void buttonSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
            openContentForm(new FormContentSession());
        }

        private void buttonDaysAndHours_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);

            openContentForm(new FormContentDaysAndHours());
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }
        private Form activeForm = null;

        private void openContentForm(Form contentForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentForm;
            contentForm.TopLevel = false;
            contentForm.FormBorderStyle = FormBorderStyle.None;
            contentForm.Dock = DockStyle.Fill;
            panelContentForm.Controls.Add(contentForm);
            panelContentForm.Tag = contentForm;
            contentForm.BringToFront();
            contentForm.Show();
        }
    }
}
