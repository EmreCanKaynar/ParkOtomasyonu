using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu.v2
{
    class SorguSutun
    {
        // FormAraçKayit
        public string sorguAracBilgileri;
        public string sorguAracKayit;
        public string sorgumarka;
        public string sorgurenk;
        public string sorgumodel;
        public string sorguyakit;
        public string sorgutip;
        public string sutunAdiPlaka;
        public string sutunAdiMarka;
        public string sutunAdiRenk;
        public string sutunAdiModel;
        public string sutunAdiTip;
        public string sutunAdiYakit;
        public string sutunAdiTC;
        // DataGriddeKullanılacakSorgu ( idler yok)
        public string sorguDataGridView;
        public string sorguDataGridViewMusteriBilgisi;

        // FormMusteriKayit
        public string sorguPlaka;
        public string sorguAracID;
        public string sorguMusteriBilgileri;
        public string sorguMusteriKayit;
        public string sorguMusteriKayitSil;
        public string sorguMusteriKayitUpdate;


       public SorguSutun()
        {
            sorguAracBilgileri = "SELECT aracID,plaka,renkID,markaID,modelID,yakitID,tipID FROM AracBilgisi";
            sorguAracKayit =     "  INSERT INTO AracBilgisi(plaka,renkID,markaID,modelID,yakitID,tipID) VALUES(@plaka,@renkID,@markaID,@modelID,@yakitID,@tipID)";
            sorgumarka =         "SELECT markaID FROM AracMarka WHERE marka=@marka";
            sorgurenk =          "SELECT renkID FROM Renkler WHERE renk = @renk";
            sorgumodel =         "SELECT modelID FROM AracModel WHERE model=@model";
            sorguyakit =         "SELECT yakitID FROM YakitTur WHERE yakit=@yakit";
            sorgutip =           "SELECT tipID FROM AracTip WHERE tip=@tip";
            sorguDataGridView =  "SELECT AracBilgisi.aracID, AracBilgisi.plaka, Renkler.renk, AracMarka.marka, AracModel.model, YakitTur.yakit, AracTip.tip FROM AracBilgisi " +
                                 "INNER JOIN Renkler   ON AracBilgisi.renkID  = Renkler.renkID " +
                                 "INNER JOIN AracMarka ON AracBilgisi.markaID = AracMarka.markaID " +
                                 "INNER JOIN AracModel ON AracBilgisi.modelID = AracModel.modelID " +
                                 "INNER JOIN YakitTur  ON AracBilgisi.yakitID = YakitTur.yakitID " +
                                 "INNER JOIN AracTip   ON AracBilgisi.tipID   = AracTip.tipID " +
                                 " ORDER BY aracID DESC";
            sutunAdiPlaka = "plaka";
            sutunAdiMarka = "marka";
            sutunAdiModel = "model";
            sutunAdiRenk =  "renk";
            sutunAdiTip =   "tip";
            sutunAdiYakit = "yakit";
            sutunAdiTC = "tckimlikno";
            // FromMusteriKayit
            sorguDataGridViewMusteriBilgisi = "SELECT MusteriBilgisi.musteriID,MusteriBilgisi.tckimlikno,MusteriBilgisi.ad,MusteriBilgisi.soyad,AracBilgisi.plaka,MusteriBilgisi.eMail FROM MusteriBilgisi " +
                                               " INNER JOIN AracBilgisi ON AracBilgisi.aracID=MusteriBilgisi.aracID "+
                                               " ORDER BY musteriID DESC";
            sorguPlaka = "SELECT plaka FROM AracBilgisi";
            sorguAracID = "SELECT aracID from AracBilgisi WHERE plaka = @plaka";
            sorguMusteriBilgileri = "SELECT musteriID,tckimlikno,ad,soyad,aracID,calisanID,eMail FROM MusteriBilgisi ";
            sorguMusteriKayit = "INSERT INTO MusteriBilgisi(tckimlikno,ad,soyad,aracID,calisanID,eMail) VALUES(@tckimlikno,@ad,@soyad,@aracID,@calisanID,@eMail)";
            sorguMusteriKayitSil = " DELETE from MusteriBilgisi WHERE tckimlikno = @tckimlikno";
            sorguMusteriKayitUpdate = "UPDATE MusteriBilgisi " +
                          "SET tckimlikno =@tckimlikno,ad=@ad,soyad=@soyad,aracID=@aracID,eMail=@eMail " +
                          " WHERE musteriID=@musteriID";
        }
    }
}
