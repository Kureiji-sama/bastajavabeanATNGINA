using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaBeanProject
{
    public partial class Register : Form
    {
        private object submitButton;

        public Register()
        {
            InitializeComponent();
        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            SidebarPanel.Visible = true;
            OpenMenu.Visible = true;
        }

        private void OpenMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SidebarPanel.Visible = false;
            OpenMenu.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu1 fm = new FormMenu1();
            fm.ShowDialog();
            this.Close();
        }

        private void AddCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddToCart atc = new AddToCart();
            atc.ShowDialog();
            this.Close();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            if (IsValidEmail(email))
            {
                if (IsValidEmail(email))
                {

                }
                else
                {
                    textBox1.Focus();
                    textBox1.ForeColor = Color.Red;
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            return Regex.IsMatch(email, pattern);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RegistrationForm regform = new RegistrationForm();
            regform.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e, MessageBoxButtons MessageBoxButtons)
        {
            textBox2.PasswordChar = '*';
            string password = textBox2.Text;

/*            if (password.Length < 8)
            {
                MessageBox.Show("Your password is alfon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
/*        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";

            textBox2.ForeColor = Color.Black;

            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.ForeColor = Color.Gray;

                textBox2.Text = "Enter password";

                textBox2.UseSystemPasswordChar = false;

                SelectNextControl(textBox2, true, true, false, true);
            }
        }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
