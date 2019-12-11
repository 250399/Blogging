using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blogging
{
    public partial class edit : Form
    {
        private string val;
        string title;
        int id;
      

        public edit(string val)
        {
            InitializeComponent();
            this.val = val;
                        editmethod();          
        }

        void editmethod()
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=1234");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select count(postid) from db.postdetails where username=@val", conn);
            cmd.Parameters.AddWithValue("@val", val);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            int i = 0;
            while (i < count)
            { 
                cmd = new MySqlCommand("select title,postid from db.postdetails where username=@val limit 1 offset @i ", conn);
                cmd.Parameters.AddWithValue("@val", val);
                cmd.Parameters.AddWithValue("@i", i);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read()) { 
                          comboBox1.Items.Add(dr.GetString(1).ToString());
                        comboBox2.Items.Add(dr.GetString(0).ToString());
                    }
                }
                i++;
            }
        }
        private void edit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex=comboBox1.SelectedIndex;
            tb();
            
        }
        void tb() {
            MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=1234");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select contents from db.postdetails where postid=@id",con);
            cmd.Parameters.AddWithValue("@id",comboBox1.SelectedItem);
            using (MySqlDataReader dr = cmd.ExecuteReader()) {
                while (dr.Read()) {
                    label1.Text = dr.GetString(0);
                }
            }
        }   

        private void del_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource = localhost; username=root;password=1234");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("delete from db.postdetails where postid=@id", conn);
            cmd.Parameters.AddWithValue("@id",comboBox1.SelectedItem);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Deleted");
                this.Hide();
                Form7 f = new Form7(val);
                f.Show();
            }
            else {
                MessageBox.Show("Error serving your request!");
            }

        }

        private void ed_Click(object sender, EventArgs e)
        {   this.Hide();
            Form5 f5 = new Form5(val, comboBox1.SelectedItem.ToString(), 1) ;
            f5.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex=comboBox2.SelectedIndex;
            tb();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f9 = new Form7(val);
            this.Hide();
            f9.Show();
        }
    }
}
