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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer a = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //a.Play();
            Insert d = new Insert();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer b = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //b.Play();
            up u = new up();
            u.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer c = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //c.Play();
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer d = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //d.Play();
            Delete s = new Delete();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer w = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //w.Play();
            Search s = new Search();
            s.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            search2 s2 = new search2();
            s2.Show();
            this.Hide();
        }
    }
}
