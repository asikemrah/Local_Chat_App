using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Local_Chat_Uygulaması
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            chckShow.Checked = false;
            chckErkek.Checked = false;
            chckKadın.Checked = false;
            this.ActiveControl = txtAd;
            btnGuncelle.BackColor = Color.Transparent;
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
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" & txtSoyad.Text != "" & txtEposta.Text != "" & txtSifre.Text != "" & filepth != null)
            {
                if (txtAd.Text.Length <= 50 & txtSoyad.Text.Length <= 50 & txtEposta.Text.Length <= 70 & txtSifre.Text.Length <= 12)
                {
                    if (chckErkek.Checked || chckKadın.Checked)
                    {
                        KayitOl ko = new KayitOl();
                        ko.adi = txtAd.Text;
                        ko.soyadi = txtSoyad.Text;
                        string cins;
                        if (chckErkek.Checked)
                        {
                            cins = "Erkek";
                        }
                        else
                        {
                            cins = "Kadın";
                        }
                        ko.cinsiyeti = cins;
                        ko.epostasi = txtEposta.Text;
                        ko.sifresi = txtSifre.Text;
                        ko.resim = image;
                        ko.ayarguncel();
                        MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir.");
                        Properties.Settings.Default.u_eposta = txtEposta.Text;
                        Properties.Settings.Default.u_sifre = txtSifre.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen 'Cinsiyet' kısmını işaretleyiniz!");
                    }
                }
                else
                {
                    if (txtAd.Text.Length > 50)
                        MessageBox.Show("Adınız 50 karakterden uzun olamaz!");
                    else if (txtSoyad.Text.Length > 50)
                        MessageBox.Show("Soyadınız 50 karakterden uzun olamaz!");
                    else if (txtEposta.Text.Length > 70)
                        MessageBox.Show("E-posta adresiniz 70 karakterden uzun olamaz!");
                    else if (txtSifre.Text.Length > 12)
                        MessageBox.Show("Şifreniz 12 karakterden uzun olamaz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen eksik bilgileri doldurunuz ve profil fotoğrafı seçiniz!");
            }
        }

        private void chckShow_OnChange(object sender, EventArgs e)
        {
            if (chckShow.Checked)
            {
                txtSifre.isPassword = false;
            }
            else
            {
                txtSifre.isPassword = true;
            }
        }

        private void chckErkek_OnChange(object sender, EventArgs e)
        {
            if (chckErkek.Checked)
            {
                chckKadın.Enabled = false;
            }
            else
            {
                chckKadın.Enabled = true;
            }
        }

        private void chckKadın_OnChange(object sender, EventArgs e)
        {
            if (chckKadın.Checked)
            {
                chckErkek.Enabled = false;
            }
            else
            {
                chckErkek.Enabled = true;
            }
        }
        byte[] image;
        string filepth;

        private void pbAyarlar_Click(object sender, EventArgs e)
        {
            string defaultpf = Environment.CurrentDirectory + @"\KullanıcıPF";
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyası |*.jpg;*.png";
            resim.InitialDirectory = defaultpf;
            if (resim.ShowDialog() == DialogResult.OK)
            {
                filepth = resim.FileName;
                FileInfo fi = new FileInfo(filepth);
                long sayac = fi.Length;
                if (sayac <= 3145728)
                {
                    pbAyarlar.ImageLocation = filepth;
                    pbAyarlar.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Lütfen 3 MB'den daha küçük bir fotoğraf seçiniz!");
                }
                FileStream fs = new FileStream(filepth, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtEposta_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEposta.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEposta.Text))
                {
                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
