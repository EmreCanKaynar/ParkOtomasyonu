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
using System.Collections;

namespace OtoparkOtomasyonu.v2
{
    class Veritabani
    {

        SqlDataReader reader;
        string deletionQueryPlaka;
        string updateQuery;
        string connectionPath = "Data Source=OGZCNKYNR\\SQLEXPRESS;Initial Catalog=OtoparkOtomasyonu;Integrated Security=True";
        public Veritabani()
        {
            deletionQueryPlaka = "DELETE FROM AracBilgisi WHERE plaka=@plaka";
            updateQuery = "UPDATE AracBilgisi " +
                          "SET plaka=@plaka,renkID=@renkID,markaID=@markaID,modelID=@modelID,yakitID=@yakitID,tipID=@tipID " +
                          "WHERE aracID=@aracID";
        }
        public SqlConnection DataBaseConnect(string dbConnect) => new SqlConnection(dbConnect); 
        public SqlCommand DataBaseCommand(string sorgu) => new SqlCommand(sorgu, DataBaseConnect(connectionPath));
        // Müşterinin tüm verilerini çekmesi için Dataset için kullanılacak olan modül
        public SqlDataAdapter DataBaseAdapter(string sorgu) => new SqlDataAdapter(DataBaseCommand(sorgu));
        // 'AracBilgisi' tablosundan  combobox'a PLAKA BİLGİSİ ÇEKİYOR
        public void BringBrandsFromDataBaseToComboBox(ComboBox box, string sorgu, string sutunAdi) 
        {
            using (SqlCommand command = DataBaseCommand(sorgu))
            {
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    box.Items.Add(reader[sutunAdi]);
                }
                command.Connection.Close();
            }
            /*
            DataBaseCommand(sorgu).Connection.Open();
            reader = DataBaseCommand(sorgu).ExecuteReader();
            while (reader.Read())
            {
                box.Items.Add(reader[sutunAdi]);
            }
            DataBaseCommand(sorgu).Connection.Close();
            */
        }
       // 'MusteriBilgisi' tablosundan datagridView'a TÜM BİLGİLERİ ÇEKİYOR 
        public void ShowDatasOnDataGridView(DataTable datatable,DataGridView datagrid,string sorgu) 
        {
            DataBaseAdapter(sorgu).Fill(datatable); 
            datagrid.DataSource = datatable;
        }
        public int DataBaseSearchId(ComboBox box,string sorgu,string sutun)
        {

            int value=404;
            if (box.SelectedIndex!=-1)
                using (SqlCommand command = DataBaseCommand(sorgu))
                {
                    command.Parameters.Add("@" + sutun, SqlDbType.NVarChar).Value = box.SelectedItem.ToString();
                    command.Connection.Open();
                    reader = command.ExecuteReader();
                    value = (reader.Read()) ? reader.GetInt32(0) :0;
                }
            else
            {
                MessageBox.Show("Hata : Zorunlu Alanları Doldurunuz : " + box.Name.ToString());
            }
            return value;
        }
        public int DataBaseSearchId(TextBox box, string sorgu, string sutun)
        {
            int value = 0;
            using (SqlCommand command = DataBaseCommand(sorgu))
            {
                command.Parameters.Add("@" + sutun, SqlDbType.NVarChar).Value = box.Text.ToString();
                command.Connection.Open();
                reader = command.ExecuteReader();
                value = (reader.Read()) ? reader.GetInt32(0) : 0;
                return value;
            }
        }
        public DataTable JustFillDataTable(string sorgu)
        {
            DataTable datatable = new DataTable();
            DataBaseAdapter(sorgu).Fill(datatable);
            return datatable;
        }
        public void DeleteDataFromDataBase(TextBox box,string sutunAdi)
        {
            try
            {
                using (SqlCommand command = DataBaseCommand(deletionQueryPlaka))
                {
                    command.Parameters.Add("@" + sutunAdi, SqlDbType.NVarChar).Value = box.Text.ToString();
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
            }
            catch(Exception e)
            {
                if(e is SqlException)
                {
                    MessageBox.Show("hata : Bu plaka bir müşteriye kayıtlıdır. Silinemez");
                }
            }
           
        }
        public void DeleteDataFromDataBase(TextBox box,string sorgu,string sutunAdi)
        {
            using (SqlCommand command = DataBaseCommand(sorgu))
            {
                command.Parameters.Add("@" + sutunAdi, SqlDbType.NVarChar).Value = box.Text.ToString();
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
        public void UpdateDataFromDataBase(ArrayList columnNames,ArrayList values)
        {
            using(SqlCommand command = DataBaseCommand(updateQuery))
            {
                try
                {
                    for (int i = 0; i < columnNames.Count; i++)
                    {
                        command.Parameters.AddWithValue("@" + columnNames[i], values[i]);
                    }
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                
                 catch (Exception ex)
                {
                    if (ex is SqlException) { MessageBox.Show("hata : plaka kayıtlı veya Zorunlu Alan boş!"); }

                }
            }
        }
        public void UpdateDataFromDataBase(ArrayList columnNames, ArrayList values,string sorgu)
        {
            using (SqlCommand command = DataBaseCommand(sorgu))
            {
                try
                {
                    for (int i = 0; i < columnNames.Count; i++)
                    {
                        command.Parameters.AddWithValue("@" + columnNames[i], values[i]);
                    }
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }

                catch (Exception ex)
                {
                    if (ex is SqlException) { MessageBox.Show("hata : plaka kayıtlı veya Zorunlu Alan boş!"); }

                }
            }
        }
        public void AddDataToDataBase(string sorgu)
        {
            using (SqlCommand command = DataBaseCommand(sorgu)) {
               

            }
        }
    }
}

