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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKaydol kaydol = new FormKaydol();
            kaydol.Show();
            this.Hide();
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            FormGirisYap girisyap = new FormGirisYap();
            girisyap.Show();
            this.Hide();
        }
    }
}
