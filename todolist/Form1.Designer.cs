namespace todolist
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTask = new System.Windows.Forms.Panel();
            this.btnIncomplete = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTarget = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.btnTarget);
            this.panel1.Controls.Add(this.panelTask);
            this.panel1.Controls.Add(this.btnTask);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 594);
            this.panel1.TabIndex = 0;
            // 
            // panelTask
            // 
            this.panelTask.BackColor = System.Drawing.Color.Transparent;
            this.panelTask.Controls.Add(this.btnIncomplete);
            this.panelTask.Controls.Add(this.btnCompleted);
            this.panelTask.Controls.Add(this.btnAll);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask.Location = new System.Drawing.Point(0, 167);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(200, 128);
            this.panelTask.TabIndex = 4;
            // 
            // btnIncomplete
            // 
            this.btnIncomplete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncomplete.FlatAppearance.BorderSize = 0;
            this.btnIncomplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnIncomplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnIncomplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomplete.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomplete.ForeColor = System.Drawing.Color.White;
            this.btnIncomplete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncomplete.Location = new System.Drawing.Point(0, 84);
            this.btnIncomplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIncomplete.Name = "btnIncomplete";
            this.btnIncomplete.Size = new System.Drawing.Size(200, 42);
            this.btnIncomplete.TabIndex = 6;
            this.btnIncomplete.Text = "               Incomplete";
            this.btnIncomplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncomplete.UseVisualStyleBackColor = true;
            this.btnIncomplete.Click += new System.EventHandler(this.btnIncomplete_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompleted.FlatAppearance.BorderSize = 0;
            this.btnCompleted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnCompleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompleted.Location = new System.Drawing.Point(0, 42);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(200, 42);
            this.btnCompleted.TabIndex = 5;
            this.btnCompleted.Text = "               Completed";
            this.btnCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(0, 0);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(200, 42);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "               All";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 125);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "My ToDo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 63);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(210, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(657, 515);
            this.panel4.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(146)))));
            this.labelDate.Location = new System.Drawing.Point(520, 21);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 20);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTarget
            // 
            this.btnTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarget.FlatAppearance.BorderSize = 0;
            this.btnTarget.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnTarget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarget.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarget.ForeColor = System.Drawing.Color.White;
            this.btnTarget.Image = global::todolist.Properties.Resources.champion;
            this.btnTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarget.Location = new System.Drawing.Point(0, 295);
            this.btnTarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(200, 42);
            this.btnTarget.TabIndex = 5;
            this.btnTarget.Text = "            Target";
            this.btnTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarget.UseVisualStyleBackColor = true;
            // 
            // btnTask
            // 
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(210)))));
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.White;
            this.btnTask.Image = global::todolist.Properties.Resources.list;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.Location = new System.Drawing.Point(0, 125);
            this.btnTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(200, 42);
            this.btnTask.TabIndex = 3;
            this.btnTask.Text = "            Task";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::todolist.Properties.Resources.to_do_list;
            this.pictureBox1.Location = new System.Drawing.Point(22, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 594);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelTask.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Button btnIncomplete;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
    }
}

