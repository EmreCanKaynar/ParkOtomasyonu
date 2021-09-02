using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyonu.v2
{
    public partial class FormAracKayit : Form
    {
        Veritabani db = new Veritabani();
        SorguSutun ss = new SorguSutun();
        DataTable table;

        // MarkaComboBox
        string sorgu;
        string sutun;
        byte guncellemeKontrolu=0;
        /// <summary>
        /// Boxlardaki seçili itemi string olarak geri döndrürür
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        string BringDatasFromBoxes(ComboBox box) => box.SelectedItem.ToString();
        /// <summary>
        /// Boxlardaki seçili itemi string olarak geri döndrürür
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        string BringDatasFromBoxes(TextBox box) => box.Text.ToString();
        /// <summary>
        /// boxlarda item seçilimi değilmi kontrolünü sağlar ve ona göre bir bool değer döndürür
        /// </summary>
        /// <returns></returns>
        bool aracKayitKosullari()
        {
            bool value = string.IsNullOrEmpty(textBox2.Text.ToString()) ||
                         comboBoxYakit.SelectedIndex   == -1 ||
                         comboBoxTip.SelectedIndex     == -1 ||
                         comboBoxModel.SelectedIndex   == -1 ||
                         comboBoxMarka.SelectedIndex   == -1 ||
                         comboBoxRenkler.SelectedIndex == -1;
             
            return value;
        }
        /// <summary>
        /// sutun adlarını bir arrayliste atama işlemi yapar ve liste döndürür
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
            list.Add(BringDatasFromBoxes(this.textBox1));
            list.Add(BringDatasFromBoxes(this.textBox2));
            list.Add(db.DataBaseSearchId(this.comboBoxRenkler,ss.sorgurenk,ss.sutunAdiRenk));
            list.Add(db.DataBaseSearchId(this.comboBoxMarka, ss.sorgumarka,ss.sutunAdiMarka));
            list.Add(db.DataBaseSearchId(this.comboBoxModel, ss.sorgumodel, ss.sutunAdiModel));
            list.Add(db.DataBaseSearchId(this.comboBoxYakit, ss.sorguyakit, ss.sutunAdiYakit));
            list.Add(db.DataBaseSearchId(this.comboBoxTip, ss.sorgutip, ss.sutunAdiTip));
            return list;
        }
        /// <summary>
        /// seçili kaydı siler
        /// </summary>
        /// <param name="box"></param>
        /// <param name="sutunAdi"></param>
        void aracKayitSil(TextBox box,string sutunAdi)
        {
            db.DeleteDataFromDataBase(box,sutunAdi);
        }
        /// <summary>
        /// araç kayıt ekleme işlemini yapar
        /// </summary>
        /// <param name="sorgu"></param>
        void aracKayitEkle(string sorgu)
        {
          
            
            if(aracKayitKosullari())
            {
                MessageBox.Show("hata aracKayitKosul : Bütün alanlar doldurulmalıdır.");
            }
            else
            {
                using(SqlCommand command = db.DataBaseCommand(sorgu))
               {
                    ArrayList columnNames = TableColumnsName(db.JustFillDataTable(ss.sorguAracBilgileri));
                    ArrayList values = ListValues();
                    try
                    {
                        for (int columnIndex = 0; columnIndex < columnNames.Count - 1; columnIndex++)
                            command.Parameters.AddWithValue("@" + columnNames[columnIndex + 1].ToString(), values[columnIndex + 1]);

                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        if (ex is SqlException) { MessageBox.Show("hata : plaka kayıtlı veya eksik bilgi"); }

                    }
                    columnNames.Clear();
                    values.Clear();         
                }
            }
        }
        /// <summary>
        /// seçili sutunun güncelleme işlemini yapar
        /// </summary>
        void AracKayitGuncelle()
        {
            if (aracKayitKosullari())
            {
                MessageBox.Show("hata aracKayitKosul : Bütün alanlar doldurulmalıdır.");
            }
            else
            {
                ArrayList columnNames = TableColumnsName(db.JustFillDataTable(ss.sorguAracBilgileri));
                ArrayList values = ListValues();
                db.UpdateDataFromDataBase(columnNames, values);
            }
                
        }
        /// <summary>
        /// Bring ile başlayan fonksiyonlar ise comboboxlara veritabanından gerekli olan değerleri gönderir
        /// </summary>
        void BringMarkaToComboBox()
        {
            sorgu = "SELECT marka from AracMarka";
            sutun = "marka";
            db.BringBrandsFromDataBaseToComboBox(this.comboBoxMarka,sorgu, sutun);
        }
        void BringModelToComboBox()
        {
            sorgu = "SELECT model from AracModel";
            sutun = "model";
            db.BringBrandsFromDataBaseToComboBox(this.comboBoxModel,sorgu, sutun);
        }
        void BringYakitToComboBox()
        {
            sorgu = "SELECT yakit from YakitTur";
            sutun = "yakit";
            db.BringBrandsFromDataBaseToComboBox(this.comboBoxYakit,sorgu, sutun);
        }
        void BringTipToComboBox()
        {
            sorgu = "SELECT tip from AracTip";
            sutun = "tip";
            db.BringBrandsFromDataBaseToComboBox(this.comboBoxTip,sorgu ,sutun);
        }
        void BringRenklerToComboBox()
        {
            sorgu = "SELECT renk from Renkler";
            sutun = "renk";
            db.BringBrandsFromDataBaseToComboBox(this.comboBoxRenkler, sorgu, sutun);
        }
        /// <summary>
        /// DataGridView'a veritabanındaki AraçKayit hakkında herşeyi gönderir ve tablo üzerinde gösterir
        /// </summary>
        /// <param name="sorgu"></param>
        void AracKayitlariniListele(string sorgu)
        {
            table = new DataTable();
            db.ShowDatasOnDataGridView(table,dataGridView1,sorgu);
        }
        /// <summary>
        /// Seçili markaya göre modelleri comboboxa çeker
        /// </summary>
        void MarkayaGoreModelListele()
        {
            comboBoxModel.Items.Clear();
            string sayi = (comboBoxMarka.SelectedIndex + 1).ToString();
            sorgu = "SELECT model FROM AracModel WHERE markaID =" +sayi ;
            sutun = "model";
            db.BringBrandsFromDataBaseToComboBox(comboBoxModel,sorgu,sutun);
        }
        /// <summary>
        /// bütün comboboxları temizler
        /// </summary>
        void ClearAllBoxes()
        {
            comboBoxModel.Items.Clear();
            comboBoxMarka.Items.Clear();
            comboBoxYakit.Items.Clear();
            comboBoxTip.Items.Clear();
            comboBoxRenkler.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }
        /// <summary>
        /// Eğer seçili bir satır var ise bütün boxları kullanıma kapatır yoksa açar
        /// </summary>
        void BoxesEnableOrDisable()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                comboBoxMarka.Enabled = false; comboBoxRenkler.Enabled = false; comboBoxModel.Enabled = false; comboBoxYakit.Enabled = false;
                comboBoxTip.Enabled = false; comboBoxTip.Enabled = false; textBox2.Enabled = false;
            }
            else
            {
                comboBoxMarka.Enabled = true; comboBoxRenkler.Enabled = true; comboBoxModel.Enabled = true; comboBoxYakit.Enabled = true;
                comboBoxTip.Enabled = true; comboBoxTip.Enabled = true; textBox2.Enabled = true;
            }
        }
        /// <summary>
        /// güncelle butonuna basıldığında yapılması gereken kontrolleri sağlar
        /// </summary>
        void guncellemeKontrolleri()
        {
            if (guncellemeKontrolu == 1)
            {
                comboBoxMarka.Enabled = true; comboBoxRenkler.Enabled = true; comboBoxModel.Enabled = true; comboBoxYakit.Enabled = true;
                comboBoxTip.Enabled = true; comboBoxTip.Enabled = true; textBox2.Enabled = true;
                MessageBox.Show("Guncelleme kullanıma açıldı. Lütfen işlemlerinizi bitirip tekrar Güncelle'ye tıklayınız.");
            }
            if (guncellemeKontrolu == 2)
            {
                comboBoxMarka.Enabled = false; comboBoxRenkler.Enabled = false; comboBoxModel.Enabled = false; comboBoxYakit.Enabled = false;
                comboBoxTip.Enabled = false; comboBoxTip.Enabled = false; textBox2.Enabled = false;
                MessageBox.Show("Guncelleme başarıyla tamamlandı.");
                guncellemeKontrolu = 0;
                AracKayitGuncelle();
                AracKayitlariniListele(ss.sorguDataGridView);
                ClearAllBoxes();
                dataGridView1.CurrentCell = null;
                BringMarkaToComboBox(); BringModelToComboBox(); BringTipToComboBox(); BringYakitToComboBox(); BringRenklerToComboBox();
            }
        }
        
        public FormAracKayit()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAracKayit_Load(object sender, EventArgs e)
        {
           
            textBox1.Enabled = false;
            ClearAllBoxes();
            BringMarkaToComboBox();
            BringModelToComboBox();
            BringTipToComboBox();
            BringYakitToComboBox();
            BringRenklerToComboBox();
            
         

        }
        private void comboBoxRenkler_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            AracKayitlariniListele(ss.sorguDataGridView);
            ClearAllBoxes();
            BringMarkaToComboBox();
            BringModelToComboBox();
            BringTipToComboBox();
            BringYakitToComboBox();
            BringRenklerToComboBox();
            dataGridView1.CurrentCell.Selected = false;
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkayaGoreModelListele();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            aracKayitEkle(ss.sorguAracKayit);
            AracKayitlariniListele(ss.sorguDataGridView);
            ClearAllBoxes();
            BringMarkaToComboBox();
            BringModelToComboBox();
            BringTipToComboBox();
            BringYakitToComboBox();
            BringRenklerToComboBox();
            dataGridView1.CurrentCell = null;

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            aracKayitSil(this.textBox2,ss.sutunAdiPlaka);
            AracKayitlariniListele(ss.sorguDataGridView);
            ClearAllBoxes();
            BringMarkaToComboBox();
            BringModelToComboBox();
            BringTipToComboBox();
            BringYakitToComboBox();
            BringRenklerToComboBox();
            dataGridView1.CurrentCell = null;
        }

        private void comboBoxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxYakit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxRenkler.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxMarka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxModel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxYakit.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBoxTip.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            BoxesEnableOrDisable();
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBoxYakit.SelectedItem.ToString());
        }
    }
}
