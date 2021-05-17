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
    public partial class FormContentLocation : Form
    {
        public FormContentLocation()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void openContentLocation(Form contentLocation)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentLocation;
            contentLocation.TopLevel = false;
            contentLocation.FormBorderStyle = FormBorderStyle.None;
            contentLocation.Dock = DockStyle.Fill;
            panelContentLocation.Controls.Add(contentLocation);
            panelContentLocation.Tag = contentLocation;
            contentLocation.BringToFront();
            contentLocation.Show();
        }

        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentLocation(new FormSessionExtendForLocation());
        }
    }
}
