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
        DataTable table;
      
        string sorguAracBilgileri = "SELECT aracID,plaka,renkID,markaID,modelID,yakitID,tipID FROM AracBilgisi";
        string sorguAracKayit = "INSERT INTO AracBilgisi(plaka,renkID,markaID,modelID,yakitID,tipID) VALUES(@plaka,@renkID,@markaID,@modelID,@yakitID,@tipID)";
        string sorgumarka =     "SELECT markaID FROM AracMarka WHERE marka=@marka";
        string sorgurenk =      "SELECT renkID FROM Renkler WHERE renk = @renk";
        string sorgumodel =     "SELECT modelID FROM AracModel WHERE model=@model";
        string sorguyakit =     "SELECT yakitID FROM YakitTur WHERE yakit=@yakit";
        string sorgutip =       "SELECT tipID FROM AracTip WHERE tip=@tip";
        string sutunAdiPlaka = "plaka";
        string sutunAdiMarka = "marka";
        string sutunAdiRenk = "renk";
        string sutunAdiModel = "model";
        string sutunAdiTip = "tip";
        string sutunAdiYakit = "yakit";
        // DataGriddeKullanılacakSorgu ( idler yok)
        string sorguDataGridView = "SELECT AracBilgisi.aracID, AracBilgisi.plaka, Renkler.renk, AracMarka.marka, AracModel.model, YakitTur.yakit, AracTip.tip FROM AracBilgisi " +
                         "INNER JOIN Renkler   ON AracBilgisi.renkID  = Renkler.renkID " +
                          "INNER JOIN AracMarka ON AracBilgisi.markaID = AracMarka.markaID " +
                           "INNER JOIN AracModel ON AracBilgisi.modelID = AracModel.modelID " +
                            "INNER JOIN YakitTur  ON AracBilgisi.yakitID = YakitTur.yakitID " +
                             "INNER JOIN AracTip   ON AracBilgisi.tipID   = AracTip.tipID " +
                              " ORDER BY aracID DESC";


        // MarkaComboBox
        string sorgu;
        string sutun;
        int value;
        string BringDatasFromBoxes(ComboBox box) => box.SelectedItem.ToString();
        string BringDatasFromBoxes(TextBox box) => box.Text.ToString();
        bool aracKayitKosullari(ArrayList list)
        {
            bool value = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(null))
                {
                    value = false;
                }
            }
            return value;
        }
        ArrayList TableColumnsName(DataTable table)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Columns.Count; i++)
                list.Add(table.Columns[i].ColumnName.ToString());
            return list;
        }
        ArrayList ListValues()
        {
            ArrayList list = new ArrayList();
            list.Add(BringDatasFromBoxes(this.textBox1));
            list.Add(BringDatasFromBoxes(this.textBox2));
            list.Add((int)db.DataBaseSearchId(this.comboBoxRenkler,sorgurenk,sutunAdiRenk));
            list.Add(db.DataBaseSearchId(this.comboBoxMarka, sorgumarka,sutunAdiMarka));
            list.Add(db.DataBaseSearchId(this.comboBoxModel,sorgumodel, sutunAdiModel));
            list.Add(db.DataBaseSearchId(this.comboBoxYakit, sorguyakit, sutunAdiYakit));
            list.Add(db.DataBaseSearchId(this.comboBoxTip, sorgutip, sutunAdiTip));
            return list;
        }
        void aracKayitSil(TextBox box,string sutunAdi)
        {
            db.DeleteDataFromDataBase(box,sutunAdi);
        }
        void aracKayitEkle(string sorgu)
        {
            ArrayList columnNames = TableColumnsName(db.JustFillDataTable(sorguAracBilgileri));
            ArrayList values = ListValues();
            
            if(String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("hata : Plaka girin");
            }
            else
            {
                using(SqlCommand command = db.DataBaseCommand(sorgu))
               {
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
                        if (ex is SqlException) { MessageBox.Show("hata : plaka kayıtlı"); }

                    }

                }
            }
            
        }
        void AracKayitGuncelle()
        {
            ArrayList columnNames = TableColumnsName(db.JustFillDataTable(sorguAracBilgileri));
            ArrayList values = ListValues();
            db.UpdateDataFromDataBase(columnNames,values);
        }
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
        void AracKayitlariniListele(string sorgu)
        {
            table = new DataTable();
            db.ShowDatasOnDataGridView(table,dataGridView1,sorgu);
        }
        void MarkayaGoreModelListele()
        {
            comboBoxModel.Items.Clear();
            string sayi = (comboBoxMarka.SelectedIndex + 1).ToString();
            sorgu = "SELECT model FROM AracModel WHERE markaID =" +sayi ;
            sutun = "model";
            db.BringBrandsFromDataBaseToComboBox(comboBoxModel,sorgu,sutun);
        }
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
        
        public FormAracKayit()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAracKayit_Load(object sender, EventArgs e)
        {
            AracKayitlariniListele(sorguDataGridView);
            textBox1.Enabled = false;
            dataGridView1.CurrentCell = null;
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
            AracKayitlariniListele(sorguDataGridView);
            dataGridView1.CurrentCell = null;
            ClearAllBoxes();
            BringMarkaToComboBox();
            BringModelToComboBox();
            BringTipToComboBox();
            BringYakitToComboBox();
            BringRenklerToComboBox();
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
            aracKayitEkle(sorguAracKayit);
            AracKayitlariniListele(sorguDataGridView);
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
            aracKayitSil(this.textBox2,sutunAdiPlaka);
            AracKayitlariniListele(sorguDataGridView);
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
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            AracKayitGuncelle();
            AracKayitlariniListele(sorguDataGridView);
            ClearAllBoxes();
            BringMarkaToComboBox();
            BringModelToComboBox();
            BringTipToComboBox();
            BringYakitToComboBox();
            BringRenklerToComboBox();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
