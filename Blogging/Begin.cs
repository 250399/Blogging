using System;
using System.Windows.Forms;

namespace Blogging
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            regForm2 rf2 = new regForm2();
            rf2.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Read_blog rb = new Read_blog();
            rb.Show();
        }
    }
}
