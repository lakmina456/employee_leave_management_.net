using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Leave
{
    public partial class DashBoard_Employee : Form
    {
        Functions Con;
        public DashBoard_Employee()
        {
            InitializeComponent();
            Con = new Functions();
            label12.Text = "Welcome,"+ Login.EmpName;
            label2.Text = Login.EmpId + "";
            label4.Text = Login.EmpName;
            label5.Text = Login.gender;
            label8.Text = Login.phone;
            label10.Text = Login.address;
            ShowLeaves();
            
        }
        private void ShowLeaves()
        {
            try
            {
                string Query = "select * from Leave where Employee = {0}";
                Query = string.Format(Query, Login.EmpId.ToString());
                dataGridView1.DataSource = Con.GetData(Query);

                string Query2 = "select count(*) from Leave where Employee = {0} and Status = 'approved'";
                Query2 = string.Format(Query2, Login.EmpId.ToString());
                if (Con.ExecuteQuery(Query2) == "0")
                {
                    label14.Text = "Approved [0]";
                }
                else
                {
                    label14.Text = "Approved [" + Con.ExecuteQuery(Query2) + "]";
                }
                

                string Query3 = "select count(*) from Leave where Employee = {0} and Status = 'pending'";
                Query3 = string.Format(Query2, Login.EmpId.ToString());
                if (Con.ExecuteQuery(Query3) == "0")
                {
                    label15.Text = "Pending [0]";
                }
                else
                {
                    label15.Text = "Pending [" + Con.ExecuteQuery(Query3) + "]";
                }
                

                string Query4 = "select count(*) from Leave where Employee = {0} and Status = 'rejected'";
                Query4 = string.Format(Query2, Login.EmpId.ToString());
                if (Con.ExecuteQuery(Query4) == "0")
                {
                    label13.Text = "Rejected [0]";
                }
                else
                {
                    label13.Text = "Rejected [" + Con.ExecuteQuery(Query4) + "]";
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
       
        private void ShowDetails()
        {
            try
            {
                string Query = "select * from Leave where Employee = {0}";
                Query = string.Format(Query, Login.EmpId);
                dataGridView1.DataSource = Con.GetData(Query);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void ViewLeaves_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeLeave_Employee obj = new EmployeeLeave_Employee();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reasons obj = new Reasons();
            obj.Show();
            this.Hide();
        }
    }
}
