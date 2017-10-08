using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_PROJECT
{
    public partial class Basic_Info : Form
    {
        public Basic_Info()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show(); 
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            this.Hide();
        }

        private void Basic_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
