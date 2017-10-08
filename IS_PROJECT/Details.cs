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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer y = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //y.Play();
            Menu u = new Menu();
            u.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer y = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            SqlConnection con = new SqlConnection("Data Source=Ranya\\SQLEXPRESS;Initial Catalog=health_fitness_system_project;Integrated Security=True");
            con.Open();
            string data = @"select * from customer where mail = @e";
            SqlCommand cmd = new SqlCommand(data, con);
            SqlParameter p = new SqlParameter("@e", textBox1.Text.ToString());
            cmd.Parameters.Add(p);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable customer = new DataTable();
            customer.Columns.Add("name");
            customer.Columns.Add("customer_ID");
            customer.Columns.Add("current_w");
            customer.Columns.Add("current_H");
            customer.Columns.Add("plan_ID");
            customer.Columns.Add("current_a");
            customer.Columns.Add("mail");
            customer.Columns.Add("password");
            DataRow row;
            while (reader.Read())
            {
                row = customer.NewRow();
                row["name"] = reader["name"];
                row["customer_ID"] = reader["customer_ID"];
                row["current_w"] = reader["current_w"];
                row["current_H"] = reader["current_H"];
                row["plan_ID"] = reader["plan_ID"];
                row["current_a"] = reader["current_a"];
                row["mail"] = reader["mail"];
                row["password"] = reader["password"];
                customer.Rows.Add(row);
            }

            reader.Close();
            con.Close();
            dataGridView1.DataSource = customer;
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }
    }
}
