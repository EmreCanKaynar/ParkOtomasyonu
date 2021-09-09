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
        public string sutunAdiIsEmpty;
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
        // FormParkYeri
        public string sorguKonum;
        public string sutunAdiKonum;
        public string sorguAracParkEt;
        public string sorguPark;
        public string sorguParkHalindekiAraclar;
        public string sorguAracIDilePlakaGetir;
        public string sutunAdiaracID;
        public string sorguKonumBosMu;
        public string sorguKonumDoldur;
        public string sorguAracParkHalindemi;


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
            sutunAdiKonum = "konumID";
            sutunAdiaracID = "aracID";
            sutunAdiIsEmpty = "isEmpty";
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
            //FormParkYeri
            sorguKonum = "SELECT konumID FROM Konum";
            sorguAracParkEt = "INSERT INTO Park(aracID,girisTarih,cikisTarih,konumID,calisanID,fiyat) VALUES(@aracID,@girisTarih,@cikisTarih,@konumID,@calisanID,@fiyat)";
            sorguPark = "SELECT parkID,aracID,girisTarih,cikisTarih,konumID,calisanID,fiyat FROM Park ";
            sorguParkHalindekiAraclar = "SELECT Park.aracID FROM Park" +
                                        " INNER JOIN Konum ON Park.konumID = Konum.konumID " +
                                         " WHERE Konum.isEmpty = 'False' AND Park.cikisTarih IS NULL";
            sorguAracIDilePlakaGetir = "SELECT plaka FROM AracBilgisi WHERE aracID = @aracID";
            sorguKonumBosMu =          "SELECT isEmpty FROM Konum" +
                                         " WHERE konumID= @konumID";
            sorguKonumDoldur = "UPDATE Konum " +
                             "SET isEmpty = @isEmpty " +
                             "WHERE konumID = @konumID";
            sorguAracParkHalindemi = "SELECT Konum.isEmpty FROM Park " +
                                     "INNER JOIN Konum ON Konum.konumID = Park.konumID " +
                                     "WHERE aracID=@aracID AND cikisTarih IS NULL";
        }
    }
}
