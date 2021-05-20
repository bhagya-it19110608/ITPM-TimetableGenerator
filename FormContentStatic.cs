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
    public partial class FormContentStatic : Form
    {
        public FormContentStatic()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "Lecturer hall";
            chart1.Series[0].YValueMembers = "Lecturer hall";

            chart1.Series[1].XValueMember = "Labs";
            chart1.Series[1].YValueMembers = "Labs";

            chart1.DataSource = _automated_timetableDataSet3.mydb;
            chart1.DataBind();
        }

        private void FormContentStatic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_automated_timetableDataSet3.mydb' table. You can move, or remove it, as needed.
            this.mydbTableAdapter3.Fill(this._automated_timetableDataSet3.mydb);
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
