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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer p = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //p.Play();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer t = new System.Media.SoundPlayer(@"C:\Users\marwa\Desktop\Pling-KevanGC-1485374730.wav");
            //t.Play();
            Basic_Info f = new Basic_Info();
            f.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
