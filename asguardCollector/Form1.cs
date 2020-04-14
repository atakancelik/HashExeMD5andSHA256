using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asguardCollector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string path = "";
        private static string asg = "";
        private static string name = "";
        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Exe Files (*.exe)|*.exe";
            fileDialog.ShowDialog();
            path = fileDialog.FileName;
            name = fileDialog.SafeFileName;
            txt_path.Text = path;
        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
                MessageBox.Show("Lütfen .exe seçiminizi yapın.");
            else
            {
                try
                {
                    txt_a1.Text = name;
                    txt_a2.Text = AsguardGet(path, new MD5CryptoServiceProvider());
                    txt_a3.Text = AsguardGet(path, new SHA256CryptoServiceProvider());
                }
                catch 
                {
                    MessageBox.Show("Asguard bu .exe yi tanımlayamadı.");
                }

                
            }
        }
        internal static string AsguardGet(string filePath, HashAlgorithm cryptoService)
        {
            using (cryptoService)
            {
                using (var fileStream = new FileStream(filePath,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.ReadWrite))
                {
                    var hash = cryptoService.ComputeHash(fileStream);
                    var hashString = Convert.ToBase64String(hash);
                    return hashString.TrimEnd('=');
                }
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_a1.Text) && !string.IsNullOrEmpty(txt_a2.Text) && !string.IsNullOrEmpty(txt_a3.Text))
            {
                string t = "[A:1]:" + txt_a1.Text + " [A:2]:" + txt_a2.Text + " [A:3]:" + txt_a3.Text;
                Clipboard.SetText(t);
            }
            
        }
    }
}
