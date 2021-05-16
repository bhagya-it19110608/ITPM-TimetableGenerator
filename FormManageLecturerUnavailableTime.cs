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
    public partial class FormManageLecturerUnavailableTime : Form
    {
        FormLecturerUnavailable frmLec = new FormLecturerUnavailable();
        public FormManageLecturerUnavailableTime()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void openContentUnavailableTime(Form contentUnavailableTime)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentUnavailableTime;
            contentUnavailableTime.TopLevel = false;
            contentUnavailableTime.FormBorderStyle = FormBorderStyle.None;
            contentUnavailableTime.Dock = DockStyle.Fill;
            panelContentUnavailableTime.Controls.Add(contentUnavailableTime);
            panelContentUnavailableTime.Tag = contentUnavailableTime;
            contentUnavailableTime.BringToFront();
            contentUnavailableTime.Show();
        }
        private void buttonManageLecTimeAllocation_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(53, 66, 119))
                ((Control)sender).BackColor = Color.FromArgb(53, 66, 119);
            else
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
        }

        private void buttonManageStudentTimeAllocation_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(53, 66, 119))
                ((Control)sender).BackColor = Color.FromArgb(53, 66, 119);
            else
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            openContentUnavailableTime(new FormManageStudentUnavailableTime());
        }

        private void buttonManageLocationAllocation_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(53, 66, 119))
                ((Control)sender).BackColor = Color.FromArgb(53, 66, 119);
            else
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
        }

        private void buttonManageLecturerTimeAddSession_Click(object sender, EventArgs e)
        {
            frmLec.Show();
        }
    }
}
