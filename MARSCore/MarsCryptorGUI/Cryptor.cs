using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MARSCore;

namespace MarsCryptorGUI
{
    public partial class Cryptor : Form
    {
        private readonly MarsWrapper _cryptor;
        public Cryptor()
        {
            InitializeComponent();
            _cryptor = new MarsWrapper();
        }

        private void OpenInputButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                InputFileNameTB.Text = openFileDialog1.FileName;
        }

        private void OpenOutputButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                OutputFileNameTB.Text = saveFileDialog1.FileName;
        }

        private void SetKeyButton_Click(object sender, EventArgs e)
        {
            var passwordBytes = Encoding.ASCII.GetBytes(PasswordBox.Text);
            SHA384 sha = new SHA384Managed();
            _cryptor.Key = sha.ComputeHash(passwordBytes);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            byte[] data;
            using (var input = new FileStream(InputFileNameTB.Text, FileMode.Open, FileAccess.Read))
            {
                data = new byte[input.Length];
                input.Read(data, 0, (int)input.Length);
            }
            var encrypted = _cryptor.Encrypt(data);

            using (var output = new FileStream(OutputFileNameTB.Text, FileMode.OpenOrCreate, FileAccess.Write))
            {
                output.Write(encrypted, 0, encrypted.Length);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            byte[] data;
            using (var input = new FileStream(InputFileNameTB.Text, FileMode.Open, FileAccess.Read))
            {
                data = new byte[input.Length];
                input.Read(data, 0, (int)input.Length);
            }
            var decrypted = _cryptor.Decrypt(data);

            using (var output = new FileStream(OutputFileNameTB.Text, FileMode.OpenOrCreate, FileAccess.Write))
            {
                output.Write(decrypted, 0, decrypted.Length);
            }
        }
    }
}
