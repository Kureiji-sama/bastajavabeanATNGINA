using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;










namespace JavaBeanProject
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = "";
            BasePath = ""; 
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            OpenMenu = new PictureBox();
            Profile = new PictureBox();
            AddCart = new PictureBox();
            pictureBox5 = new PictureBox();
            SidebarPanel = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpenMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Profile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(253, 246, 236);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(OpenMenu);
            panel2.Controls.Add(Profile);
            panel2.Controls.Add(AddCart);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(-5, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1301, 70);
            panel2.TabIndex = 20;
            // 
            // OpenMenu
            // 
            OpenMenu.Image = Properties.Resources.image_removebg_preview__9_;
            OpenMenu.Location = new Point(1193, 9);
            OpenMenu.Name = "OpenMenu";
            OpenMenu.Size = new Size(53, 52);
            OpenMenu.TabIndex = 10;
            OpenMenu.TabStop = false;
            OpenMenu.Click += OpenMenu_Click;
            OpenMenu.MouseDoubleClick += OpenMenu_MouseDoubleClick;
            // 
            // Profile
            // 
            Profile.Image = Properties.Resources.image_removebg_preview__7_;
            Profile.Location = new Point(1125, 9);
            Profile.Name = "Profile";
            Profile.Size = new Size(62, 52);
            Profile.TabIndex = 10;
            Profile.TabStop = false;
            Profile.Click += Profile_Click;
            // 
            // AddCart
            // 
            AddCart.Image = Properties.Resources.image_removebg_preview__5_;
            AddCart.Location = new Point(1056, 9);
            AddCart.Name = "AddCart";
            AddCart.Size = new Size(63, 52);
            AddCart.TabIndex = 10;
            AddCart.TabStop = false;
            AddCart.Click += AddCart_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.image_removebg_preview__3_;
            pictureBox5.Location = new Point(-1, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(257, 66);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(70, 70, 70);
            SidebarPanel.Location = new Point(1199, 67);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(53, 543);
            SidebarPanel.TabIndex = 25;
            SidebarPanel.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(58, 242);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password:";
            textBox2.Size = new Size(326, 43);
            textBox2.TabIndex = 23;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(58, 184);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email/Username:";
            textBox1.Size = new Size(326, 43);
            textBox1.TabIndex = 22;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(242, 234, 211);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__10_;
            pictureBox1.Location = new Point(-410, -103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1255, 731);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(58, 300);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Contact";
            textBox3.Size = new Size(326, 43);
            textBox3.TabIndex = 29;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2023_12_13_214606;
            pictureBox2.Location = new Point(110, 365);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 68);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2023_12_13_214856;
            pictureBox3.Location = new Point(917, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(240, 119);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2023_12_13_214928;
            pictureBox4.Location = new Point(896, 350);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(287, 174);
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Screenshot_2023_12_13_215004;
            pictureBox6.Location = new Point(934, 242);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(208, 84);
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 234, 211);
            ClientSize = new Size(1252, 611);
            Controls.Add(SidebarPanel);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Register";
            Text = "Register";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OpenMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)Profile).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox OpenMenu;
        private PictureBox Profile;
        private PictureBox AddCart;
        private PictureBox pictureBox5;
        private Panel SidebarPanel;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
    }
}