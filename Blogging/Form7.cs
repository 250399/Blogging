using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blogging
{
    public partial class Form7 : Form
    {
        public static string val;
        string imgLocation;
        string value,value1;
        public Form7(string s)
        {
            InitializeComponent();
            val = s;

            MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=1234");
            MySqlCommand cmd = new MySqlCommand("SELECT profileimage FROM db.edata WHERE record='" + val + "'", connection);

            connection.Open();
            MySqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                byte[] imgg = (byte[])(myReader["profileimage"]);
                if (imgg == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(imgg);
                    pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            connection.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=1234");
        MySqlCommand command;
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                value = radioButton3.Text;
            else if (radioButton5.Checked)
                value = radioButton5.Text;
            else
                value = radioButton6.Text;

            Form1 f = new Form1();
            this.Hide();
            Form5 f2 = new Form5(value1,value,0);
            f2.ShowDialog();
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            byte[] imag = null;
            FileStream streem = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            imag = brs.ReadBytes((int)streem.Length);
  
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
           
            
            String insertQuery = "INSERT INTO db.edata(`record`,`profileimage`) VALUES(@val,@images)";
            connection.Open();
            command = new MySqlCommand(insertQuery, connection);
            command.Parameters.Add("@images", MySqlDbType.LongBlob);
            command.Parameters.Add("@val", MySqlDbType.VarChar);
            command.Parameters["@images"].Value = img;
            command.Parameters["@val"].Value = val;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
                //this.Close();
                //Form5 f1 = new Form5(val);
                //f1.Show();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label4.Text = "Welcome" + " " + val;
            value1 = val;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Read_blog rb = new Read_blog();
            rb.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void my_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit my = new edit(val);
            my.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            val = "";
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        public class FormClass : Form
        {
            protected override void OnFormClosing(FormClosingEventArgs e)
            {
                base.OnFormClosing(e);
                val = null;
            }
        }
    }
}
