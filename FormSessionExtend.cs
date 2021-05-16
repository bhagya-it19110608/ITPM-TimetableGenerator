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
    public partial class FormSessionExtend : Form
    {
        public FormSessionExtend()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openContentSessionContent(Form contentSessionContent)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentSessionContent;
            contentSessionContent.TopLevel = false;
            contentSessionContent.FormBorderStyle = FormBorderStyle.None;
            contentSessionContent.Dock = DockStyle.Fill;
            panelContentSessionContent.Controls.Add(contentSessionContent);
            panelContentSessionContent.Tag = contentSessionContent;
            contentSessionContent.BringToFront();
            contentSessionContent.Show();
        }

        private void buttonSessionNotAvailableTimes_Click(object sender, EventArgs e)
        {
            if (((Control)sender).ForeColor != Color.FromArgb(168, 168, 167))
                ((Control)sender).ForeColor = Color.FromArgb(168, 168, 167);
            else
                ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0);

           openContentSessionContent(new FormManageLecturerUnavailableTime());
        }
    }
}
