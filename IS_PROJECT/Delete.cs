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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer i = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //i.Play();
            SqlConnection con = new SqlConnection("Data Source=Ranya\\SQLEXPRESS;Initial Catalog=health_fitness_system_project;Integrated Security=True");
            con.Open();
            if (listBox1.SelectedItem.ToString() == "food")
            {
                String delete = @"delete from food  where food_id=@id ";
                SqlCommand cmd = new SqlCommand(delete, con);
                SqlParameter p2 = new SqlParameter("@id", textBox1.Text.ToString());
                cmd.Parameters.Add(p2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete");
            }
            else if (listBox1.SelectedItem.ToString() == "exercise")
            {
                string delete = @"delete from exercise where ex_id=@id ";
                SqlCommand cmd = new SqlCommand(delete,con);
                SqlParameter p = new SqlParameter("@id", textBox1.Text.ToString());
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete");
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer j = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //j.Play();
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
