using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Blogging
{
    public partial class Form1 : Form
    {
        public String username;
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
           // label2.ForeColor = Color.Black;
           // label2.BackColor = Color.Red;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
           //label2.ForeColor = Color.White;
           //label2.BackColor = Color.DarkSlateGray;

        }

        private void Label2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DB d = new DB();
            username = textBox1.Text;

            String password = textBox2.Text;
            DataTable dt = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter();
            MySqlCommand msc = new MySqlCommand("SELECT * FROM `userlog` WHERE `username` = @usn AND `password` = @pass", d.getConnection());
                msc.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
                msc.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                mda.SelectCommand = msc;
                mda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Logged in successfully!");
                    this.Hide();
                    Form7 f2 = new Form7(username);
                    f2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid username and password!");
                }
            

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            regForm2 re = new regForm2();
            re.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
