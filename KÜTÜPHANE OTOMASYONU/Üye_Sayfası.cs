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
    public partial class Üye_Sayfası : Form
    {
        List<Kitap> kitaplarım;
        public Üye_Sayfası(List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kitaplarım = kitaplarım;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Üye_Sayfası_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarım)
            {
                dataGridView_kitap_üye.Rows.Add(kitap.getkitapid(), kitap.getkitapismi(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayınevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfasayısı(), kitap.getbasımyılı());
            }
        }

        private void button_ara_üye_Click(object sender, EventArgs e)
        {
            Kitap hedef_kitap = null;
            int secilen_id = Convert.ToInt32(txt_kitap_ara.Text);

            foreach (Kitap kitap in kitaplarım)
            {
                if (secilen_id == kitap.getkitapid())
                {
                    hedef_kitap = kitap;
                }
            }
            dataGridView_kitap_üye.Rows.Clear();
            dataGridView_kitap_üye.Rows.Add(hedef_kitap.getkitapid(), hedef_kitap.getkitapismi(), hedef_kitap.getkitapyazar(), hedef_kitap.getkitapdili(), hedef_kitap.getyayınevi(), hedef_kitap.gettur(), hedef_kitap.getadet(), hedef_kitap.getsayfasayısı(), hedef_kitap.getbasımyılı());
        }

        private void button_yenile_üye_Click(object sender, EventArgs e)
        {
            dataGridView_kitap_üye.Rows.Remove(dataGridView_kitap_üye.CurrentRow);
            foreach (Kitap hedef_kitap in kitaplarım)
            {
                dataGridView_kitap_üye.Rows.Add(hedef_kitap.getkitapid(), hedef_kitap.getkitapismi(), hedef_kitap.getkitapyazar(), hedef_kitap.getkitapdili(), hedef_kitap.getyayınevi(), hedef_kitap.gettur(), hedef_kitap.getadet(), hedef_kitap.getsayfasayısı(), hedef_kitap.getbasımyılı());
            }
        }
    }
}
