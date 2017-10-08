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
    public partial class up : Form
    {
        public up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer g = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
           // g.Play();
            SqlConnection con = new SqlConnection("Data Source=Ranya\\SQLEXPRESS;Initial Catalog=health_fitness_system_project;Integrated Security=True");
            con.Open();
            if (listBox1.SelectedItem.ToString() == "food")
            {
                String update = @"update food set breakfast = @b where food_id=@id ";
                SqlCommand cmd = new SqlCommand(update, con);
                SqlParameter p1 = new SqlParameter("@b", textBox1.Text.ToString());
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@id", textBox5.Text.ToString());
                cmd.Parameters.Add(p2);
                cmd.ExecuteNonQuery();

                String update1 = @"update food set lunch = @l where food_id=@id ";
                SqlCommand cmd1 = new SqlCommand(update1, con);
                SqlParameter p3 = new SqlParameter("@l", textBox2.Text.ToString());
                cmd1.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@id", textBox5.Text.ToString());
                cmd1.Parameters.Add(p4);
                cmd1.ExecuteNonQuery();

                String update2 = @"update food set dinner = @d where food_id=@id ";
                SqlCommand cmd2 = new SqlCommand(update2, con);
                SqlParameter p5 = new SqlParameter("@d", textBox3.Text.ToString());
                cmd2.Parameters.Add(p5);
                SqlParameter p6 = new SqlParameter("@id", textBox5.Text.ToString());
                cmd2.Parameters.Add(p6);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("update");
            }
            else if (listBox1.SelectedItem.ToString() == "exercise")
            {
                String update = @"update exercise set ex_name = @e where ex_id=@id2 ";
                SqlCommand cmd = new SqlCommand(update, con);
                SqlParameter p1 = new SqlParameter("@e",textBox4.Text.ToString());
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@id2", textBox5.Text.ToString());
                cmd.Parameters.Add(p2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("update");

            }

            con.Close();
        

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "food")
            {
                textBox4.Hide();

            }
            else if (listBox1.SelectedItem.ToString() == "exercise")
            {
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox5.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  System.Media.SoundPlayer f = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //f.Play();
            Menu n = new Menu();
            n.Show();
            this.Hide();
        }
    }
}
