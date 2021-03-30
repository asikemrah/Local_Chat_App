using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Local_Chat_Uygulaması
{
    public partial class DosyaTransfer : Form
    {
        public DosyaTransfer()
        {
            InitializeComponent();
        }

        bool FtpUpload(string ipAdresi, string port, string kullaniciAdi, string parola)
        {
            try
            {
                FileInfo dosyaBilgisi = new FileInfo(txtFileName.Text);
                string ftpAdresi = "ftp://" + ipAdresi + ":" + port + "/" + dosyaBilgisi.Name;
                FtpWebRequest ftpIstek = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpAdresi));
                ftpIstek.Credentials = new NetworkCredential(kullaniciAdi, parola);
                ftpIstek.KeepAlive = false;
                ftpIstek.Method = WebRequestMethods.Ftp.UploadFile;
                ftpIstek.UseBinary = true;
                ftpIstek.ContentLength = dosyaBilgisi.Length;
                int bufferUzunlugu = 2048;
                byte[] buff = new byte[10000000];
                int sayi;
                FileStream stream = dosyaBilgisi.OpenRead();
                Stream str = ftpIstek.GetRequestStream();
                sayi = stream.Read(buff, 0, bufferUzunlugu);
                while (sayi != 0)
                {
                    str.Write(buff, 0, sayi);
                    sayi = stream.Read(buff, 0, bufferUzunlugu);
                }
                str.Close();
                stream.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void btnSFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Fotoğraf |*.png;*.jpg;*.gif;*.ico| Belge |*.pdf;*.docx;*.ppt;*.xls;*.txt| Video & Ses |*.mp3;*.mp4;*.wav;*.avi;*.wpl;*.mpg;*.wmv| Tüm Dosyalar |*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fd.FileName;
            }
        }

        private void btnSendFile_Click_1(object sender, EventArgs e)
        {
            if (txtFileName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                FtpUpload("185.86.4.200", "21", txtUserName.Text, txtPassword.Text);
                MessageBox.Show("Dosya sisteme başarıyla yüklendi!");
            }
            else
            {
                MessageBox.Show("Lütfen dosya seçtiğinizden ve istenilen bilgileri girdiğinizden emin olunuz!");
            }
        }

        private void btnFilePath_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = fb.SelectedPath;
            }
        }

        private void btnDownload_Click_1(object sender, EventArgs e)
        {
            if (txtSavePath.Text!="" && txtFileN.Text!="" && txtUser.Text!="" && txtPass.Text!="")
            {
                string inputfilepath = txtSavePath.Text+@"\"+txtFileN.Text;
                string ftphost = "185.86.4.200:21";
                string ftpfilepath = "/" + txtFileN.Text;

                string ftpfullpath = "ftp://" + ftphost + ftpfilepath;

                using (WebClient istek = new WebClient())
                {
                    istek.Credentials = new NetworkCredential(txtUser.Text, txtPass.Text);
                    byte[] fileData = istek.DownloadData(ftpfullpath);

                    using (FileStream file = File.Create(inputfilepath))
                    {
                        file.Write(fileData, 0, fileData.Length);
                        file.Close();
                    }
                    MessageBox.Show("İndirme Tamamlandı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen gereki alanları doldurunuz!");
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Mesaj msj = new Mesaj();
            this.Hide();
            msj.Show();
        }

        private void DosyaTransfer_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "Administrator";
            txtPassword.Text = "FY1Z7uua8cX";
            txtUser.Text = "Administrator";
            txtPass.Text = "FY1Z7uua8cX";
        }
    }
}
