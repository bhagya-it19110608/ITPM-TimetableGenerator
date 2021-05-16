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
    public partial class FormManageStudentUnavailableTime : Form
    {
        FormStudentAddSession frmStu = new FormStudentAddSession();
        public FormManageStudentUnavailableTime()
        {
            InitializeComponent();
        }

        private void buttonManageStudentTimeAddSession_Click(object sender, EventArgs e)
        {
            frmStu.Show();
        }
    }
}
