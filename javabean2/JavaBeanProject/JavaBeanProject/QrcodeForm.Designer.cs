namespace JavaBeanProject
{
    partial class QrcodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            picqrcode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picqrcode).BeginInit();
            SuspendLayout();
            // 
            // picqrcode
            // 
            picqrcode.Location = new Point(87, 12);
            picqrcode.Name = "picqrcode";
            picqrcode.Size = new Size(373, 322);
            picqrcode.TabIndex = 0;
            picqrcode.TabStop = false;
            picqrcode.Click += picqrcode_Click;
            // 
            // QrcodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 486);
            Controls.Add(picqrcode);
            Name = "QrcodeForm";
            Text = "QrcodeForm";
            Load += QrcodeForm_Load;
            ((System.ComponentModel.ISupportInitialize)picqrcode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picqrcode;
    }
}