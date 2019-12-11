using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blogging
{
    public partial class regForm2 : Form
    {
        public regForm2()
        {
            InitializeComponent();
        }

        private void RegForm2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label3;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {

          //  label2.ForeColor = Color.Black;
          //  label2.BackColor = Color.Red;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {

            //label2.ForeColor = Color.White;
           // label2.BackColor = Color.DarkSlateGray;

        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBox1.Text = "first name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            String lname = textBox2.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            String lname = textBox2.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBox2.Text = "last name";
                textBox2.ForeColor = Color.Gray;
            }

        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            String ename = textBox3.Text;
            if (ename.ToLower().Trim().Equals("email address"))
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            String ename = textBox3.Text;
            if(Regex.IsMatch(textBox3.Text, pattern))
            {
                errorProvider1.Clear();
            }
                else
                    {

                        errorProvider1.SetError(this.textBox3, "Please provide proper mail id in(example@gmail.com)format");
                    }
            

            if (ename.ToLower().Trim().Equals("email address") || ename.Trim().Equals(""))
            {
               textBox3.Text = "email address";
                textBox3.ForeColor = Color.Gray;
                errorProvider1.Clear();
            }
            return;

        }
        private void TextBox4_Enter(object sender, EventArgs e)
        {
            String uname = textBox4.Text;
            if (uname.ToLower().Trim().Equals("username"))
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }
        private void TextBox4_Leave(object sender, EventArgs e)
        {
            String uname = textBox4.Text;
            if (uname.ToLower().Trim().Equals("username") || uname.Trim().Equals(""))
            {
                textBox4.Text = "username";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void TextBox5_Enter(object sender, EventArgs e)
        {
            String pname = textBox5.Text;
            if (pname.ToLower().Trim().Equals("password"))
            {
                textBox5.Text = "";
                textBox5.UseSystemPasswordChar = true;
                textBox5.ForeColor = Color.Black;
            }

        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            String pname = textBox5.Text;
            if (pname.ToLower().Trim().Equals("password") || pname.Trim().Equals(""))
            {
                textBox5.Text = "password";
                textBox5.UseSystemPasswordChar = false;
                textBox5.ForeColor = Color.Gray;
            }

        }

        private void TextBox6_Enter(object sender, EventArgs e)
        {
            String cname = textBox6.Text;
            if (cname.ToLower().Trim().Equals("confirm password"))
            {
                textBox6.Text = "";
                textBox6.UseSystemPasswordChar = true;
                textBox6.ForeColor = Color.Black;
            }


        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            String cname = textBox6.Text;
            if (cname.ToLower().Trim().Equals("confirm password") || cname.ToLower().Trim().Equals("password") || cname.Trim().Equals(""))
            {
                textBox6.Text = "confirm password";
                textBox6.UseSystemPasswordChar = false;
                textBox6.ForeColor = Color.Gray;
            }


        }

        public Boolean checkusername()
        {
            DB db = new DB();
            String username = textBox4.Text;
            
            DataTable dt = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `userlog` WHERE `username` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
           
            mda.SelectCommand = command;
            mda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        

        }

        public Boolean checkemail()
        {
            DB db = new DB();
            String email = textBox3.Text;

            DataTable dt = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `userlog` WHERE `emailaddress` = @email", db.getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            mda.SelectCommand = command;
            mda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }


        }



        public Boolean checkTextBoxesValues()
        {
            String fname = textBox1.Text;
            String lname = textBox2.Text;
            String email = textBox3.Text;
            String user = textBox4.Text;
            String password = textBox5.Text;

            if (fname.Equals("first name") || lname.Equals("last name") || email.Equals("email address") || user.Equals("username") || password.Equals("password"))
            {
                return true;

            }
            else
            {

                return false;
            }
            }

        private void Label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Label9_MouseEnter(object sender, EventArgs e)
        {
            //label9.ForeColor = Color.Yellow;
        }

        private void Label9_MouseLeave(object sender, EventArgs e)
        {
           // label9.ForeColor = Color.Blue;
        }

        private void TextBox3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String firstname = textBox1.Text;
            String lastname = textBox2.Text;
            String emailaddress = textBox3.Text;
            String username = textBox4.Text;
            String password = textBox5.Text;
            MySqlCommand command = new MySqlCommand("INSERT INTO `userlog`(`firstname`, `lastname`, `emailaddress`, `username`, `password`) VALUES (@fn, @ln,@email, @usn, @pass)", db.getConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailaddress;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            db.openConnection();
            if (!checkTextBoxesValues())
            {
                if (textBox5.Text.Equals(textBox6.Text))
                {
                    if (checkemail())
                    {
                        MessageBox.Show("This emailaddress laready present please", "Duplicate eamil", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (checkusername())
                    {
                        MessageBox.Show("This username laready present please", "Duplicate username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your account has been succesfully created!!!!!!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Data");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong confirmation password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("All fields are mandatory!!", "Empty data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }
    }
    }
    

