using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Blogging
{
    public partial class Form5 : Form
    {
        string val;
        int check;
        bool boolvalue;
        string imgLocation;
        int value1;
        string value2;
        DateTime now = DateTime.Now;
        public Form5(string s,string s1,int i)
        {
            InitializeComponent();
            val = s;
            check = i;
            groupBox1.Visible = true;
            richTextBox1.Width = 353;
            button1.Visible = true;
            pictureBox1.Visible = true;
            textBox1.Width = 249;
            label3.Visible = true;
            boolvalue = true;
            
            if (i == 1) {
                value1 = Convert.ToInt32(s1);
                MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=1234");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from db.postdetails where postid=@id",conn);
                cmd.Parameters.AddWithValue("@id",value1);
                //cmd.Parameters.AddWithValue("@title",s1);
                using (MySqlDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read()) {
                        textBox1.Text = dr["title"].ToString();
                        richTextBox1.Text = dr["contents"].ToString();
                        value2 = dr["type_blog"].ToString();
                        if (!dr.IsDBNull(dr.GetOrdinal("images")))
                        {
                            byte[] img = (byte[])(dr["images"]);
                            MemoryStream str = new MemoryStream(img);

                            pictureBox1.Image = System.Drawing.Image.FromStream(str);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                        }

                    }
                }
            }
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=1234");
        MySqlCommand command;
        private void Form5_Load(object sender, System.EventArgs e)
        {
            label4.Text = "Welcome" + " "+ val;
        }

        private void RegisterToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            
        }

        
        private void Button1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
        void addorupdate(string query) {
            connection.Open();
            byte[] img = { };
            command = new MySqlCommand(query,connection);
            command.Parameters.AddWithValue("@id",value1);
            if (pictureBox1.ImageLocation != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                img = ms.ToArray();
            }
            command.Parameters.Add("@username", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@title", MySqlDbType.VarChar, 30);
            command.Parameters.Add("@contents", MySqlDbType.LongText);
            command.Parameters.Add("@date", MySqlDbType.DateTime);
            command.Parameters.Add("@images", MySqlDbType.LongBlob);
            command.Parameters.Add("@type_blog", MySqlDbType.VarChar, 30);

            command.Parameters["@username"].Value = val;
            command.Parameters["@title"].Value = textBox1.Text;
            command.Parameters["@contents"].Value = richTextBox1.Text;
            command.Parameters["@date"].Value = now;
            if (pictureBox1.ImageLocation != null)
            {

                command.Parameters["@images"].Value = img;
            }else
                command.Parameters["@images"].Value = null;
            command.Parameters["@type_blog"].Value = value2;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Done");
                this.Close();
                Form7 f7 = new Form7(val);
                f7.Show();
            }

            connection.Close();
        }
        private void Button2_Click(object sender, System.EventArgs e)
        {
            if (check == 1) {
                string insertQuery = "update db.postdetails set username =@username,title=@title,contents=@contents,date=" +
                    "@date,images=@images,type_blog=@type_blog where postid=@id";
                //MessageBox.Show("In");
                addorupdate(insertQuery);    
            }
            else if (boolvalue == true)
            {
                if (pictureBox1.ImageLocation != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();
                }
                String insertQuery = "INSERT INTO db.postdetails(`username`, `title`,`contents`,`date`,`images`,`type_blog`) VALUES(@username, @title, @contents,@date, @images,@type_blog)";
                addorupdate(insertQuery);
            }
            else
            {
                String insertQuery = "INSERT INTO db.postdetails(`username`, `title`,`contents`,`date`,`type_blog`) VALUES(@username, @title, @contents,@date,@type_blog)";
                addorupdate(insertQuery);
            }
        }

        private void BlogType1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            richTextBox1.Width =353;
            button1.Visible = true;
            pictureBox1.Visible = true;
            textBox1.Width = 249;
            label3.Visible = true;
            boolvalue = true;
        }

        private void BlogType2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            richTextBox1.Width = 574;
            button1.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Width = 462;
            label3.Visible = false;
            boolvalue = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
