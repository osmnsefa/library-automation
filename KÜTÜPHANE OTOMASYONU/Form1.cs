using KÜTÜPHANE_OTOMASYONU.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class Form1 : Form
    {
        //Kişi türünden değer alan bir koleksiyon oluşturdum...
        List<KİSİ> kisilerim = new List<KİSİ>();
        List<Kitap> kitalarım=new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button_temizle_Click(object sender, EventArgs e)
        {
            textBox_kullanıcı_adı.Text=string.Empty;
            textBox_sifre.Text = string.Empty;
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string kullanici_adi,sifre=" ";
            kullanici_adi = textBox_kullanıcı_adı.Text;
            sifre= textBox_sifre.Text;
            bool kontrol = false;
            // Giriş sayfası kontrolü
            foreach(KİSİ kisi in kisilerim)
            {
                if (kullanici_adi.ToLower()==kisi.getkullanici_adi().ToLower() && sifre.ToLower() == kisi.getsifre().ToLower())
                {
                    if (kisi.getyetki() == "Admin") {
                        admin_sayfası admin_sayfasi = new admin_sayfası(kisilerim,kitalarım);
                        admin_sayfasi.Show();
                        this.Hide();
                        kontrol = true;
                        break;
                    }
                    else if(kisi.getyetki() == "Üye")
                    {
                        Üye_Sayfası uye_sayfası = new Üye_Sayfası(kitalarım);
                        uye_sayfası.Show();
                        this.Hide();
                        kontrol = true;
                        break;

                    }   
                }
            }
            if (!kontrol)
            {
                MessageBox.Show("hatalı giriş", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Kütüphaneye eklenen kişiler
            kisilerim.Add(new KİSİ(1, "Osman", "Coşar", "Admin", DateTime.Now, "Osman", "1234"));
            kisilerim.Add(new KİSİ(2, "Recep", "Yılmaz", "Üye", DateTime.Now, "Recep", "123"));
            kisilerim.Add(new KİSİ(3, "Halil", "Sever", "Üye", DateTime.Now, "Halil", "12345"));

            kitalarım.Add(new Kitap(1, "İÇİMİZDEKİ ŞEYTAN ", "SABAHATTİN ALİ", "TÜRKÇE", "YAPIKREDİ YAYINLARI", "ROMAN", 10, 250, 2016));
            kitalarım.Add(new Kitap(2, "TUTUNAMAYANLAR ", "OĞUZ ATAY", "TÜRKÇE", "İLETİŞİM", "ROMAN", 30, 760, 2015));
            kitalarım.Add(new Kitap(3, "UÇURTMA AVCISI ", "KHALED HOSSEİNİ", "İNGİLİZCE", "EVEREST YAYINLARI", "ROMAN", 60, 350, 2010));
            kitalarım.Add(new Kitap(4, "KÜÇÜK PRENS ", "ANTONİE", "İNGİLİZCE", "CAN YAYINLARI", "ROMAN", 25, 60, 2018));
            
        }


    }
}
