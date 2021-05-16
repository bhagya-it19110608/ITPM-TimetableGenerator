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
    public partial class FormContentStudent : Form
    {
        public FormContentStudent()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void openContentStudent(Form contentStudent)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentStudent;
            contentStudent.TopLevel = false;
            contentStudent.FormBorderStyle = FormBorderStyle.None;
            contentStudent.Dock = DockStyle.Fill;
            panelContentStudent.Controls.Add(contentStudent);
            panelContentStudent.Tag = contentStudent;
            contentStudent.BringToFront();
            contentStudent.Show();
        }
        private void buttonStudentAddSession_Click(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(132, 136, 152))
                ((Control)sender).BackColor = Color.FromArgb(132, 136, 152);
            else
                ((Control)sender).BackColor = Color.FromArgb(143, 147, 164);
            openContentStudent(new FormStudentAddSession());
        }
    }
}
