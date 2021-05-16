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
    public partial class FormContentSession : Form
    {
        public FormContentSession()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

       private void openContentSession(Form contentSession)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentSession;
            contentSession.TopLevel = false;
            contentSession.FormBorderStyle = FormBorderStyle.None;
            contentSession.Dock = DockStyle.Fill;
            panelContentSession.Controls.Add(contentSession);
            panelContentSession.Tag = contentSession;
            contentSession.BringToFront();
            contentSession.Show();
        }



        private void buttonSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);

            openContentSession(new FormSessionExtend());
        }
    }
}
