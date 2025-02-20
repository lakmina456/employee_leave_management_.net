namespace Employee_Leave
{
    partial class EmployeeLeave_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLeave_Admin));
            button6 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            comboBox4 = new ComboBox();
            button7 = new Button();
            button8 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(897, 242);
            button6.Name = "button6";
            button6.Size = new Size(125, 29);
            button6.TabIndex = 37;
            button6.Text = "Leave Reasons";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 95);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 33;
            label7.Text = "Leaves List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(724, 389);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 28;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(723, 345);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 27;
            label5.Text = "Date End:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(724, 286);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 26;
            label4.Text = "Date Start:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(724, 212);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 25;
            label3.Text = "Categories:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(723, 165);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 24;
            label2.Text = "Employees:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(365, 38);
            label1.TabIndex = 23;
            label1.Text = "Manage Employees Leaves";
            // 
            // button3
            // 
            button3.Location = new Point(24, 540);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 22;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(824, 436);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 20;
            button1.Text = "Save Leave Status";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pending", "Approved", "Rejected" });
            comboBox3.Location = new Point(824, 386);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(198, 28);
            comboBox3.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(824, 286);
            dateTimePicker1.MinDate = new DateTime(2025, 1, 16, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(198, 27);
            dateTimePicker1.TabIndex = 41;
            dateTimePicker1.Value = new DateTime(2025, 1, 17, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(824, 338);
            dateTimePicker2.MinDate = new DateTime(2025, 1, 17, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(198, 27);
            dateTimePicker2.TabIndex = 42;
            dateTimePicker2.Value = new DateTime(2025, 1, 17, 10, 15, 22, 0);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 142);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(676, 378);
            dataGridView1.TabIndex = 55;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Pending", "Approved", "Rejected" });
            comboBox4.Location = new Point(143, 99);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(171, 28);
            comboBox4.TabIndex = 56;
            // 
            // button7
            // 
            button7.Location = new Point(336, 98);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 57;
            button7.Text = "Refresh";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(941, 12);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 60;
            button8.Text = "[Logout]";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            linkLabel1.Location = new Point(474, 27);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(283, 25);
            linkLabel1.TabIndex = 63;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Manage Employees and Admins";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            linkLabel2.Location = new Point(774, 27);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(146, 25);
            linkLabel2.TabIndex = 64;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Resons";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(824, 162);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 65;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(824, 209);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 66;
            // 
            // EmployeeLeave_Admin
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 581);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(comboBox4);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EmployeeLeave_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Leaves";
            Load += EmployeeLeave_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button1;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private ComboBox comboBox4;
        private Button button7;
        private Button button8;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}