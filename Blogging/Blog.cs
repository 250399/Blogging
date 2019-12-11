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
    public partial class Blog : Form
    {
        int i=0;
        String user = Form7.val;
        int id;
        int A = 550;
        Boolean b = false;
        public Blog(String s)
        {
            id = Convert.ToInt32(s);
          
            MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=1234");
            connection.Open();
            InitializeComponent();
            

            MySqlCommand cmd = new MySqlCommand("Select * from db.postdetails where postid = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader dr = cmd.ExecuteReader()) { 
                
            while (dr.Read())
            {
                if (dr.IsDBNull(dr.GetOrdinal("images")))
                {
                    textBox1.Text = dr["username"].ToString();
                    textBox2.Text = dr["title"].ToString();
                    label1.Text = dr["contents"].ToString();
                }
                else
                {
                    textBox1.Text = dr["username"].ToString();
                    textBox2.Text = dr["title"].ToString();
                    label1.Text = dr["contents"].ToString();
                    byte[] img = (byte[])(dr["images"]);
                    MemoryStream str = new MemoryStream(img);

                    pictureBox1.Image = System.Drawing.Image.FromStream(str);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }

                
            }
            }
            
            connection.Close();
            int h = label1.Height;
            panel3.Height = h;
           // this.panel4.Location=new System.Drawing.Point( 20, panel3.Height + 200);
        }
        private void Blog_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=1234");
            connection.Open();

            
            if (user != null)
            {
                string comment = textBox4.Text;
                if (comment != null)
                {

                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO db.comments (id,com,username)values(@cid,@comment,@user)", connection);
                    cmd1.Parameters.AddWithValue("@cid", id);
                    cmd1.Parameters.AddWithValue("@comment", comment);
                    cmd1.Parameters.AddWithValue("@user", user);
                    if (cmd1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                        textBox4.Text = null;
                    }
                }
            }
            else {
                MessageBox.Show("Please Login First!!");
                    }
            connection.Close();
        }
        public System.Windows.Forms.TextBox add(String komment,String username)
        {
         //   MessageBox.Show("asdsads");
           //MessageBox.Show(komment);
            if (b == false)
            {
                
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                this.Controls.Add(txt);
                txt.Top = A ;
                txt.Left = 50;
                A = A + 50;
                txt.Multiline= true;
                txt.Size = new System.Drawing.Size(700, 20);
                txt.Text = username+":\n"+komment;
                b = true;


                return txt;
            }
            else {
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                this.Controls.Add(txt);
                txt.Top = A ;
                txt.Left = 50;
                txt.Multiline = true;
                txt.Size = new System.Drawing.Size(700, 20);
                txt.Text = username + ":\n" + komment;

                A = A + 20;
                return txt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=1234");
            connection.Open();

            MySqlCommand cd = new MySqlCommand("select count(com) from db.comments where id = @id", connection);
            cd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cd.ExecuteScalar());
            
                
            

            //MessageBox.Show(count.ToString());
            while (count != 0 && i <count )
            {
                
                MySqlCommand cmmd = new MySqlCommand("select com,username from db.comments where id = @id limit 1 offset @i", connection);
                cmmd.Parameters.AddWithValue("@id", id);
                cmmd.Parameters.AddWithValue("@i",i);
                using (MySqlDataReader rd = cmmd.ExecuteReader()) {
                  
                    while (rd.Read())
                    {
                        //MessageBox.Show("sadas");
                        add(rd.GetString(0),rd.GetString(1));
                        
                    }
                }
                i++;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
 
                


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Read_blog rb = new Read_blog();
            rb.Show();
        }

      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                    }

        private void register_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            regForm2 reg = new regForm2();
            reg.Show();

        }

    

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (user == null)
            {

                this.Hide();
                Form4 f1 = new Form4();
                f1.Show();
            }
            else
            {
                this.Hide();
                Form7 f1 = new Form7(user);
                f1.Show();
            }

        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
    
}   
