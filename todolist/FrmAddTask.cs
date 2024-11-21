using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace todolist
{
    public partial class FrmAddTask : Form
    {
        private Form1 form1;
        public FrmAddTask(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool status = false;
            string task = txtTask.Text;
            DateTime startdate = dtStartDate.Value;
            DateTime duedate = dtDueDate.Value;
            string category = txtCategory.Text;
            string description = txtDescription.Text;

            form1.AddDataToDataGridView(status, task, startdate, duedate, category, description);
            this.Close();
        }
    }
}
