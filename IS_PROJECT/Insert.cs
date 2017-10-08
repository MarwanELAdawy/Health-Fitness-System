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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer l = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //l.Play();
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer k = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //k.Play();
            SqlConnection con = new SqlConnection("Data Source=Ranya\\SQLEXPRESS;Initial Catalog=health_fitness_system_project;Integrated Security=True");
            con.Open();
            if (comboBox1.SelectedItem.ToString() == "food")
            {
                string insert_at = @"insert into food (breakfast,dinner,lunch)values (@bf,@D,@L)";
                SqlCommand cmd1 = new SqlCommand(insert_at, con);
                SqlParameter param1 = new SqlParameter("@bf", textBox4.Text.ToString());
                cmd1.Parameters.Add(param1);
                SqlParameter param2 = new SqlParameter("@D", textBox2.Text.ToString());
                cmd1.Parameters.Add(param2);
                SqlParameter param3 = new SqlParameter("@L", textBox3.Text.ToString());
                cmd1.Parameters.Add(param3);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Saved");
            }
            else if (comboBox1.SelectedItem.ToString() == "exercise")
            {
                string i_a = @"insert into exercise (ex_name) values (@ex)";
                SqlCommand cmd2 = new SqlCommand(i_a, con);
                SqlParameter par1 = new SqlParameter("@ex", textBox1.Text.ToString());
                cmd2.Parameters.Add(par1);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Saved");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem.ToString() == "food")
            {
                textBox1.Hide();

            }
            else if (comboBox1.SelectedItem.ToString() == "exercise")
            {
                textBox4.Hide();
                textBox3.Hide();
                textBox2.Hide();
                textBox1.Show();
            }
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }
    }

}

