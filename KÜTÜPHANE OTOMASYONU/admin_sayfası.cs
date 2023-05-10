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
    public partial class admin_sayfası : Form
    {
        List<KİSİ> kisilerim;
        List<Kitap> kitaplarım = new List<Kitap>();
        public admin_sayfası(List<KİSİ>kisilerim, List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarım = kitaplarım;
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Üye_İşlemleri uye_islemleri = new Üye_İşlemleri(kisilerim,kitaplarım);
            uye_islemleri.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_sayfası_Load(object sender, EventArgs e)
        {
            txt_admin_id.Text = (kisilerim[0].getid()).ToString();
            txt_admin_isim.Text = (kisilerim[0].getisim());
            txt_admin_soyisim.Text = (kisilerim[0].getsoyisim());
            txt_admin_yetki.Text = (kisilerim[0].getyetki());
            maskedTxt_tarih_admin.Text = (kisilerim[0].gettarih()).ToString();
            txt_admin_kullanıcı_adı.Text = (kisilerim[0].getkullanici_adi());
            txt_admin_sifre.Text = (kisilerim[0].getsifre());
            pictureBox_admin.Image = Image.FromFile("C:\\Users\\Asus\\OneDrive\\Masaüstü\\photoshop\\resim1.jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_admin_Click(object sender, EventArgs e)
        {
            
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult sonuc= MessageBox.Show("ÇIKIŞ YAPILSIN MI?", "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == sonuc)
            {
                MessageBox.Show("ÇIKIŞ YAPILDI ,İYİ GÜNLER...");
                Form1 login_page = new Form1();
                login_page.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ÇIKIŞ YAPILMADI");
            }
            
            
        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_kitap_sayfası kitap_sayfa = new admin_kitap_sayfası(kisilerim,kitaplarım);
            kitap_sayfa.Show();
            this.Hide();
        }
    }
}
