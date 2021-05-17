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
    public partial class FormManageLocationUnavailableTime : Form
    {
        FormLocationUnavailable frmLc = new FormLocationUnavailable();
        
        public FormManageLocationUnavailableTime()
        {
            InitializeComponent();
        }

        private void buttonManageLocationTimeAddSession_Click(object sender, EventArgs e)
        {
            frmLc.Show();
        }
    }
}
