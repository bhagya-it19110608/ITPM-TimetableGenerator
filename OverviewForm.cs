using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingHoursAndDays
{
    public partial class OverviewForm : Form
    {
        public OverviewForm()
        {
            InitializeComponent();
        }
    private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLecturer_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36,45,80);
        }

        private void buttonSubject_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }

        private void buttonStudent_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }

        private void buttonLocation_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }

        private void buttonTags_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }

        private void buttonSession_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }

        private void buttonDaysAndHours_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }

        private void buttonStatistics_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.FromArgb(28, 35, 63))
                ((Control)sender).BackColor = Color.FromArgb(28, 35, 63);
            else
                ((Control)sender).BackColor = Color.FromArgb(36, 45, 80);
        }
    }
}
