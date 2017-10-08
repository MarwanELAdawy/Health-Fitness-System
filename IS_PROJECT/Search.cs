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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer o = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //o.Play();
            SqlConnection con = new SqlConnection("Data Source=Ranya\\SQLEXPRESS;Initial Catalog=health_fitness_system_project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter targeet = new SqlParameter("@targeeet", target.Text);
            cmd.Parameters.Add(targeet);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable plan = new DataTable();
            plan.Columns.Add("plan_id");
            plan.Columns.Add("breakfast");
            plan.Columns.Add("dinner");
            plan.Columns.Add("lunch");
            plan.Columns.Add("exercise");
            DataRow row;
            while (reader.Read())
            {
                row = plan.NewRow();
                row["plan_id"] = reader["plan_id"];
                row["breakfast"] = reader["breakfast"];
                row["dinner"] = reader["dinner"];
                row["lunch"] = reader["lunch"];
                row["exercise"] = reader["ex_name"];
                plan.Rows.Add(row);
            }

            reader.Close();
            con.Close();
            dataGridView1.DataSource = plan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer n = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            n.Play();
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }

}

