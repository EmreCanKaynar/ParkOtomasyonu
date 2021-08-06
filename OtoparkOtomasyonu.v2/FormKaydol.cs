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
    public partial class FormKaydol : Form
    {
        // DATABASE TEXTBOX KONTROLLERİ
        bool tckimlikkontrol;
        bool sifrekontrol ;
        bool adkontrol ;
        bool soyadkontrol ;
        bool telnokontrol ;
        bool emailkontrol ;
        bool yetkikontrol;
        bool sifretekrarkontrol;

        // yetki kontrol
        int yetki;       

        // db tanımlamaları
        string query;
        static string connectionadress = "Data Source=OGZCNKYNR\\SQLEXPRESS;Initial Catalog=OtoparkOtomasyonu;Integrated Security=True";
        static SqlConnection connection;
        SqlCommand command;
       public static bool PasswordControl(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDecimalDigit = false;
            bool hasPunctuation = false;

            foreach(char c in password)
            {
               if (char.IsDigit(c)) { hasDecimalDigit = true; }
               else if (char.IsLower(c)) { hasLowerCase = true; }
               else if (char.IsUpper(c)) { hasUpperCase = true; }
               else if (char.IsPunctuation(c)) { hasPunctuation = true; }
            }
            bool allConditions =    hasUpperCase
                                 && hasLowerCase
                                 && hasDecimalDigit
                                 && hasPunctuation
                                 ;
            return allConditions;
        }
        public static void SqlConnection()
        {
            connection = new SqlConnection(connectionadress);
        }
        static public SqlConnection sqlBaglanti()
        {
            connection = new SqlConnection(connectionadress);
            return connection;
        }
        void SqlSignUp()
        {
            query = "INSERT INTO CalisanBilgisi(tckimlikno,ad,soyad,telNo,eMail,yetkiID,sifre,kayitTarih) VALUES(@tckimlikno,@ad,@soyad,@telNo,@eMail,@yetkiID,@sifre,@kayitTarih)";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@tckimlikno",textBoxtc.Text);
            command.Parameters.AddWithValue("@ad", textBoxad.Text.ToLower());
            command.Parameters.AddWithValue("@soyad", textBoxsoyad.Text.ToLower());
            command.Parameters.AddWithValue("@telNo", textBoxtelno.Text);
            command.Parameters.AddWithValue("@eMail", textBoxemail.Text.ToString()+comboBox1.SelectedItem.ToString());
            command.Parameters.AddWithValue("@yetkiID", YetkiKontrol());
            command.Parameters.AddWithValue("@sifre", textBoxsifre.Text);
            command.Parameters.AddWithValue("@kayitTarih" ,DateTime.Now);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        int YetkiKontrol()
        {
            if (comboBoxyetki.SelectedIndex == 0)
            {
                yetki = 1;
            }
            else if (comboBoxyetki.SelectedIndex == 1)
            {
                yetki = 2;
            }
            return yetki;
        }
        
       
        
        public FormKaydol()
        {
            InitializeComponent();
        }

        private void FormKaydol_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxyetki.SelectedIndex == -1)
            {
                yetkikontrol = false;
            }
            else
            {
                labelyetkikontrol.Visible = false;
                yetkikontrol = true;
            }
           
            
        }

        private void labeltckontrol_Click(object sender, EventArgs e)
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

        private void textBoxad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxtc_TextChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (textBoxtc.Text.Length != 11)
            {
                labeltckontrol.Visible = true;
                labeltckontrol.ForeColor = Color.Red;
                labeltckontrol.Text = "* Tc kimlik numarası 11 haneli olmalıdır!";
                tckimlikkontrol = false;
            }
            else
            {
                tckimlikkontrol=true;
                labeltckontrol.Visible = false;
            }
        }

        private void textBoxad_TextChanged(object sender, EventArgs e)
        {
            if (textBoxad.Text.Length < 2)
            {
                labeladkontrol.Visible = true;
                labeladkontrol.ForeColor = Color.Red;
                labeladkontrol.Text = "* 'Adınız' alanı boş olamaz!";
                adkontrol = false;

            }
            else
               
            {
                adkontrol = true;
                labeladkontrol.Visible = false;
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
          
            if (textBoxtelno.Text.Length != 10)
            {
                labeltelnokontrol.Visible = true;
                labeltelnokontrol.ForeColor = Color.Red;
                labeltelnokontrol.Text = "* Telefon numaranız 10 haneli olmalı!";

            }
            else
            {
                labeltelnokontrol.Visible = false;
            }
        }

        private void textBoxsoyad_TextChanged(object sender, EventArgs e)
        {
            if (textBoxsoyad.Text.Length < 2)
            {
                soyadkontrol = false;
                labelsoyadkontrol.Visible = true;
                labelsoyadkontrol.ForeColor = Color.Red;
                labelsoyadkontrol.Text = "* 'Soyadınız' alanı boş olamaz!";
            }
            else
            {
                soyadkontrol = true;
                labelsoyadkontrol.Visible = false;
            }
        }

        private void textBoxsifre_TextChanged(object sender, EventArgs e)
        {
            if(textBoxsifre.Text.Length < 5)
            {
                labelsifrekontrol.Visible = true;
                labelsifrekontrol.ForeColor = Color.Red;
                labelsifrekontrol.Text = "* Şifre güvenlik gereği en az 5 haneli olmalıdır!";
                sifrekontrol = false;
            }
            else
            {
               labelsifrekontrol.Visible= false;
                sifrekontrol = true;
            }




            if(textBoxsifre.Text.ToString() != textBoxsifretekrar.Text.ToString())
            {
                labelsifretekrarkontrol.Visible = true;
                labelsifretekrarkontrol.ForeColor = Color.Red;
                labelsifretekrarkontrol.Text = "* Şifreler aynı olmak zorundadır!";
            }
            else
            {
                labelsifretekrarkontrol.Visible = false;
            }


        }

        private void textBoxsifretekrar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxsifre.Text.ToString() != textBoxsifretekrar.Text.ToString())
            {
                labelsifretekrarkontrol.Visible = true;
                labelsifretekrarkontrol.ForeColor = Color.Red;
                labelsifretekrarkontrol.Text = "* Şifreler aynı olmak zorundadır!";
                sifretekrarkontrol = false;
            }
            else
            {
                sifretekrarkontrol = true;
                labelsifretekrarkontrol.Visible = false;
            }
        }

        private void buttonKayıtOl_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tckimlikkontrol.ToString() + telnokontrol.ToString() + adkontrol.ToString() + soyadkontrol.ToString() + emailkontrol.ToString() + sifrekontrol.ToString() + sifretekrarkontrol.ToString() + yetkikontrol.ToString());
            try
            {
                SqlConnection();
                if(tckimlikkontrol && telnokontrol & adkontrol && soyadkontrol && emailkontrol && sifrekontrol && sifretekrarkontrol && yetkikontrol)
                {
                    SqlSignUp();
                    MessageBox.Show("Kayıt Olundu");
                    FormGirisYap girisyap = new FormGirisYap();
                    girisyap.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurun.");
                }
                
            }
            catch
            {
                MessageBox.Show("Hata : buttonKayitOl_Click");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void textBoxtelno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtelno_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxtelno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (textBoxtelno.MaskFull)
            {
                telnokontrol = true;
            }
            else
            {
                telnokontrol = false;
            }
        }

        private void textBoxtelno_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {
            if(textBoxemail.Text.Length < 3)
            {
                labelemailkontrol.Visible = true;
                labelemailkontrol.Text = "Geçerli bir e-mail adresi girilmelidir.";
                labelemailkontrol.ForeColor = Color.Red;
                emailkontrol = false;

            }
            else
            {
                emailkontrol = true;
                labelemailkontrol.Visible = false;

            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
