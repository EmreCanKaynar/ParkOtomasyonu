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
    public partial class FormMusteriKayıt : Form
    {
        Veritabani vt = new Veritabani();
        DataTable datatable = new DataTable();

        // ComboBox atamaları için gerekenler ( COMBOBOX -plaka - AracBilgisi)
        private string comboBoxSorgu = "SELECT plaka FROM AracBilgisi";
        public string sutunAdi = "plaka";
        // Dataset atamaları için gerekenler ( DATAGRIDVIEW-MusteriBilgisi)
        private string dataGridViewSorgu = " SELECT * FROM MusteriBilgisi";

       void MusterileriListele()
        {
            datatable.Clear();
            try
            {
                // Musteri bilgilerini çekiyor
                vt.ShowDatasOnDataGridView(datatable,dataGridView1,dataGridViewSorgu);
                MessageBox.Show("Başarılı");
            }
            catch
            {
                MessageBox.Show("hata");
            }
        }
        void PlakaListele()
        {
            try
            {
                // plaka bilgilerini çekiyor
             //   vt.DataBaseData(vt.DataBaseCommand(comboBoxSorgu), comboBox1, sutunAdi);

            }
            catch
            {
                MessageBox.Show("HATA : Plaka bilgileri");
            }
        }
        public FormMusteriKayıt()
        {
            InitializeComponent();
        }
        private void FormMusteriKayıt_Load(object sender, EventArgs e)
        {
            PlakaListele();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            MusterileriListele();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                

           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
