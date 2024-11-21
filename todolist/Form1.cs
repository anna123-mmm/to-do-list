using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    public partial class Form1 : Form
    {
        private Boolean showPanelTask = false;
        private List<CToDo> tdlist;
        public Form1()
        {
            InitializeComponent();
            tooglePanels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tdlist = new List<CToDo>();
            timer1.Start();
            dgvToDo.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvToDo.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            showPanelTask = !showPanelTask;
            lblStatus.Text = "TO DO LIST";
            tooglePanels();
        }

        private void tooglePanels()
        {
            if (showPanelTask)
            {
                panelTask.Height = 128;
            }
            else
            {
                panelTask.Height = 0;
            }

        }

        //public void showThisForm(object form)
        //{
        //    panel4.Controls.Clear();
        //    Form frm = form as Form;
        //    frm.TopLevel = false;
        //    panel4.Controls.Add(frm);
        //    panel4.Tag = form;
        //    frm.BringToFront();
        //    frm.Show();
        //}

        private void btnAll_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "TO DO LIST | ALL TASKS";
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "TO DO LIST | COMPLETED";
        }

        private void btnIncomplete_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "TO DO LIST | INCOMPLETE";
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "TO DO LIST | TARGET";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //hiện ngày trên form
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        //thêm
        public void AddDataToDataGridView(bool s, string t, DateTime sd, DateTime dd, string c, string dc)
        {
            dgvToDo.Rows.Add(s, t, sd, dd, c, dc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddTask f = new FrmAddTask(this);
            f.Show();
        }
    }
}
