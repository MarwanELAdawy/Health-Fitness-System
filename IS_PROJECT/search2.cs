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
    public partial class search2 : Form
    {
        public search2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Ranya\\SQLEXPRESS;Initial Catalog=health_fitness_system_project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("search_target", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter("@iddd", textBox1.Text);
            cmd.Parameters.Add(id);
            int x = (int)cmd.ExecuteScalar();
            MessageBox.Show("target:" + x.ToString());
        }
    }
}
