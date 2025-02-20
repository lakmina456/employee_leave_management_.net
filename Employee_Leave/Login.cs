using System.CodeDom;
using System.Data;
using System.Linq.Expressions;

namespace Employee_Leave
{
    public partial class Login : Form
    {
        Functions Con;
        public Login()
        {
            InitializeComponent();
            Con = new Functions();
        }

        public static int EmpId;
        public static string EmpName = "";
        public static string gender = "";
        public static string phone = "";
        public static string address = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter Username and Password");
                return;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    try
                    {
                        string Query = "select * from Employee where EmpName='{0}' and EmpPass='{1}'";
                        Query = string.Format(Query, textBox1.Text, textBox2.Text);
                        DataTable dt = Con.GetData(Query);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Invalid Username or Password");
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        else
                        {
                            EmpId = Convert.ToInt32(dt.Rows[0][0].ToString());
                            EmpName = dt.Rows[0][1].ToString();
                            gender = dt.Rows[0][2].ToString();
                            phone = dt.Rows[0][3].ToString();
                            address = dt.Rows[0][5].ToString();
                            DashBoard_Employee obj = new DashBoard_Employee();
                            obj.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message);
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }

                }else if (radioButton2.Checked)
                {
                    try
                    {
                        string Query = "select * from Admin where AdminName='{0}' and AdminPass='{1}'";
                        Query = string.Format(Query, textBox1.Text, textBox2.Text);
                        DataTable dt = Con.GetData(Query);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Invalid Admin Username or Password");
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        else
                        {
                            EmpId = Convert.ToInt32(dt.Rows[0][0].ToString());
                            EmpName = dt.Rows[0][1].ToString();
                            gender = dt.Rows[0][2].ToString();
                            phone = dt.Rows[0][3].ToString();
                            address = dt.Rows[0][5].ToString();

                            DashBoard_Admin obj = new DashBoard_Admin();
                            obj.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    


                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
