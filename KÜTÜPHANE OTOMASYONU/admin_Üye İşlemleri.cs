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
    public partial class Üye_İşlemleri : Form
    {
        List<KİSİ> kisilerim;
        List<Kitap> kitaplarım;
        public Üye_İşlemleri(List<KİSİ> kisilerim, List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarım = kitaplarım;
        }

        private void Üye_İşlemleri_Load(object sender, EventArgs e)
        {
            foreach(KİSİ kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getid(), kisi.getisim(), kisi.getsoyisim(), kisi.getyetki(), kisi.gettarih(), kisi.getkullanici_adi(), kisi.getsifre());
            }
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_üye_id.Text), txt_üye_isim.Text, txt_üye_soyisim.Text, txt_üye_yetki.Text, maskedTxt_tarih_üye.Text, txt_üye_kullanıcı_adı.Text, txt_üye_sifre.Text);

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void datagridveri()
        {
            txt_üye_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_üye_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_üye_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_üye_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTxt_tarih_üye.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_üye_kullanıcı_adı.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_üye_sifre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridveri();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox_üye_islemleri.Controls.Count; i++)
            {
                if (groupBox_üye_islemleri.Controls[i] is TextBox || groupBox_üye_islemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_üye_islemleri.Controls[i].Text = String.Empty;
                }
            }
        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(Convert.ToInt32(txt_üye_id.Text), txt_üye_isim.Text, txt_üye_soyisim.Text, txt_üye_yetki.Text, maskedTxt_tarih_üye.Text, txt_üye_kullanıcı_adı.Text, txt_üye_sifre.Text);
        }

        private void adminSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_sayfası admin_sayfa = new admin_sayfası(kisilerim,kitaplarım);
            admin_sayfa.Show();
            this.Hide();

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("ÇIKIŞ YAPILSIN MI?", "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == sonuc)
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

        private void kitaplarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_kitap_sayfası kitap_sayfa = new admin_kitap_sayfası(kisilerim,kitaplarım);
            kitap_sayfa.Show();
            this.Hide();
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            KİSİ hedef_kisi = null;
            int secilen_id = Convert.ToInt32(textBox_ara.Text);

            foreach(KİSİ kisi in kisilerim)
            {
                if (kisi.getid() == secilen_id)
                {
                    hedef_kisi = kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedef_kisi.getid(), hedef_kisi.getisim(), hedef_kisi.getsoyisim(), hedef_kisi.getyetki(), hedef_kisi.gettarih(), hedef_kisi.getkullanici_adi(), hedef_kisi.getsifre());
        }

        private void button_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach(KİSİ hedef_kisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedef_kisi.getid(), hedef_kisi.getisim(), hedef_kisi.getsoyisim(), hedef_kisi.getyetki(), hedef_kisi.gettarih(), hedef_kisi.getkullanici_adi(), hedef_kisi.getsifre());
            }
        }
    }
}
