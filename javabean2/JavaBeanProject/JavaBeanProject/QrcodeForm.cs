using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace JavaBeanProject
{
    public partial class QrcodeForm : Form
    {
        public QrcodeForm()
        {
            InitializeComponent();
        }

        private void QrcodeForm_Load(object sender, EventArgs e)
        {
            QRCodeGenerator qrCodeGen = new QRCodeGenerator();
            QRCodeData codeData = qrCodeGen.CreateQrCode("KALBO", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(codeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(10, Color.Black, Color.White, true);

            picqrcode.Image = qrCodeImage;

        }

        private void picqrcode_Click(object sender, EventArgs e)
        {

        }
    }
}
