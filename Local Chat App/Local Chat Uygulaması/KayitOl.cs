using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Local_Chat_Uygulaması
{
    public class KayitOl
    {
        public static int id;
        private string ad, soyad, cinsiyet, eposta, sifre;
        public byte[] resim;
        public string conStr = "Server=.;Database=LocalChat;Trusted_Connection=True;";
        public string adi 
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string soyadi
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string cinsiyeti
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }
        public string epostasi
        {
            get
            {
                return eposta;
            }
            set
            {
                eposta = value;
            }
        }
        public string sifresi
        {
            get
            {
                return sifre;
            }
            set
            {
                sifre = value;
            }
        }

        public void kaydet()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Uye values(@name,@surname,@gender,@email,@password,@pf)",con);
            cmd.Parameters.AddWithValue("@name",ad);
            cmd.Parameters.AddWithValue("@surname", soyad);
            cmd.Parameters.AddWithValue("@gender", cinsiyet);
            cmd.Parameters.AddWithValue("@email", eposta);
            cmd.Parameters.AddWithValue("@password", sifre);
            cmd.Parameters.Add("@pf", SqlDbType.Image,resim.Length).Value=resim;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public void guncelle()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Uye set uye_sifre=@sifre where uye_eposta=@eposta",con);
            cmd.Parameters.AddWithValue("@sifre",sifre);
            cmd.Parameters.AddWithValue("@eposta",eposta);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ayarguncel()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Uye set uye_ad=@name, uye_soyad=@surname, uye_cinsiyet=@gender, uye_eposta=@email, uye_sifre=@password, uye_pf=@pf where uye_id=@id ", con);
            cmd.Parameters.AddWithValue("@name", ad);
            cmd.Parameters.AddWithValue("@surname", soyad);
            cmd.Parameters.AddWithValue("@gender", cinsiyet);
            cmd.Parameters.AddWithValue("@email", eposta);
            cmd.Parameters.AddWithValue("@password", sifre);
            cmd.Parameters.Add("@pf", SqlDbType.Image, resim.Length).Value = resim;
            cmd.Parameters.AddWithValue("@id",id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
