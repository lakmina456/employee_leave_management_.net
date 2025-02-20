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

namespace Employee_Leave
{

    public partial class EmployeeLeave_Employee : Form
    {
        Functions Con;
        public EmployeeLeave_Employee()
        {
            InitializeComponent();
            Con = new Functions();
            Show_Employee_Leaves();
            label1.Text = "Manage Leaves " + "[Employee ID:" + Login.EmpId + " " + Login.EmpName + "]";
            textBox1.Text = Login.EmpName;
            //GetEmployees();
            GetCategories();
        }
        private void Show_Employee_Leaves()
        {

            string Query = "select LId,Employee, Leave_Reason, DateStart, DateEnd, AppliedDate, Status from Leave where Employee='{0}'";
            Query = string.Format(Query, Login.EmpId);


            dataGridView1.DataSource = Con.GetData(Query);
            dataGridView1.Columns["LId"].HeaderText = "Leave ID";
            dataGridView1.Columns["Employee"].HeaderText = "Employee ID";
            dataGridView1.Columns["Leave_Reason"].HeaderText = "Reason for Leave";
            dataGridView1.Columns["DateStart"].HeaderText = "Start Date";
            dataGridView1.Columns["DateEnd"].HeaderText = "End Date";
            dataGridView1.Columns["AppliedDate"].HeaderText = "Date Applied";
            dataGridView1.Columns["Status"].HeaderText = "Approval Status";


        }
        private void FilterLeaves()
        {
            string Query = "select * from Leave where Status = '{0}' and Employee='{1}'";
            Query = string.Format(Query, comboBox4.SelectedItem.ToString(), Login.EmpId);
            dataGridView1.DataSource = Con.GetData(Query);
        }
        private void GetEmployees()
        {
            //String Query = "select * from Employee";
            //comboBox1.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            //comboBox1.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            //comboBox1.DataSource = Con.GetData(Query);

        }
        private void GetCategories()
        {
            String Query = "select * from Category";
            comboBox2.DisplayMember = Con.GetData(Query).Columns["CatName"].ToString();
            comboBox2.ValueMember = Con.GetData(Query).Columns["CatId"].ToString();
            comboBox2.DataSource = Con.GetData(Query);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try

            {
                if (textBox1.Text == "" || comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");

                }
                else
                {
                    int name = Login.EmpId;
                    int category = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                    string dateStart = dateTimePicker1.Value.Date.ToString();
                    string dateEnd = dateTimePicker2.Value.Date.ToString();
                    string dateApplied = DateTime.Today.Date.ToString();
                    //string status = comboBox3.SelectedItem.ToString();
                    String status = "Pending";

                    string Query = "insert into Leave (Employee, Leave_Reason, DateStart, DateEnd, AppliedDate, Status) values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, name, category, dateStart, dateEnd, dateApplied, status);
                    Con.SetData(Query);
                    Show_Employee_Leaves();
                    MessageBox.Show("Leave Insert Successfully");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells.Count > 1)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                if (textBox1.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                if (textBox1.Text == "" || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");

                }
                else
                {
                    int name = Login.EmpId;
                    int category = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                    string dateStart = dateTimePicker1.Value.Date.ToString();
                    string dateEnd = dateTimePicker2.Value.Date.ToString();
                    string dateApplied = DateTime.Today.Date.ToString();
                    //string status = comboBox3.SelectedItem.ToString();
                    String status = "Pending";


                    string Query = "update Leave set Employee= '{0}',Leave_Reason= '{1}',DateStart= '{2}',DateEnd= '{3}',Status= '{4}' where LId = {5}";
                    Query = string.Format(Query, name, category, dateStart, dateEnd, status, key);
                    Con.SetData(Query);
                    Show_Employee_Leaves();
                    MessageBox.Show("Leave Updated Successfully");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    // Show confirmation dialog
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        string Query = "DELETE FROM Leave WHERE LId = {0}";
                        Query = string.Format(Query, key);
                        Con.SetData(Query);
                        Show_Employee_Leaves();
                        MessageBox.Show("Leave Deleted Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FilterLeaves();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeLeave_Employee_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reasons obj = new Reasons();
            obj.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DashBoard_Employee obj = new DashBoard_Employee();
            obj.Show();
        }
    }
}
