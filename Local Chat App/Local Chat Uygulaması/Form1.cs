using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Local_Chat_Uygulaması
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        KayitOl ko = new KayitOl();
        private void Giris_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtEposta;
            btnGiris.BackColor = Color.Transparent;
            chckRemember.Checked = false;
            chckShow.Checked = false;
            if (Properties.Settings.Default.u_eposta != string.Empty)
            {
                txtEposta.Text = Properties.Settings.Default.u_eposta;
                txtSifre.Text = Properties.Settings.Default.u_sifre;
                chckRemember.Checked = true;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ko.conStr;
            con.Open();
            SqlCommand cmd = new SqlCommand("select uye_pf from Uye where uye_eposta=@eposta",con);
            cmd.Parameters.AddWithValue("@eposta",txtEposta.Text);
            Image u_resim = null;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                byte[] resim=(byte[])dr[0];
                MemoryStream ms = new MemoryStream(resim, 0, resim.Length);
                ms.Write(resim, 0, resim.Length);
                u_resim = Image.FromStream(ms,true);
                pbGiris.Image = u_resim;
                pbGiris.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            dr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtEposta.Text!="" & txtSifre.Text!="")
            {
                if (txtEposta.Text.Length<=70 & txtSifre.Text.Length<=12)
                {
                    if (chckRemember.Checked)
                    {
                        Properties.Settings.Default.u_eposta = txtEposta.Text;
                        Properties.Settings.Default.u_sifre = txtSifre.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.u_eposta = "";
                        Properties.Settings.Default.u_sifre = "";
                        Properties.Settings.Default.Save();
                    }
                    SqlConnection con = new SqlConnection("Server=.;Database=LocalChat;Trusted_Connection=True;");
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * from Uye where uye_eposta='" + txtEposta.Text + "' AND uye_sifre='" + txtSifre.Text + "'";
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Mesaj msj = new Mesaj();
                        this.Hide();
                        msj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen e-posta ve şifre bilgilerinizi kontrol ediniz!");
                    }
                    con.Close();

                }
                else
                {
                    if (txtEposta.Text.Length > 70)
                        MessageBox.Show("E-postanız 70 karakterden fazla olamaz!");
                    else if (txtSifre.Text.Length > 12)
                        MessageBox.Show("Şifreniz 12 karakterden fazla olamaz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen e-postanızı ve şifrenizi giriniz!");
            }
            KayitOl.id = cookie();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kyt = new Kayit();
            this.Hide();
            kyt.Show();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreUnuttum su = new SifreUnuttum();
            this.Hide();
            su.Show();
        }

        private void chckShow_OnChange(object sender, EventArgs e)
        {
            if (chckShow.Checked==false)
            {
                txtSifre.isPassword = true;
            }
            else
            {
                txtSifre.isPassword = false;
            }
        }

        public int cookie()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ko.conStr;
            con.Open();
            SqlCommand cmd = new SqlCommand("select uye_id from Uye where uye_eposta=@eposta",con);
            cmd.Parameters.AddWithValue("@eposta",txtEposta.Text);
            int u_id=(int)cmd.ExecuteScalar();
            con.Close();
            return u_id;
        }
    }
}
