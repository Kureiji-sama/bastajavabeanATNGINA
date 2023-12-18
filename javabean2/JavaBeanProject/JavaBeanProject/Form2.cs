using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace JavaBeanProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void AddCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddToCart atc = new AddToCart();
            atc.ShowDialog();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu1 fm = new FormMenu1();
            fm.ShowDialog();
            this.Close();
        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            SidebarPanel.Visible = true;
            OpenMenu.Visible = true;
        }

        private void SidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SidebarPanel.Visible = false;
            OpenMenu.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            this.Close();
        }
    }
}
