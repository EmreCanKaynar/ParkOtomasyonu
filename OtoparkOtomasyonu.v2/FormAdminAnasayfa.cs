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
    public partial class FormAdminAnasayfa : Form
    {
        void FormGetir(Form form)
        {
           if(Application.OpenForms.Count>2)
                Application.OpenForms[2].Close();
            panel2.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }
        
        public FormAdminAnasayfa()
        {
            InitializeComponent();
        }

        private void FormAdminAnasayfa_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.LightBlue;

        }

        private void buttonMusteriKayit_Click(object sender, EventArgs e)
        {
            FormMusteriKayıt form = new FormMusteriKayıt();
            FormGetir(form);  
        }

        private void buttonAracKayit_Click(object sender, EventArgs e)
        {
            FormAracKayit form = new FormAracKayit();
            FormGetir(form);
        }
    }
}
