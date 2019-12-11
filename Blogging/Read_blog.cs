using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blogging
{
    public partial class Read_blog : Form
    {
        private object pictureBox1;
        int i = 0;
        int counter = 0;
        Int32 count;
        //String l1, l2, l3, l4, d1, d2, d3, d4;
        public Read_blog()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=1234");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select count(postid) from db.postdetails",connection);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            fetch_data(counter,i);
        }

        public void fetch_data(int counter,int i)
        {

            while (counter < 4)
            {

                MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=1234");
                connection.Open();
                MySqlCommand cmd0 = new MySqlCommand("Select title,postid,contents from db.postdetails limit 1 offset @off", connection);
                cmd0.Parameters.AddWithValue("@off", i);
                MySqlDataReader rd = cmd0.ExecuteReader();

                while (rd.Read())
                {
                    
                    if (i % 4 == 1)
                    {
                        label1.Text = rd.GetString(0);
                        label2.Text = rd.GetString(2);
                        b1.Name = rd.GetString(1);
                    }
                    else if (i % 4 == 2)
                    {
                        label3.Text = rd.GetString(0);
                        label4.Text = rd.GetString(2);
                        b2.Name = rd.GetString(1);
                    }
                    else if (i % 4 == 3)
                    {
                        label5.Text = rd.GetString(0);
                        label6.Text = rd.GetString(2);
                        b3.Name = rd.GetString(1);
                           
                    }
                    else if(i%4 == 0)
                    {
                        label7.Text = rd.GetString(0);
                        label9.Text = rd.GetString(2);
                        b4.Name = rd.GetString(1);
                      
                    }
                    
                 
                }


                i++;
                rd.Close();
                connection.Close();
                counter++;
            }
        }
        private void Read_blog_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            counter = 0;
            
            if (i >= count) {
                MessageBox.Show("No more Blogs available");
            }
            else
            {
                if ( count - i  >= 4)
                {
                    i += 4;
                    fetch_data(counter, i);
                }
                else {
                    int n = count - i;
                    i += n;
                    fetch_data(counter, i);
                }
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            
            counter = 0;
            
            if (i <= 0)
                MessageBox.Show("No Blogs created yet");
            else { 
                i -= 4;
                fetch_data(counter, i);
            }
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blog blog3 = new Blog(b3.Name);
            blog3.Show();
           
        }

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blog blog1 = new Blog(b1.Name);
            blog1.Show();
            
        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blog blog2 = new Blog(b2.Name);
            blog2.Show();
            
        }

        private void b4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blog blog4 = new Blog(b4.Name);
            blog4.Show();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
