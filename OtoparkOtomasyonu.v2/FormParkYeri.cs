using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu.v2
{
    public partial class FormParkYeri : Form
    {
        Veritabani vt = new Veritabani();
        SorguSutun ss = new SorguSutun();
        public int otoparkKatSayisi = 4;
        public int otoparkKonumSayisi = 10;
        static bool kontrol = true;


        
        public FormParkYeri()
        {
            InitializeComponent();
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
            int kat = Convert.ToInt32(comboBoxKat.SelectedIndex.ToString()); // kaçıncı kat?
            int konum = Convert.ToInt32(comboBoxKonum.SelectedIndex.ToString()); // kaçıncı konum?

            ArrayList list = new ArrayList();
            list.Add(vt.DataBaseSearchId(this.comboBoxPlaka, ss.sorguAracID, ss.sutunAdiPlaka));
            list.Add(DateTime.Now);
            list.Add(DBNull.Value);
            list.Add(ReturnKonumIDForParking());
            list.Add(25);
            list.Add(DBNull.Value);
            return list;
        }
        int ReturnKonum()
        {
            return Convert.ToInt32(comboBoxKonum.SelectedIndex.ToString()); 
        }
        int ReturnKat()
        {
            return Convert.ToInt32(comboBoxKat.SelectedIndex.ToString()); // kaçıncı kat?
        }
        int ReturnButtonValueForList()
        {
            return (ReturnKat() * 10) + ReturnKonum();
        }
        int ReturnKonumIDForParking()
        { 
            return (ReturnKat() * 10) + ReturnKonum() + 1;
        }
        void DoluParkYerleriniKirmiziYap()
        {
            List<Button> list = ListOfButtons();
            for (int i = 1; i <= list.Count; i++)
            {
                if (!KonumBosMu(ss.sorguKonumBosMu, ss.sutunAdiKonum,i))
                {
                    ButtonlariKirmiziYap(list[i-1]);
                }
                else
                {
                    ButtonlariYesilYap(list[i - 1]);
                }
            }
           
        }
        void AracParkEt(string sorgu)
        {
        
            using (SqlCommand command = vt.DataBaseCommand(sorgu))
            {
                ArrayList columnNames = TableColumnsName(vt.JustFillDataTable(ss.sorguPark));
                ArrayList values = ListValues();
                
                    for (int columnIndex = 0; columnIndex < columnNames.Count-1; columnIndex++)
                        command.Parameters.AddWithValue("@" + columnNames[columnIndex + 1].ToString(), values[columnIndex]);

                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
               
                columnNames.Clear();
                values.Clear();
            }

        }
        void AracParkKontrol()
        {
            if (comboBoxKonum.SelectedIndex == -1 || comboBoxKat.SelectedIndex == -1 || comboBoxPlaka.SelectedIndex == -1)
            {
                MessageBox.Show("Plaka,Kat ve konum belirtin");
            }
            else
            {
                string plaka = comboBoxPlaka.SelectedItem.ToString();
                DialogResult result = MessageBox.Show(plaka + " plakayi seçili olan konuma kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (SeciliAracParkHalindeMi(ss.sorguAracParkHalindemi, ss.sutunAdiaracID))
                    {
                        List<Button> list = ListOfButtons();
                        MessageBox.Show("Plakası : " + plaka + " olan aracın girişi yapıldı");
                        AracParkEt(ss.sorguAracParkEt);
                        ParkYeriDoldur(ss.sorguKonumDoldur);
                    }
                    else
                    {
                        MessageBox.Show(this.comboBoxPlaka.SelectedItem.ToString()+" :Seçmiş olduğunuz araç zaten park halinde");
                    }
                }
            }
        }
        bool SeciliAracParkHalindeMi(string sorgu,string sutunAdi)
        {
            using(SqlCommand command = vt.DataBaseCommand(sorgu))
            {
                SqlDataReader reader;
                bool value = true;
                command.Parameters.AddWithValue("@" + sutunAdi, vt.DataBaseSearchId(this.comboBoxPlaka, ss.sorguAracID, ss.sutunAdiPlaka));
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    value = reader.GetBoolean(0);
                }
                command.Connection.Close();
                return value;
            }

        }
        void ParkHalindekiAraclariComboBoxaGetir()
        {
            comboBoxPlaka2.Items.Clear();
            List<int> list = vt.FindParkedVehicle(ss.sorguParkHalindekiAraclar);
          
            foreach (int value in list)
            {
                vt.BringToComboBox(this.comboBoxPlaka2, ss.sorguAracIDilePlakaGetir, ss.sutunAdiaracID,value);
            }
        }
        void ParkYeriDoldur(string sorgu)
        {
            using (SqlCommand command = vt.DataBaseCommand(sorgu))
            {
                bool value = false;
                command.Parameters.AddWithValue("@" + ss.sutunAdiKonum   , ReturnKonumIDForParking());
                command.Parameters.AddWithValue("@" + ss.sutunAdiIsEmpty , value);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            DoluParkYerleriniKirmiziYap();
        }
        void ComboBoxaYerlestir(ComboBox box,int value)
        {
            for (int i = 0; i <=value; i++)
            {
                box.Items.Add(i);
            }
        }
        void ButtonlariSariYap(Button button)
        {
            button.BackColor = Color.Yellow;
        }
        void ButtonlariYesilYap(Button button)
        {
            if (button.Enabled == false)
            {
                button.Enabled = true;
            }
            button.BackColor = Color.Lime;
        }
        void ButtonlariKirmiziYap(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.Red;
        }
        List<Button> ListOfButtons()
        {
            List<Button> list = new List<Button>();
            list.Add(button3);  //A0 --> db konumID : 1
            list.Add(button4);  //A1 --> db konumID : 2
            list.Add(button5);  //A2 --> db konumID : 3
            list.Add(button6);  //A3 --> db konumID : 4
            list.Add(button7);  //A4 --> db konumID : 5
            list.Add(button8);  //A5 --> db konumID : 6
            list.Add(button9);  //A6 --> db konumID : 7
            list.Add(button10); //A7 --> db konumID : 8
            list.Add(button11); //A8 --> db konumID : 9
            list.Add(button12); //A9 --> db konumID : 10

            list.Add(button22); //B0 --> db konumID : 11
            list.Add(button21); //B1 --> db konumID : 12
            list.Add(button20); //B2 --> db konumID : 13
            list.Add(button19); //B3 --> db konumID : 14
            list.Add(button18); //B4 --> db konumID : 15
            list.Add(button17); //B5 --> db konumID : 16
            list.Add(button16); //B6 --> db konumID : 17
            list.Add(button15); //B7 --> db konumID : 18
            list.Add(button14); //B8 --> db konumID : 19
            list.Add(button13); //B9 --> db konumID : 20

            list.Add(button32); //C0 --> db konumID : 21
            list.Add(button31); //C1 --> db konumID : 22
            list.Add(button30); //C2 --> db konumID : 23
            list.Add(button29); //C3 --> db konumID : 24
            list.Add(button28); //C4 --> db konumID : 25
            list.Add(button27); //C5 --> db konumID : 26
            list.Add(button26); //C6 --> db konumID : 27
            list.Add(button25); //C7 --> db konumID : 28
            list.Add(button24); //C8 --> db konumID : 29
            list.Add(button23); //C9 --> db konumID : 30

            list.Add(button42); //D0 --> db konumID : 31
            list.Add(button41); //D1 --> db konumID : 32
            list.Add(button40); //D2 --> db konumID : 33 
            list.Add(button39); //D3 --> db konumID : 34
            list.Add(button38); //D4 --> db konumID : 35
            list.Add(button37); //D5 --> db konumID : 36
            list.Add(button36); //D6 --> db konumID : 37
            list.Add(button35); //D7 --> db konumID : 38
            list.Add(button34); //D8 --> db konumID : 39
            list.Add(button33); //D9 --> db konumID : 40

            list.Add(button52); //E0 --> db konumID : 41
            list.Add(button51); //E1 --> db konumID : 42
            list.Add(button50); //E2 --> db konumID : 43
            list.Add(button49); //E3 --> db konumID : 44
            list.Add(button48); //E4 --> db konumID : 45
            list.Add(button47); //E5 --> db konumID : 46 
            list.Add(button46); //E6 --> db konumID : 47
            list.Add(button45); //E7 --> db konumID : 48
            list.Add(button44); //E8 --> db konumID : 49
            list.Add(button43); //E9 --> db konumID : 50

            return list;
        }
        public void PlakalariGetir()
        {
            comboBoxPlaka.Items.Clear();
            vt.BringBrandsFromDataBaseToComboBox(this.comboBoxPlaka, ss.sorguPlaka, ss.sutunAdiPlaka);
        }
        void ButtonClickIndex(int kat,int konum)
        {
            comboBoxKat.SelectedIndex = kat;
            comboBoxKonum.SelectedIndex = konum;
        }
        bool KonumBosMu(string sorgu,string sutunAdi)
        {
            
            using(SqlCommand command = vt.DataBaseCommand(sorgu))
            {
                SqlDataReader reader;
                bool konumBos =false;
               
                command.Parameters.AddWithValue("@" + sutunAdi, ReturnKonumIDForParking());
                command.Connection.Open();
                reader = command.ExecuteReader();
                if(reader.Read())
                {
                    konumBos = reader.GetBoolean(0);
                }
                else
                {
                    MessageBox.Show("okunamadi");
                }
                command.Connection.Close();
                return konumBos;
            }

        }
        bool KonumBosMu(string sorgu, string sutunAdi, int konumID)
        {

            using (SqlCommand command = vt.DataBaseCommand(sorgu))
            {
                SqlDataReader reader;
                bool konumBos = false;

                command.Parameters.AddWithValue("@" + sutunAdi, konumID);
                command.Connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    konumBos = reader.GetBoolean(0);
                }
                else
                {
                    MessageBox.Show("okunamadi");
                }
                command.Connection.Close();
                return konumBos;
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormParkYeri_Load(object sender, EventArgs e)
        {
            PlakalariGetir();
            ComboBoxaYerlestir(comboBoxKat,otoparkKatSayisi);
            ComboBoxaYerlestir(comboBoxKonum,otoparkKonumSayisi);
            DoluParkYerleriniKirmiziYap();
            ParkHalindekiAraclariComboBoxaGetir();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 0);
            ButtonlariSariYap(button3);


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracParkKontrol();
            ParkHalindekiAraclariComboBoxaGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParkHalindekiAraclariComboBoxaGetir();
           Console.WriteLine(SeciliAracParkHalindeMi(ss.sorguAracParkHalindemi, ss.sutunAdiaracID).ToString());


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 1);
            ButtonlariSariYap(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 2);
            ButtonlariSariYap(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 3);
            ButtonlariSariYap(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 4);
            ButtonlariSariYap(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 5);
            ButtonlariSariYap(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 6);
            ButtonlariSariYap(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 7);
            ButtonlariSariYap(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 8);
            ButtonlariSariYap(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(0, 9);
            ButtonlariSariYap(button12);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 0);
            ButtonlariSariYap(button22);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            comboBoxKat.SelectedIndex = 1;
            comboBoxKonum.SelectedIndex = 1;
            ButtonlariSariYap(button21);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 2);
            ButtonlariSariYap(button20);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 3);
            ButtonlariSariYap(button19);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 4);
            ButtonlariSariYap(button18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 5);
            ButtonlariSariYap(button17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 6);
            ButtonlariSariYap(button16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 7);
            ButtonlariSariYap(button15);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 8);
            ButtonlariSariYap(button14);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(1, 9);
            ButtonlariSariYap(button13);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 0);
            ButtonlariSariYap(button32);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 1);
            ButtonlariSariYap(button31);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 2);
            ButtonlariSariYap(button30);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 3);
            ButtonlariSariYap(button29);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 4);
            ButtonlariSariYap(button28);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 5);
            ButtonlariSariYap(button27);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 6);
            ButtonlariSariYap(button26);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 7);
            ButtonlariSariYap(button25);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 8);
            ButtonlariSariYap(button24);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(2, 9);
            ButtonlariSariYap(button23);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 0);
            ButtonlariSariYap(button42);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 1);
            ButtonlariSariYap(button41);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 2);
            ButtonlariSariYap(button40);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 3);
            ButtonlariSariYap(button39);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 4);
            ButtonlariSariYap(button38);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 5);
            ButtonlariSariYap(button37);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 6);
            ButtonlariSariYap(button36);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 7);
            ButtonlariSariYap(button35);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 8);
            ButtonlariSariYap(button34);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(3, 9);
            ButtonlariSariYap(button33);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 0);
            ButtonlariSariYap(button52);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 1);
            ButtonlariSariYap(button51);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 2);
            ButtonlariSariYap(button50);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 3);
            ButtonlariSariYap(button49);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 4);
            ButtonlariSariYap(button48);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 5);
            ButtonlariSariYap(button47);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 6);
            ButtonlariSariYap(button46);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 7);
            ButtonlariSariYap(button45);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 8);
            ButtonlariSariYap(button44);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            ButtonClickIndex(4, 9);
            ButtonlariSariYap(button43);
        }

        private void button3_TabIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button3);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button4);
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button5);
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button6);
        }

        private void button7_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button7);
        }

        private void button8_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button8);
        }

        private void button9_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button9);
        }

        private void button10_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button10);
        }

        private void button11_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button11);
        }

        private void button12_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button12);
        }

        private void button22_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button22);
        }

        private void button21_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button21);
        }

        private void button20_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button20);
        }

        private void button19_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button19);
        }

        private void button18_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button18);
        }

        private void button17_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button17);
        }

        private void button16_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button16);
        }

        private void button15_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button15);
        }

        private void button14_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button14);
        }

        private void button13_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button13);
        }

        private void button32_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button32);
        }

        private void button31_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button31);
        }

        private void button30_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button30);
        }

        private void button29_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button29);
        }

        private void button28_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button28);
        }

        private void button27_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button27);
        }

        private void button26_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button26);
        }

        private void button25_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button25);
        }

        private void button24_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button24);
        }

        private void button23_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button23);
        }

        private void button42_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button42);
        }

        private void button41_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button41);
        }

        private void button40_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button40);
        }

        private void button39_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button39);
        }

        private void button38_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button38);
        }

        private void button37_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button37);
        }

        private void button36_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button36);
        }

        private void button35_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button35);
        }

        private void button34_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button34);
        }

        private void button33_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button33);
        }

        private void button52_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button52);
        }

        private void button51_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button51);
        }

        private void button50_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button50);
        }

        private void button49_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button49);
        }

        private void button48_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button48);
        }

        private void button47_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button47);
        }

        private void button46_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button46);
        }

        private void button45_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button45);
        }

        private void button44_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button44);
        }

        private void button43_Leave(object sender, EventArgs e)
        {
            ButtonlariYesilYap(button43);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string name = "FormAracKayit";
            Form form = Application.OpenForms[name];
            kontrol = (form == null) ? false : true;

            switch (kontrol)
            {
                case false:
                    FormAracKayit arackayitform = new FormAracKayit();
                    arackayitform.ShowDialog();
                    break;
                case true:
                    form.BringToFront();
                    break;
            }
            
        }

    }
    }

