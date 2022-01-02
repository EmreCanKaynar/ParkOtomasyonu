using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu.v2
{
    public partial class FormYapOperator : Form
    {
        public FormYapOperator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void labelbaslik_Click(object sender, EventArgs e)
        {

        }

        private void buttonGirisYAP_Click(object sender, EventArgs e)
        {
            Login deneme = new Login();
            deneme.SqlConnection();
            deneme.sqlYetkiKontrol(textBoxtc.Text.ToString());
            deneme.OperatorLogin(textBoxtc.Text.ToString(), textBoxsifre.Text.ToString(),this);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
