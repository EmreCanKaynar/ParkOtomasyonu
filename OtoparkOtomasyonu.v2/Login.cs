using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OtoparkOtomasyonu.v2
{
    class Login : Form
    {
        // SqlKütüphanesi
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        // user tcno şifre
        private string tckimlikno, sifre;
        // değişkenler
        private string yetkitur;
        private bool yetkikontrol;
        private string query;
        //kontrol
        private bool kontroltcsifre ;
        private string sifrekontrol;
        private string connectionadress;


        // FONKSIYONLAR
        public Login()
        {
            yetkitur = null;
            yetkikontrol = false;
            bool kontroltcsifre = false;

            connectionadress = "Data Source=OGZCNKYNR\\SQLEXPRESS;Initial Catalog=OtoparkOtomasyonu;Integrated Security=True";
        }
        /// <summary>
        /// 
        /// </summary>
        public void SqlConnection()
        {
            connection = new SqlConnection(connectionadress);
        }

        /// <summary>
        /// SQL Giriş bilgilerini .....
        /// </summary>
        /// <param name="tckimlikno"></param>
        /// <param name="sifre"></param>
        public void sqlLogin(string tckimlikno, string sifre)
        {
            query = "SELECT tckimlikno,sifre FROM CalisanBilgisi WHERE tckimlikno=@tckimlikno AND sifre=@sifre";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sifre", sifre);
            command.Parameters.AddWithValue("@tckimlikno", tckimlikno);
            connection.Open();
            reader = command.ExecuteReader();

            while (reader.Read()) kontroltcsifre = (reader["tckimlikno"].ToString() == tckimlikno && reader["sifre"].ToString() == sifre) ? true : false;
            connection.Close();
        }
      
        public void sqlYetkiKontrol(string tckimlikno)
        {
            query = "SELECT yetkiID from CalisanBilgisi WHERE tckimlikno=@tckimlikno";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@tckimlikno", tckimlikno);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
                yetkitur = reader["yetkiID"].ToString();
            connection.Close();
        }
        public void AdminLogin(string tckimlikno,string sifre,FormGirisYap ad)
        {
            switch (yetkitur)
            {
                case "2":
                    MessageBox.Show("Bu kullanıcı 'ADMİN' dir.");
                    sqlLogin(tckimlikno, sifre);
                    if (kontroltcsifre == true)
                    {
                        MessageBox.Show("Giriş Başarılı");
                        kontroltcsifre = false;
                        FormAdminAnasayfa admin = new FormAdminAnasayfa();
                        admin.Show();
                    }
                    else
                        MessageBox.Show("Kullanıcı Adı ve Şifre hatalı");
                    break;
 
                case "1":
                    MessageBox.Show("Bu kullanıcı 'OPERATOR' dür.Operatör girişine yönlendiriyorsunuz.");
                    FormYapOperator op = new FormYapOperator();
                    op.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Hatalı giriş yaptınız veya kullanıcı kayıtlı değil");
                    break;
            }
            
            yetkitur = null;
        }
        public void OperatorLogin(string tckimlikno, string sifre,FormYapOperator op)
        {
            switch (yetkitur)
            {
                case "2":
                    MessageBox.Show("Bu kullanıcı 'ADMİN' dir. Admin Girişine Yönlendiriyorsunuz.");
                    FormGirisYap g = new FormGirisYap();
                    g.Show();
                    op.Hide();
                    break;
                case "1":
                    MessageBox.Show("Bu kullanıcı 'OPERATOR' dür.");
                    sqlLogin(tckimlikno, sifre);
                    if (kontroltcsifre == true)
                    {
                        MessageBox.Show("Giriş Başarılı");
                        kontroltcsifre = false;
                        //
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı ve Şifre hatalı");
                    }

                    break;
                default:
                    MessageBox.Show("Hatalı giriş yaptınız veya kullanıcı kayıtlı değil");
                    break;

            }
            /*
            if (yetkitur == "2")
            {
                MessageBox.Show("Bu kullanıcı 'ADMİN' dir. Admin Girişine Yönlendiriyorsunuz.");
                FormGirisYap g = new FormGirisYap();
                g.Show();
                op.Hide();
               
            }

            else if (yetkitur == "1")
            {
                MessageBox.Show("Bu kullanıcı 'OPERATOR' dür.");
                sqlLogin(tckimlikno, sifre);
                if (kontroltcsifre == true)
                {
                    MessageBox.Show("Giriş Başarılı");
                    kontroltcsifre = false;
                    //
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı ve Şifre hatalı");
                }
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız veya kullanıcı kayıtlı değil");
            }
            yetkitur = null;
            */

        }
            
    }
}
