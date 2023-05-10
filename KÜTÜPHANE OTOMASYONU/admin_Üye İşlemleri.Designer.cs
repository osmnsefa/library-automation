namespace KÜTÜPHANE_OTOMASYONU
{
    partial class Üye_İşlemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üye_İşlemleri));
            this.groupBox_üye_islemleri = new System.Windows.Forms.GroupBox();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_güncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.maskedTxt_tarih_üye = new System.Windows.Forms.MaskedTextBox();
            this.txt_üye_sifre = new System.Windows.Forms.TextBox();
            this.txt_üye_kullanıcı_adı = new System.Windows.Forms.TextBox();
            this.txt_üye_yetki = new System.Windows.Forms.TextBox();
            this.txt_üye_soyisim = new System.Windows.Forms.TextBox();
            this.txt_üye_isim = new System.Windows.Forms.TextBox();
            this.txt_üye_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcı_adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminSayfasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_ara = new System.Windows.Forms.Button();
            this.button_yenile = new System.Windows.Forms.Button();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.groupBox_üye_islemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_üye_islemleri
            // 
            this.groupBox_üye_islemleri.Controls.Add(this.button_temizle);
            this.groupBox_üye_islemleri.Controls.Add(this.button_güncelle);
            this.groupBox_üye_islemleri.Controls.Add(this.button_sil);
            this.groupBox_üye_islemleri.Controls.Add(this.button_ekle);
            this.groupBox_üye_islemleri.Controls.Add(this.maskedTxt_tarih_üye);
            this.groupBox_üye_islemleri.Controls.Add(this.txt_üye_sifre);
            this.groupBox_üye_islemleri.Controls.Add(this.txt_üye_kullanıcı_adı);
            this.groupBox_üye_islemleri.Controls.Add(this.txt_üye_yetki);
            this.groupBox_üye_islemleri.Controls.Add(this.txt_üye_soyisim);
            this.groupBox_üye_islemleri.Controls.Add(this.txt_üye_isim);
            this.groupBox_üye_islemleri.Controls.Add(this.txt_üye_id);
            this.groupBox_üye_islemleri.Controls.Add(this.label8);
            this.groupBox_üye_islemleri.Controls.Add(this.label7);
            this.groupBox_üye_islemleri.Controls.Add(this.label6);
            this.groupBox_üye_islemleri.Controls.Add(this.label5);
            this.groupBox_üye_islemleri.Controls.Add(this.label4);
            this.groupBox_üye_islemleri.Controls.Add(this.label3);
            this.groupBox_üye_islemleri.Controls.Add(this.label2);
            this.groupBox_üye_islemleri.Location = new System.Drawing.Point(0, 32);
            this.groupBox_üye_islemleri.Name = "groupBox_üye_islemleri";
            this.groupBox_üye_islemleri.Size = new System.Drawing.Size(427, 480);
            this.groupBox_üye_islemleri.TabIndex = 0;
            this.groupBox_üye_islemleri.TabStop = false;
            this.groupBox_üye_islemleri.Text = "ÜYE İŞLEMLERİ";
            // 
            // button_temizle
            // 
            this.button_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_temizle.ImageKey = "Saki-Snowish-Actions-edit-clear.128.png";
            this.button_temizle.ImageList = this.ımageList1;
            this.button_temizle.Location = new System.Drawing.Point(24, 429);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(376, 34);
            this.button_temizle.TabIndex = 21;
            this.button_temizle.Text = "TEMİZLE";
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_güncelle
            // 
            this.button_güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_güncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_güncelle.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-edit-redo.256.png";
            this.button_güncelle.ImageList = this.ımageList1;
            this.button_güncelle.Location = new System.Drawing.Point(24, 389);
            this.button_güncelle.Name = "button_güncelle";
            this.button_güncelle.Size = new System.Drawing.Size(376, 34);
            this.button_güncelle.TabIndex = 21;
            this.button_güncelle.Text = "GÜNCELLE";
            this.button_güncelle.UseVisualStyleBackColor = true;
            this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.ImageKey = "Hopstarter-Sleek-Xp-Basic-Close-2.256.png";
            this.button_sil.ImageList = this.ımageList1;
            this.button_sil.Location = new System.Drawing.Point(24, 349);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(376, 34);
            this.button_sil.TabIndex = 21;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ekle.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-list-add.256.png";
            this.button_ekle.ImageList = this.ımageList1;
            this.button_ekle.Location = new System.Drawing.Point(24, 309);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(376, 34);
            this.button_ekle.TabIndex = 21;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // maskedTxt_tarih_üye
            // 
            this.maskedTxt_tarih_üye.Location = new System.Drawing.Point(181, 187);
            this.maskedTxt_tarih_üye.Mask = "00/00/0000 90:00";
            this.maskedTxt_tarih_üye.Name = "maskedTxt_tarih_üye";
            this.maskedTxt_tarih_üye.Size = new System.Drawing.Size(219, 22);
            this.maskedTxt_tarih_üye.TabIndex = 11;
            this.maskedTxt_tarih_üye.ValidatingType = typeof(System.DateTime);
            // 
            // txt_üye_sifre
            // 
            this.txt_üye_sifre.Location = new System.Drawing.Point(181, 243);
            this.txt_üye_sifre.Multiline = true;
            this.txt_üye_sifre.Name = "txt_üye_sifre";
            this.txt_üye_sifre.Size = new System.Drawing.Size(219, 24);
            this.txt_üye_sifre.TabIndex = 20;
            // 
            // txt_üye_kullanıcı_adı
            // 
            this.txt_üye_kullanıcı_adı.Location = new System.Drawing.Point(181, 217);
            this.txt_üye_kullanıcı_adı.Multiline = true;
            this.txt_üye_kullanıcı_adı.Name = "txt_üye_kullanıcı_adı";
            this.txt_üye_kullanıcı_adı.Size = new System.Drawing.Size(219, 24);
            this.txt_üye_kullanıcı_adı.TabIndex = 19;
            // 
            // txt_üye_yetki
            // 
            this.txt_üye_yetki.Location = new System.Drawing.Point(181, 160);
            this.txt_üye_yetki.Multiline = true;
            this.txt_üye_yetki.Name = "txt_üye_yetki";
            this.txt_üye_yetki.Size = new System.Drawing.Size(219, 24);
            this.txt_üye_yetki.TabIndex = 10;
            // 
            // txt_üye_soyisim
            // 
            this.txt_üye_soyisim.Location = new System.Drawing.Point(181, 130);
            this.txt_üye_soyisim.Multiline = true;
            this.txt_üye_soyisim.Name = "txt_üye_soyisim";
            this.txt_üye_soyisim.Size = new System.Drawing.Size(219, 24);
            this.txt_üye_soyisim.TabIndex = 9;
            // 
            // txt_üye_isim
            // 
            this.txt_üye_isim.Location = new System.Drawing.Point(181, 100);
            this.txt_üye_isim.Multiline = true;
            this.txt_üye_isim.Name = "txt_üye_isim";
            this.txt_üye_isim.Size = new System.Drawing.Size(219, 24);
            this.txt_üye_isim.TabIndex = 8;
            // 
            // txt_üye_id
            // 
            this.txt_üye_id.Location = new System.Drawing.Point(181, 70);
            this.txt_üye_id.Multiline = true;
            this.txt_üye_id.Name = "txt_üye_id";
            this.txt_üye_id.Size = new System.Drawing.Size(219, 24);
            this.txt_üye_id.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "ŞİFRE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "KULLANICI ADI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "TARİH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "YETKİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "SOYİSİM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "İSİM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.soyisim,
            this.yetki,
            this.tarih,
            this.kullanıcı_adı,
            this.sifre});
            this.dataGridView1.Location = new System.Drawing.Point(433, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(684, 360);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // isim
            // 
            this.isim.HeaderText = "İSİM";
            this.isim.MinimumWidth = 6;
            this.isim.Name = "isim";
            this.isim.Width = 125;
            // 
            // soyisim
            // 
            this.soyisim.HeaderText = "SOYİSİM";
            this.soyisim.MinimumWidth = 6;
            this.soyisim.Name = "soyisim";
            this.soyisim.Width = 125;
            // 
            // yetki
            // 
            this.yetki.HeaderText = "YETKİ";
            this.yetki.MinimumWidth = 6;
            this.yetki.Name = "yetki";
            this.yetki.Width = 125;
            // 
            // tarih
            // 
            this.tarih.HeaderText = "TARİH";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.Width = 125;
            // 
            // kullanıcı_adı
            // 
            this.kullanıcı_adı.HeaderText = "KULLANICI ADI";
            this.kullanıcı_adı.MinimumWidth = 6;
            this.kullanıcı_adı.Name = "kullanıcı_adı";
            this.kullanıcı_adı.Width = 125;
            // 
            // sifre
            // 
            this.sifre.HeaderText = "ŞİFRE";
            this.sifre.MinimumWidth = 6;
            this.sifre.Name = "sifre";
            this.sifre.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(735, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ÜYELERİM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminSayfasıToolStripMenuItem,
            this.kitaplarımToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminSayfasıToolStripMenuItem
            // 
            this.adminSayfasıToolStripMenuItem.Name = "adminSayfasıToolStripMenuItem";
            this.adminSayfasıToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.adminSayfasıToolStripMenuItem.Text = "Admin sayfası";
            this.adminSayfasıToolStripMenuItem.Click += new System.EventHandler(this.adminSayfasıToolStripMenuItem_Click);
            // 
            // kitaplarımToolStripMenuItem
            // 
            this.kitaplarımToolStripMenuItem.Name = "kitaplarımToolStripMenuItem";
            this.kitaplarımToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.kitaplarımToolStripMenuItem.Text = "Kitaplarım";
            this.kitaplarımToolStripMenuItem.Click += new System.EventHandler(this.kitaplarımToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hopstarter-Sleek-Xp-Basic-Close-2.256.png");
            this.ımageList1.Images.SetKeyName(1, "Oxygen-Icons.org-Oxygen-Actions-edit-redo.256.png");
            this.ımageList1.Images.SetKeyName(2, "Saki-Snowish-Actions-edit-clear.128.png");
            this.ımageList1.Images.SetKeyName(3, "Oxygen-Icons.org-Oxygen-Actions-list-add.256.png");
            // 
            // button_ara
            // 
            this.button_ara.Location = new System.Drawing.Point(433, 40);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(75, 23);
            this.button_ara.TabIndex = 25;
            this.button_ara.Text = "ARA";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // button_yenile
            // 
            this.button_yenile.Location = new System.Drawing.Point(630, 40);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(75, 23);
            this.button_yenile.TabIndex = 25;
            this.button_yenile.Text = "YENİLE";
            this.button_yenile.UseVisualStyleBackColor = true;
            this.button_yenile.Click += new System.EventHandler(this.button_yenile_Click);
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(514, 41);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(110, 22);
            this.textBox_ara.TabIndex = 26;
            // 
            // Üye_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 516);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.button_yenile);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_üye_islemleri);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Üye_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye_İşlemleri";
            this.Load += new System.EventHandler(this.Üye_İşlemleri_Load);
            this.groupBox_üye_islemleri.ResumeLayout(false);
            this.groupBox_üye_islemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_üye_islemleri;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_güncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.MaskedTextBox maskedTxt_tarih_üye;
        private System.Windows.Forms.TextBox txt_üye_sifre;
        private System.Windows.Forms.TextBox txt_üye_kullanıcı_adı;
        private System.Windows.Forms.TextBox txt_üye_yetki;
        private System.Windows.Forms.TextBox txt_üye_soyisim;
        private System.Windows.Forms.TextBox txt_üye_isim;
        private System.Windows.Forms.TextBox txt_üye_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcı_adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminSayfasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarımToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.Button button_yenile;
        private System.Windows.Forms.TextBox textBox_ara;
    }
}