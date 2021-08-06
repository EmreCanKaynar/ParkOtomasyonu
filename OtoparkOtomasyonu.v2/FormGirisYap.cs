using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OtoparkOtomasyonu.v2
{
    public partial class FormGirisYap : Form
    {
        Login deneme = new Login();
        
        /*
        string yetkitur=null;
        bool yetkikontrol=false;
        //kontrol
        bool kontroltcsifre = false;
        string query;
        string sifrekontrol;
        string connectionadress = "Data Source=OGZCNKYNR\\SQLEXPRESS;Initial Catalog=OtoparkOtomasyonu;Integrated Security=True";
        SqlConnection connection;

        SqlCommand command;
        SqlDataReader reader;
        public void SqlConnection()
        {
            connection = new SqlConnection(connectionadress);

        }
        public void sqlLogin()
        {
            query = "SELECT tckimlikno,sifre FROM CalisanBilgisi WHERE tckimlikno=@tckimlikno AND sifre=@sifre";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sifre", textBoxsifre.Text);
            command.Parameters.AddWithValue("@tckimlikno", textBoxtc.Text);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read()) {
                if (reader["tckimlikno"].ToString() == textBoxtc.Text.ToString() && reader["sifre"].ToString() ==textBoxsifre.Text.ToString())
                {
                    kontroltcsifre = true;
                }
                else
                {
                    kontroltcsifre = false;
                }

                
            }
            connection.Close();

        }
        public void sqlYetkiKontrol()
        {
            
            query = "SELECT yetkiID from CalisanBilgisi WHERE tckimlikno=@tckimlikno";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@tckimlikno", textBoxtc.Text);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read()) { 
            yetkitur = reader["yetkiID"].ToString();
            }
            connection.Close();
        }
        */

        public FormGirisYap()
        {
            InitializeComponent();
        }

        private void FormGirisYap_Load(object sender, EventArgs e)
        {
            

        }

        private void FormGirisYap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
            

        private void buttonGirisYAP_Click(object sender, EventArgs e)
        {
            deneme.SqlConnection();
            deneme.sqlYetkiKontrol(textBoxtc.Text.ToString());
            deneme.AdminLogin(textBoxtc.Text.ToString(),textBoxsifre.Text.ToString(),this);
            
            /*

                SqlConnection();
                sqlYetkiKontrol();
            if (yetkitur == "2")
            {
                MessageBox.Show("Bu kullanıcı 'ADMİN' dir.");
                sqlLogin();
                if (kontroltcsifre == true)
                {
                    MessageBox.Show("Giriş Başarılı");
                    kontroltcsifre = false;
                    //
                    FormAdminAnasayfa admin = new FormAdminAnasayfa();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı ve Şifre hatalı");
                }
            }

            else if(yetkitur == "1")
            {
                MessageBox.Show("Bu kullanıcı 'OPERATOR' dür.Operatör girişine yönlendiriyorsunuz.");
                FormYapOperator op = new FormYapOperator();
                op.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız veya kullanıcı kayıtlı değil");
            }
            
            yetkitur = null;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void textBoxsifre_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
