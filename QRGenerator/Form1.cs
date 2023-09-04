using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRGenerator
{
    public partial class QRCodeGenerator : Form
    {
        public QRCodeGenerator()
        {
            InitializeComponent();
        }

        private void GenerateAndSaveQRCode_Click(object sender, EventArgs e)
        {
            string ssidValue = ssid.Text;
            string securityTypeValue = cmbSecurityType.SelectedItem.ToString();
            string passwordValue = password.Text;

            string wifiConfig = $"WIFI:T:{securityTypeValue};S:{ssidValue};P:{passwordValue};;";

            QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(wifiConfig, QRCoder.QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(8);

            QRGenerated.Image = qrCodeImage;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Imagem PNG|*.png";
            saveFileDialog.Title = "Salvar QR Code";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                qrCodeImage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("QR code salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ssid_MouseClick(object sender, MouseEventArgs e)
        {
            ssid.Text = "";
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            password.Text = "";
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == "") this.password.PasswordChar = '*';
        }

        private void QRGenerated_BackgroundImageChanged(object sender, EventArgs e)
        {
            QRGenerated.BackColor = Color.White;
        }

        private void ssid_MouseHover(object sender, EventArgs e)
        {
            ssid.Cursor = Cursors.IBeam;
        }

        private void password_MouseHover(object sender, EventArgs e)
        {
            password.Cursor = Cursors.IBeam;
        }

        private void password_MouseEnter(object sender, EventArgs e)
        {
            password.Cursor = Cursors.IBeam;
        }

        private void ssid_MouseEnter(object sender, EventArgs e)
        {
            ssid.Cursor = Cursors.IBeam;
        }
    }
}
