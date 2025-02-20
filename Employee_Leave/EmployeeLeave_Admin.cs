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

    public partial class EmployeeLeave_Admin : Form
    {
        Functions Con;
        public EmployeeLeave_Admin()
        {
            InitializeComponent();
            Con = new Functions();
            Show_Employee_Leaves();
            label1.Text = "Manage Leaves " + "[Admin:" + Login.EmpName + "]";
            GetEmployees();
            GetCategories();
        }
        private void Show_Employee_Leaves()
        {
            string Query = "select * from Leave";
            dataGridView1.DataSource = Con.GetData(Query);

            dataGridView1.Columns["Employee"].HeaderText = "Employee ID";
            dataGridView1.Columns["Leave_Reason"].HeaderText = "Reason for Leave";
            dataGridView1.Columns["DateStart"].HeaderText = "Start Date";
            dataGridView1.Columns["DateEnd"].HeaderText = "End Date";
            dataGridView1.Columns["AppliedDate"].HeaderText = "Date Applied";
            dataGridView1.Columns["Status"].HeaderText = "Approval Status";
        }
        private void FilterLeaves()
        {
            string Query = "select * from Leave where Status = '{0}'";
            Query = string.Format(Query, comboBox4.SelectedItem.ToString());
            dataGridView1.DataSource = Con.GetData(Query);
        }
        private void GetEmployees()
        {
            //String Query = "select * from Employee";
            //textBox1.Text = Con.GetData(Query).Columns["EmpName"].ToString();
            //textBox2.Text = Con.GetData(Query).Columns["EmpId"].ToString();
            //textBox1.Text = Con.GetData(Query);

        }
        private void GetCategories()
        {
           // String Query = "select * from Category";
            //comboBox2.DisplayMember = Con.GetData(Query).Columns["CatName"].ToString();
           // comboBox2.ValueMember = Con.GetData(Query).Columns["CatId"].ToString();
            //comboBox2.DataSource = Con.GetData(Query);

        }

        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells.Count > 1)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                if (textBox1.Text=="")
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
                if (textBox1.Text=="" || textBox2.Text == "" || comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");

                }
                else
                {
                    int name = Convert.ToInt32(textBox1.Text.ToString());
                    int category = Convert.ToInt32(textBox2.Text.ToString());
                    string dateStart = dateTimePicker1.Value.Date.ToString();
                    string dateEnd = dateTimePicker2.Value.Date.ToString();
                    string dateApplied = DateTime.Today.Date.ToString();
                    string status = comboBox3.SelectedItem.ToString();
                    //String status = "Pending";


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
                if (textBox1.Text=="" || textBox2.Text == "" || comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                }
                else
                {

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
                        MessageBox.Show("Leave Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FilterLeaves();
        }

        private void EmployeeLeave_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashBoard_Admin obj = new DashBoard_Admin();
            obj.Show();
            this.Hide();
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

        private void button5_Click_1(object sender, EventArgs e)
        {
                    }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard_Admin obj = new DashBoard_Admin();
            obj.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reasons obj = new Reasons();
            obj.ShowDialog();
        }
    }
}
