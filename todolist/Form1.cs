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
        public Form1()
        {
            InitializeComponent();
            tooglePanels();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            showPanelTask = !showPanelTask;

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

        public void showThisForm(object form)
        {
            panel4.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            panel4.Tag = form;
            frm.BringToFront();
            frm.Show();
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            showThisForm(new frmCompleted());
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            showThisForm(new FrmAllTask());
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            showThisForm(new frmCompleted());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnIncomplete_Click(object sender, EventArgs e)
        {
            showThisForm(new frmIncomplete());
        }
    }
}
