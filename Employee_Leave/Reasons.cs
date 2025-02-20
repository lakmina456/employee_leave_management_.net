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
    public partial class Reasons : Form
    {
        Functions Con;
        public Reasons()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCategories();
        }
        private void ShowCategories()
        {
            string Query = "select * from Category";
            dataGridView1.DataSource = Con.GetData(Query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Missing Data!");

                }
                else
                {
                    string Category = textBox1.Text;
                    string Query = "insert into Category values('{0}')";
                    Query = string.Format(Query, Category);
                    Con.SetData(Query);
                    ShowCategories();
                    textBox1.Text = "";
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
                if (string.IsNullOrEmpty(textBox1.Text))
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
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Missing Data!");

                }
                else
                {
                    string Category = textBox1.Text;
                    string Query = "Update Category set CatName = '{0}' where CatId = {1}";
                    Query = string.Format(Query, Category, key);
                    Con.SetData(Query);
                    ShowCategories();
                    textBox1.Text = "";
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
                if (key == 0)
                {
                    MessageBox.Show("Missing Data!");

                }
                else
                {
                    string Category = textBox1.Text;
                    string Query = "delete from Category where CatId = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowCategories();
                    textBox1.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
