using KÜTÜPHANE_OTOMASYONU.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class admin_kitap_sayfası : Form
    {
        List<KİSİ> kisilerim;
        List<Kitap> kitaplarım;
        public admin_kitap_sayfası(List<KİSİ> kisilerim, List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarım = kitaplarım;
        }

        private void adminProfiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_sayfası admin = new admin_sayfası(kisilerim,kitaplarım);
            admin.Show();
            this.Hide();
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Üye_İşlemleri üye = new Üye_İşlemleri(kisilerim, kitaplarım);
                üye.Show();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void admin_kitap_sayfası_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarım)
            {
                dataGridView_kitap.Rows.Add(kitap.getkitapid(), kitap.getkitapismi(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayınevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfasayısı(), kitap.getbasımyılı());
            }
        }

        private void btn_kitap_ekle_Click(object sender, EventArgs e)
        {
            dataGridView_kitap.Rows.Add(txt_kitap_id.Text, txt_kitap_isim.Text, txt_kitap_yazar.Text, txt_kitap_dil.Text, text_kitap_yayınevi.Text, txt_kitap_tür.Text, txt_kitap_adet.Text, text_kitap_sayfa.Text, text_kitap_basım_yılı.Text); 
        }

        private void btn_kitap_sil_Click(object sender, EventArgs e)
        {
            dataGridView_kitap.Rows.Remove(dataGridView_kitap.CurrentRow);
        }

        public void kitap_data()
        {
            txt_kitap_id.Text =dataGridView_kitap.CurrentRow.Cells[0].Value.ToString();
            txt_kitap_isim.Text=dataGridView_kitap.CurrentRow.Cells[1].Value.ToString();
            txt_kitap_yazar.Text = dataGridView_kitap.CurrentRow.Cells[2].Value.ToString();
            txt_kitap_dil.Text = dataGridView_kitap.CurrentRow.Cells[3].Value.ToString();
            text_kitap_yayınevi.Text = dataGridView_kitap.CurrentRow.Cells[4].Value.ToString();
            txt_kitap_tür.Text = dataGridView_kitap.CurrentRow.Cells[5].Value.ToString();
            txt_kitap_adet.Text = dataGridView_kitap.CurrentRow.Cells[6].Value.ToString();
            text_kitap_sayfa.Text = dataGridView_kitap.CurrentRow.Cells[7].Value.ToString();
            text_kitap_basım_yılı.Text = dataGridView_kitap.CurrentRow.Cells[8].Value.ToString();
        }
        private void dataGridView_kitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitap_data();
        }

        private void btn_kitap_güncelle_Click(object sender, EventArgs e)
        {
            dataGridView_kitap.Rows.Remove(dataGridView_kitap.CurrentRow);
            dataGridView_kitap.Rows.Add(txt_kitap_id.Text, txt_kitap_isim.Text, txt_kitap_yazar.Text, txt_kitap_dil.Text, text_kitap_yayınevi.Text, txt_kitap_tür.Text, txt_kitap_adet.Text, text_kitap_sayfa.Text, text_kitap_basım_yılı.Text);
        }

        private void btn_kitap_temizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox_kitap_islemleri.Controls.Count; i++)
            {
                if (groupBox_kitap_islemleri.Controls[i] is TextBox)
                {
                    groupBox_kitap_islemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void button_ara_kitap_Click(object sender, EventArgs e)
        {
            Kitap hedef_kitap = null;
            int secilen_id = Convert.ToInt32(textBox_ara_kitap.Text);

            foreach(Kitap kitap in kitaplarım)
            {
                if (secilen_id == kitap.getkitapid())
                {
                    hedef_kitap = kitap;
                }
            }
            dataGridView_kitap.Rows.Clear();
            dataGridView_kitap.Rows.Add(hedef_kitap.getkitapid(), hedef_kitap.getkitapismi(), hedef_kitap.getkitapyazar(), hedef_kitap.getkitapdili(), hedef_kitap.getyayınevi(), hedef_kitap.gettur(), hedef_kitap.getadet(), hedef_kitap.getsayfasayısı(), hedef_kitap.getbasımyılı());
        }

        private void button_yenile_kitap_Click(object sender, EventArgs e)
        {
            dataGridView_kitap.Rows.Remove(dataGridView_kitap.CurrentRow);
            foreach(Kitap hedef_kitap in kitaplarım)
            {
            dataGridView_kitap.Rows.Add(hedef_kitap.getkitapid(), hedef_kitap.getkitapismi(), hedef_kitap.getkitapyazar(), hedef_kitap.getkitapdili(), hedef_kitap.getyayınevi(), hedef_kitap.gettur(), hedef_kitap.getadet(), hedef_kitap.getsayfasayısı(), hedef_kitap.getbasımyılı());
            }
        }
    }
}
