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
    public partial class FormSessionExtendForLocation : Form
    {
        public FormSessionExtendForLocation()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void openContentLocationSessionContent(Form contentLocationSessionContent)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentLocationSessionContent;
            contentLocationSessionContent.TopLevel = false;
            contentLocationSessionContent.FormBorderStyle = FormBorderStyle.None;
            contentLocationSessionContent.Dock = DockStyle.Fill;
            panelContentLocationSessionContent.Controls.Add(contentLocationSessionContent);
            panelContentLocationSessionContent.Tag = contentLocationSessionContent;
            contentLocationSessionContent.BringToFront();
            contentLocationSessionContent.Show();
        }
        private void buttonLocationSessionNotAvailableTimes_Click(object sender, EventArgs e)
        {
            if (((Control)sender).ForeColor != Color.FromArgb(168, 168, 167))
                ((Control)sender).ForeColor = Color.FromArgb(168, 168, 167);
            else
                ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0);
            openContentLocationSessionContent(new FormLocationUnavailable());
        }
    }
}
