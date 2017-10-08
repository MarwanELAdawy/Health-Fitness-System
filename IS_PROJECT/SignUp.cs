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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer q = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //q.Play();
            SqlConnection con = new SqlConnection("Data Source=Ranya\\SQLEXPRESS;Initial Catalog=health_fitness_system_project;Integrated Security=True");
            con.Open();
            string s_at = @"insert into customer (name,mail,password,current_a,current_w,current_h)values (@n,@e,@p,@ch,@cw,@ca)";
            SqlCommand cmd2 = new SqlCommand(s_at, con);
            SqlParameter para1 = new SqlParameter("@n", textBox1.Text.ToString());
            cmd2.Parameters.Add(para1);
            SqlParameter para2 = new SqlParameter("@e", textBox2.Text.ToString());
            cmd2.Parameters.Add(para2);
            SqlParameter para3 = new SqlParameter("@p", textBox3.Text.ToString());
            cmd2.Parameters.Add(para3);
            SqlParameter para4 = new SqlParameter("@ch", textBox4.Text.ToString());
            cmd2.Parameters.Add(para4);
            SqlParameter para5 = new SqlParameter("@cw", textBox5.Text.ToString());
            cmd2.Parameters.Add(para5);
            SqlParameter para6 = new SqlParameter("@ca", textBox6.Text.ToString());
            cmd2.Parameters.Add(para6);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Welcome "+textBox1.Text.ToString()+" .");
            Details d = new Details();
            d.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
