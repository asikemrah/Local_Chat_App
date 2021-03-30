using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Local_Chat_Uygulaması
{
    public partial class Mesaj : Form
    {
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string receive;
        public string TextToSend;
        public Mesaj()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress adress in localIP)
            {
                if (adress.AddressFamily==AddressFamily.InterNetwork)
                {
                    txtserverIP.Text = adress.ToString();
                }
            }
        }
        KayitOl ko = new KayitOl();
        private void Mesaj_Load(object sender, EventArgs e)
        {
            btnGonder.BackColor = Color.Transparent;
            this.ActiveControl = txtMesaj;
            SqlConnection con = new SqlConnection(ko.conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select msj_icerik from Mesajlar where uye_id=@id",con);
            cmd.Parameters.AddWithValue("@id", KayitOl.id);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                lbChat.Items.Add("Ben: "+sdr["msj_icerik"]);
            }
            con.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            this.Hide();
            grs.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayr = new Ayarlar();
            this.Hide();
            ayr.Show();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtMesaj.Text.Trim()!="" & txtMesaj.Text.Length<=200)
            {
                TextToSend = txtMesaj.Text;
                backgroundWorker2.RunWorkerAsync();
                SqlConnection con = new SqlConnection(ko.conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Mesajlar(uye_id,msj_icerik,msj_tarih) values(@u_id,@mesaj,@tarih)",con);
                cmd.Parameters.AddWithValue("@u_id",KayitOl.id);
                cmd.Parameters.AddWithValue("@mesaj",txtMesaj.Text);
                cmd.Parameters.AddWithValue("@tarih",DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Boş veya tek seferde 200'den daha fazla karakter içeren mesajlar gönderilemez!");
            }
            txtMesaj.Text = "";
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if(txtclientIP.Text!="" && txtclientPort.Text!="")
            {
                client = new TcpClient();
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(txtclientIP.Text),int.Parse(txtclientPort.Text));
                try
                {
                    client.Connect(IpEnd);
                    if(client.Connected)
                    {
                        lbChat.Items.Add("Sohbet'e bağlanıldı."+"\n");
                        str = new StreamReader(client.GetStream());
                        stw = new StreamWriter(client.GetStream());
                        stw.AutoFlush = true;
                        backgroundWorker1.RunWorkerAsync();
                        backgroundWorker2.WorkerSupportsCancellation = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Lütfen bağlanacağınız kişinin local ip ve port bilgilerini giriniz!");
            }
        }


        private void btnFileTransfer_Click(object sender, EventArgs e)
        {
            DosyaTransfer dt = new DosyaTransfer();
            this.Hide();
            dt.Show();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (txtserverIP.Text!="" && txtserverPort.Text!="")
            {
                TcpListener listener = new TcpListener(IPAddress.Any,int.Parse(txtserverPort.Text));
                listener.Start();
                client = listener.AcceptTcpClient();
                str = new StreamReader(client.GetStream());
                stw = new StreamWriter(client.GetStream());
                stw.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            else
            {
                MessageBox.Show("Lütfen local ip ve port bilgilerini giriniz!");
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = str.ReadLine();
                    this.lbChat.Invoke(new MethodInvoker(delegate()
                    {
                        lbChat.Items.Add("Arkadaşın: "+receive+"\n");
                    }));
                    receive = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(TextToSend);
                this.lbChat.Invoke(new MethodInvoker(delegate()
                {
                    lbChat.Items.Add("Ben: "+TextToSend+"\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending Failed!");
            }
            backgroundWorker2.CancelAsync();
        }
    }
}
