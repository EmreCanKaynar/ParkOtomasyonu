using System;
using System.Collections;
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
    public partial class FormMusteriKayıt : Form
    {
        Veritabani vt = new Veritabani();
        DataTable datatable = new DataTable();
        SorguSutun ss = new SorguSutun();
        static bool kontrol = true;
        byte guncellemeKontrolu = 0;
        /// <summary>
        /// Tablodaki sutun adlarını listeye ekler
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        ArrayList TableColumnsName(DataTable table)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Columns.Count; i++)
                list.Add(table.Columns[i].ColumnName.ToString());
            return list;
        }
        /// <summary>
        /// bir arrayliste comboboxlardaki değerleri atama işlemi yapar ve liste döndürür
        /// </summary>
        /// <returns></returns>
        ArrayList ListValues()
        {
            ArrayList list = new ArrayList();
            list.Add(textBox1.Text);
            list.Add(textBoxTC.Text);
            list.Add(textBoxAd.Text);
            list.Add(textBoxSoyad.Text);
            list.Add(vt.DataBaseSearchId(this.comboBoxPlaka,ss.sorguAracID,ss.sutunAdiPlaka));
            list.Add(25);
            list.Add(textBoxMail.Text);
        
            return list;
        }
        /// <summary>
        /// Musteri kayıt işlemlerinde gerekli herşeyin kontrolu
        /// </summary>
        /// <returns></returns>
        bool MusteriKayitKontrol()
        {
            bool value = textBoxTC.Text.Length < 11 ||
                         String.IsNullOrEmpty(textBoxTC.Text.ToString()) ||
                         String.IsNullOrEmpty(textBoxMail.Text.ToString()) ||
                         String.IsNullOrEmpty(textBoxAd.Text.ToString()) ||
                         String.IsNullOrEmpty(textBoxSoyad.Text.ToString()) ||
                         comboBoxPlaka.SelectedIndex == -1;
            return value;       
        }
        /// <summary>
        /// Güncelleme işleminde boxları kullanıma açıp kapatmak için
        /// </summary>
        void BoxesEnableOrDisable()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBoxTC.Enabled = false; textBoxAd.Enabled = false; textBoxSoyad.Enabled = false; textBoxSoyad.Enabled = false;
                textBoxMail.Enabled = false; comboBoxPlaka.Enabled = false;
            }
            else
            {
                textBoxTC.Enabled = true; textBoxAd.Enabled = true; textBoxSoyad.Enabled = true; textBoxSoyad.Enabled = true;
                textBoxMail.Enabled = true; comboBoxPlaka.Enabled = true;
            }
        }
        /// <summary>
        /// Guncelleme kontrolleri
        /// </summary>
        void guncellemeKontrolleri()
        {
            if (guncellemeKontrolu == 1)
            {
                textBoxTC.Enabled = true; textBoxAd.Enabled = true; textBoxSoyad.Enabled = true; textBoxSoyad.Enabled = true;
                textBoxMail.Enabled = true; comboBoxPlaka.Enabled = true;
                MessageBox.Show("Guncelleme kullanıma açıldı. Lütfen işlemlerinizi bitirip tekrar Güncelle'ye tıklayınız.");
            }
            if (guncellemeKontrolu == 2)
            {
                textBoxTC.Enabled = false; textBoxAd.Enabled =false; textBoxSoyad.Enabled = false; textBoxSoyad.Enabled = false;
                textBoxMail.Enabled = false; comboBoxPlaka.Enabled = false;
                if (MusteriKayitKontrol())
                {
                    MessageBox.Show("Zorunlu Kısımları Doldurunuz.");

                }
                else
                {
                    MessageBox.Show("Guncelleme başarıyla tamamlandı.");
                    MusteriGuncelle();
                   
                }
                
                guncellemeKontrolu = 0;
                datatable.Clear();
                vt.ShowDatasOnDataGridView(datatable, dataGridView1, ss.sorguDataGridViewMusteriBilgisi);
                ClearAllBoxes();
                dataGridView1.CurrentCell = null;
                PlakalariComboBoxaGetir();
            }
        }
        /// <summary>
        /// Plaka bilgilerini belirtilen comboboxa getirir
        /// </summary>
        public void PlakalariComboBoxaGetir()
        {
            vt.BringBrandsFromDataBaseToComboBox(this.comboBoxPlaka,ss.sorguPlaka,ss.sutunAdiPlaka);

        }
        /// <summary>
        /// Musteri kaydı için gerekli işlemler
        /// </summary>
        /// <param name="sorgu"></param>
        public void MusteriEkle(string sorgu)
        {
            using (SqlCommand command = vt.DataBaseCommand(sorgu))
            {
                ArrayList columnNames = TableColumnsName(vt.JustFillDataTable(ss.sorguMusteriBilgileri));
                ArrayList values = ListValues();
                try
                {
                    for (int columnIndex = 0; columnIndex < columnNames.Count - 1; columnIndex++)
                        command.Parameters.AddWithValue("@" + columnNames[columnIndex + 1].ToString(), values[columnIndex+1]);

                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                catch (Exception ex)
                {
                    if (ex is SqlException) { MessageBox.Show("hata :  eksik bilgi"); }

                }
                columnNames.Clear();
                values.Clear();
            }

        }
        /// <summary>
        /// Musteri mevcut kaydını guncellemek için gerekli işlemler
        /// </summary>
        public void MusteriGuncelle()
        {
            ArrayList columnNames = TableColumnsName(vt.JustFillDataTable(ss.sorguMusteriBilgileri));
            ArrayList listvalues = ListValues();
            vt.UpdateDataFromDataBase(columnNames, listvalues, ss.sorguMusteriKayitUpdate);
        }
        /// <summary>
        /// Seçili müşteri silmeye yarar.
        /// </summary>
        public void MusteriSil()
        {
            vt.DeleteDataFromDataBase(textBoxTC,ss.sorguMusteriKayitSil,ss.sutunAdiTC);
        }
        /// <summary>
        /// Bütün boxlar doluysa temizler
        /// </summary>
        public void ClearAllBoxes()
        {
            textBoxAd.Clear();
            textBoxMail.Clear();
            textBoxSoyad.Clear();
            textBoxTC.Clear();
            comboBoxPlaka.Items.Clear();
            comboBoxPlaka.ResetText();
        }
        public FormMusteriKayıt()
        {
            InitializeComponent();
        }
        private void FormMusteriKayıt_Load(object sender, EventArgs e)
        {
            PlakalariComboBoxaGetir();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            datatable.Clear();
            vt.ShowDatasOnDataGridView(datatable, dataGridView1, ss.sorguDataGridViewMusteriBilgisi);
            dataGridView1.CurrentCell = null;
            ClearAllBoxes();
            PlakalariComboBoxaGetir();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxTC, "Tc  kimlik numarası 11 haneli olmalıdır.");
            if(textBoxTC.Text.Length == 11)
            {
                errorProvider1.Clear();
            }
            
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
             if (MusteriKayitKontrol())
            {
                MessageBox.Show("hata : Lütfen zorunlu alanları doldurunuz.");
            }
            else
            {
                MusteriEkle(ss.sorguMusteriKayit);
                datatable.Clear();
                vt.ShowDatasOnDataGridView(datatable, dataGridView1, ss.sorguDataGridViewMusteriBilgisi);
                ClearAllBoxes();
                PlakalariComboBoxaGetir();
                dataGridView1.CurrentCell = null;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxPlaka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            BoxesEnableOrDisable();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            MusteriSil();
            datatable.Clear();
            vt.ShowDatasOnDataGridView(datatable, dataGridView1, ss.sorguDataGridViewMusteriBilgisi);
            dataGridView1.CurrentCell = null;
            ClearAllBoxes();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string name = "FormAracKayit";
            Form form = Application.OpenForms[name];
           kontrol = (form == null) ? false : true;
                
            switch (kontrol)
            {
                case false:
                    FormAracKayit arackayitform = new FormAracKayit();
                    arackayitform.Show();
                    break;
                case true:
                    form.BringToFront();
                    break;
            }
            /*
            if (kontrol)
            {
                FormAracKayit arackayitform = new FormAracKayit();
                arackayitform.Show();
                kontrol = false;
            }
            Form form = Application.OpenForms[name];
            if (form ==null)
            {
                kontrol = true;
            }
            */

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                guncellemeKontrolu++;
                guncellemeKontrolleri();
            }
            else
            {
                MessageBox.Show("Seçili bir satır yok,bir satır seçiniz.");
            }
        }
    }
          
        }
    

