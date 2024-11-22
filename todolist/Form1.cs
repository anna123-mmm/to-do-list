using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dgvToDo.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvToDo.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            LoadDataGridViewFromFile(dgvToDo, "todolist.txt");
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

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

      
        public void AddDataToDataGridView(bool s, string t, DateTime sd, DateTime dd, string c, string dc)
        {
            dgvToDo.Rows.Add(s, t, sd, dd, c, dc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddTask f = new FrmAddTask(this);
            f.Show();
        }

        
        public void saveFile(DataGridView dataGridView, string filePath)
        {
            using (StreamWriter writer = new StreamWriter("todolist.txt", false))
            {
                StringBuilder sb = new StringBuilder();

                
                foreach (DataGridViewRow row in dgvToDo.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value is bool boolValue)
                        {
                            
                            sb.Append(boolValue.ToString() + ",");
                        }
                        else if (cell.Value is DateTime dateTimeValue)
                        {
                            
                            sb.Append(dateTimeValue.ToString("dd/MM/yyyy") + ",");
                        }
                        else
                        {
                            
                            sb.Append(cell.Value?.ToString() + ",");
                        }
                    }
                    sb.AppendLine();
                }

                
                writer.Write(sb.ToString());
            }
        }

        private void LoadDataGridViewFromFile(DataGridView dataGridView, string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                dataGridView.Rows.Clear();

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    object[] rowData = new object[values.Length];

                    for (int i = 0; i < values.Length; i++)
                    {
                        
                        if (bool.TryParse(values[i], out bool boolValue))
                        {
                            
                            rowData[i] = boolValue;
                        }
                        else if (DateTime.TryParse(values[i], out DateTime dateTimeValue))
                        {
                            
                            rowData[i] = dateTimeValue;
                        }
                        else
                        {
                            
                            rowData[i] = values[i];
                        }
                    }
                    dataGridView.Rows.Add(values);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveFile(dgvToDo, "todolist.txt");
        }
    }
}
