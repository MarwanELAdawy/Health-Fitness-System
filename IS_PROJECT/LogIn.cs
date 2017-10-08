using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS_PROJECT
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Ranya\\SQLEXPRESS;Initial Catalog=health_fitness_system_project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer  where customer_ID=' " + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("welcome");
                Menu m = new Menu();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("your account isn't available please signup ");
                SignUp s = new SignUp();
                s.Show();
                this.Hide();
            }
            reader.Close();
            con.Close();
        }


        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }

}