using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KÜTÜPHANE_OTOMASYONU.MODEL
{
    public class KİSİ
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string yetki { get; set; }
        public DateTime tarih { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public KİSİ()
        {

        }
        public KİSİ(int id,string isim,string soyisim,string yetki,DateTime tarih,string kullanici_adi,string sifre)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.yetki = yetki;
            this.tarih = tarih;
            this.kullanici_adi = kullanici_adi;
            this.sifre = sifre;
        }

        public void setid(int id)
        {
            this.id = id;
        }
        public int getid()
        {
            return this.id;
        }
        public void setisim(string isim)
        {
            this.isim=isim;
        }
        public string getisim()
        {
            return this.isim;
        }
        public void setsoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string getsoyisim()
        {
            return this.soyisim;
        }
        public void settarih(DateTime tarih)
        {
            this.tarih = tarih;
        }
        public DateTime gettarih()
        {
            return  this.tarih;
        }
        public void setyetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getyetki()
        {
            return this.yetki;
        }
        public void setkullanici_adi(string kullanici_adi)
        {
            this.kullanici_adi = kullanici_adi;
        }
        public string getkullanici_adi()
        {
            return this.kullanici_adi;
        }
        public void setsifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getsifre()
        {
            return this.sifre;
        }
    }
}
