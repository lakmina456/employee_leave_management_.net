using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Employee_Leave
{
    public partial class DashBoard_Admin : Form
    {
        Functions Con;
        public DashBoard_Admin()
        {
            InitializeComponent();
            Con = new Functions();
            label1.Text = "Welcome,Admin " + "[ID:" + Login.EmpId + " " + Login.EmpName + "]";
            ShowEmployees();
        }
        private void ShowEmployees()
        {
            string Query = "select * from Employee";
            dataGridView1.DataSource = Con.GetData(Query);
        }
        private void ShowAdmin()
        {
            string Query = "select * from Admin";
            dataGridView1.DataSource = Con.GetData(Query);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {

                try

                {
                    if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
                    {
                        MessageBox.Show("Missing Data!");

                    }
                    else
                    {
                        string name = textBox1.Text;
                        string gender = comboBox1.SelectedItem.ToString();
                        string Phone = textBox3.Text;
                        string pass = textBox4.Text;
                        string Address = textBox5.Text;


                        string Query = "insert into Employee values('{0}','{1}','{2}','{3}','{4}')";
                        Query = string.Format(Query, name, gender, Phone, pass, Address);
                        Con.SetData(Query);
                        ShowEmployees();
                        MessageBox.Show("Data Insert Successfully");
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (radioButton2.Checked)
            {

                try

                {
                    if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
                    {
                        MessageBox.Show("Missing Data!");

                    }
                    else
                    {
                        string name = textBox1.Text;
                        string gender = comboBox1.SelectedItem.ToString();
                        string Phone = textBox3.Text;
                        string pass = textBox4.Text;
                        string Address = textBox5.Text;


                        string Query = "insert into Admin values('{0}','{1}','{2}','{3}','{4}')";
                        Query = string.Format(Query, name, gender, Phone, pass, Address);
                        Con.SetData(Query);
                        ShowEmployees();
                        MessageBox.Show("Data Insert Successfully");
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }







        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells.Count > 1)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
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
                if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Missing Data!");

                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        string name = textBox1.Text;
                        string gender = comboBox1.SelectedItem.ToString();
                        string Phone = textBox3.Text;
                        string pass = textBox4.Text;
                        string Address = textBox5.Text;


                        string Query = "update Employee set EmpName= '{0}',EmpGen= '{1}',EmpPhone= '{2}',EmpPass= '{3}',EmAdd= '{4}' where EmpId = {5}";
                        Query = string.Format(Query, name, gender, Phone, pass, Address, key);
                        Con.SetData(Query);
                        ShowEmployees();
                        MessageBox.Show("Data Updated Successfully");
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";
                    }
                    else if (radioButton2.Checked)
                    {
                        string name = textBox1.Text;
                        string gender = comboBox1.SelectedItem.ToString();
                        string Phone = textBox3.Text;
                        string pass = textBox4.Text;
                        string Address = textBox5.Text;


                        string Query = "update Admin set AdminName= '{0}',AdminGen= '{1}',AdminPhone= '{2}',AdminPass= '{3}',AdminAdd= '{4}' where AdminId = {5}";
                        Query = string.Format(Query, name, gender, Phone, pass, Address, key);
                        Con.SetData(Query);
                        ShowEmployees();
                        MessageBox.Show("Data Updated Successfully");
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";





                    }

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
                if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Missing Data!");

                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        string Query = "delete from Employee where EmpId= {0}";
                        Query = string.Format(Query, key);
                        Con.SetData(Query);
                        ShowEmployees();
                        MessageBox.Show("Data Deleted Successfully");
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";

                    }
                    else if (radioButton2.Checked)
                    {
                        string Query = "delete from Admin where AdminId= {0}";
                        Query = string.Format(Query, key);
                        Con.SetData(Query);
                        ShowEmployees();
                        MessageBox.Show("Data Deleted Successfully");
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "";




                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashBoard_Admin obj = new DashBoard_Admin();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButton1.Checked)
            {

                label7.Text = "Employees List";
                groupBox1.Text = "Manage Employee";
                ShowEmployees();
            }
            else if (radioButton2.Checked)
            {

                label7.Text = "Admins List";
                groupBox1.Text = "Manage Admin";
                ShowAdmin();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeLeave_Admin obj = new EmployeeLeave_Admin();
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

