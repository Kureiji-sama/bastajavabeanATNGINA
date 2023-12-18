using Microsoft.VisualBasic.Logging;
using System.Runtime.InteropServices;
namespace JavaBeanProject
{
    public partial class FormMenu1 : Form
    {
        private object cartForm;

        public FormMenu1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
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


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SidebarPanel.Visible = true;
            OpenMenu.Visible = true;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CloseMenu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu1_Load(object sender, EventArgs e)
        {

        }

        private void OpenMenu_DoubleClick(object sender, EventArgs e)
        {
            SidebarPanel.Visible = false;
            OpenMenu.Visible = true;

        }

        private void SidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void AddCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddToCart atc = new AddToCart();
            atc.ShowDialog();
            this.Close();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            Image itemImage = Image.FromFile(@"C:\Users\pagta\source\repos\javabean2\JavaBeanProject\JavaBeanProject\Resources\coffee.png");


            AddToCart("YourItemName", itemImage);
        }

        private void AddToCart(string itemName, Image itemImage)
        {
            object value = cartForm.AddItemToCart(itemName, itemImage);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {
            
        }
    }
}