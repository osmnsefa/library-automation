namespace KÜTÜPHANE_OTOMASYONU
{
    partial class admin_kitap_sayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kitap_sayfası));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminProfiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox_kitap_islemleri = new System.Windows.Forms.GroupBox();
            this.btn_kitap_temizle = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.btn_kitap_güncelle = new System.Windows.Forms.Button();
            this.btn_kitap_sil = new System.Windows.Forms.Button();
            this.btn_kitap_ekle = new System.Windows.Forms.Button();
            this.text_kitap_yayınevi = new System.Windows.Forms.TextBox();
            this.text_kitap_basım_yılı = new System.Windows.Forms.TextBox();
            this.txt_kitap_adet = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.text_kitap_sayfa = new System.Windows.Forms.TextBox();
            this.txt_kitap_tür = new System.Windows.Forms.TextBox();
            this.txt_kitap_dil = new System.Windows.Forms.TextBox();
            this.txt_kitap_yazar = new System.Windows.Forms.TextBox();
            this.txt_kitap_isim = new System.Windows.Forms.TextBox();
            this.txt_kitap_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView_kitap = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_dili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tür = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfa_sayısı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basım_yılı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_ara_kitap = new System.Windows.Forms.Button();
            this.button_yenile_kitap = new System.Windows.Forms.Button();
            this.textBox_ara_kitap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox_kitap_islemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kitap)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminProfiliToolStripMenuItem,
            this.üyeİşlemleriToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminProfiliToolStripMenuItem
            // 
            this.adminProfiliToolStripMenuItem.Name = "adminProfiliToolStripMenuItem";
            this.adminProfiliToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.adminProfiliToolStripMenuItem.Text = "Admin Profili";
            this.adminProfiliToolStripMenuItem.Click += new System.EventHandler(this.adminProfiliToolStripMenuItem_Click);
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            this.üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            this.üyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            this.üyeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.üyeİşlemleriToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox_kitap_islemleri
            // 
            this.groupBox_kitap_islemleri.Controls.Add(this.btn_kitap_temizle);
            this.groupBox_kitap_islemleri.Controls.Add(this.button_temizle);
            this.groupBox_kitap_islemleri.Controls.Add(this.btn_kitap_güncelle);
            this.groupBox_kitap_islemleri.Controls.Add(this.btn_kitap_sil);
            this.groupBox_kitap_islemleri.Controls.Add(this.btn_kitap_ekle);
            this.groupBox_kitap_islemleri.Controls.Add(this.text_kitap_yayınevi);
            this.groupBox_kitap_islemleri.Controls.Add(this.text_kitap_basım_yılı);
            this.groupBox_kitap_islemleri.Controls.Add(this.txt_kitap_adet);
            this.groupBox_kitap_islemleri.Controls.Add(this.textBox3);
            this.groupBox_kitap_islemleri.Controls.Add(this.text_kitap_sayfa);
            this.groupBox_kitap_islemleri.Controls.Add(this.txt_kitap_tür);
            this.groupBox_kitap_islemleri.Controls.Add(this.txt_kitap_dil);
            this.groupBox_kitap_islemleri.Controls.Add(this.txt_kitap_yazar);
            this.groupBox_kitap_islemleri.Controls.Add(this.txt_kitap_isim);
            this.groupBox_kitap_islemleri.Controls.Add(this.txt_kitap_id);
            this.groupBox_kitap_islemleri.Controls.Add(this.label9);
            this.groupBox_kitap_islemleri.Controls.Add(this.label8);
            this.groupBox_kitap_islemleri.Controls.Add(this.label1);
            this.groupBox_kitap_islemleri.Controls.Add(this.label7);
            this.groupBox_kitap_islemleri.Controls.Add(this.label6);
            this.groupBox_kitap_islemleri.Controls.Add(this.label5);
            this.groupBox_kitap_islemleri.Controls.Add(this.label4);
            this.groupBox_kitap_islemleri.Controls.Add(this.label3);
            this.groupBox_kitap_islemleri.Controls.Add(this.label2);
            this.groupBox_kitap_islemleri.Location = new System.Drawing.Point(12, 31);
            this.groupBox_kitap_islemleri.Name = "groupBox_kitap_islemleri";
            this.groupBox_kitap_islemleri.Size = new System.Drawing.Size(427, 516);
            this.groupBox_kitap_islemleri.TabIndex = 2;
            this.groupBox_kitap_islemleri.TabStop = false;
            this.groupBox_kitap_islemleri.Text = "KİTAP İŞLEMLERİ";
            // 
            // btn_kitap_temizle
            // 
            this.btn_kitap_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitap_temizle.ImageKey = "Saki-Snowish-Actions-edit-clear.128.png";
            this.btn_kitap_temizle.ImageList = this.ımageList1;
            this.btn_kitap_temizle.Location = new System.Drawing.Point(24, 467);
            this.btn_kitap_temizle.Name = "btn_kitap_temizle";
            this.btn_kitap_temizle.Size = new System.Drawing.Size(376, 34);
            this.btn_kitap_temizle.TabIndex = 21;
            this.btn_kitap_temizle.Text = "TEMİZLE";
            this.btn_kitap_temizle.UseVisualStyleBackColor = true;
            this.btn_kitap_temizle.Click += new System.EventHandler(this.btn_kitap_temizle_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_temizle.Location = new System.Drawing.Point(24, 463);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(376, 34);
            this.button_temizle.TabIndex = 21;
            this.button_temizle.Text = "TEMİZLE";
            this.button_temizle.UseVisualStyleBackColor = true;
            // 
            // btn_kitap_güncelle
            // 
            this.btn_kitap_güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_güncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitap_güncelle.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-edit-redo.256.png";
            this.btn_kitap_güncelle.ImageList = this.ımageList1;
            this.btn_kitap_güncelle.Location = new System.Drawing.Point(24, 423);
            this.btn_kitap_güncelle.Name = "btn_kitap_güncelle";
            this.btn_kitap_güncelle.Size = new System.Drawing.Size(376, 34);
            this.btn_kitap_güncelle.TabIndex = 21;
            this.btn_kitap_güncelle.Text = "GÜNCELLE";
            this.btn_kitap_güncelle.UseVisualStyleBackColor = true;
            this.btn_kitap_güncelle.Click += new System.EventHandler(this.btn_kitap_güncelle_Click);
            // 
            // btn_kitap_sil
            // 
            this.btn_kitap_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitap_sil.ImageKey = "Hopstarter-Sleek-Xp-Basic-Close-2.256.png";
            this.btn_kitap_sil.ImageList = this.ımageList1;
            this.btn_kitap_sil.Location = new System.Drawing.Point(24, 383);
            this.btn_kitap_sil.Name = "btn_kitap_sil";
            this.btn_kitap_sil.Size = new System.Drawing.Size(376, 34);
            this.btn_kitap_sil.TabIndex = 21;
            this.btn_kitap_sil.Text = "SİL";
            this.btn_kitap_sil.UseVisualStyleBackColor = true;
            this.btn_kitap_sil.Click += new System.EventHandler(this.btn_kitap_sil_Click);
            // 
            // btn_kitap_ekle
            // 
            this.btn_kitap_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitap_ekle.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-list-add.256.png";
            this.btn_kitap_ekle.ImageList = this.ımageList1;
            this.btn_kitap_ekle.Location = new System.Drawing.Point(24, 343);
            this.btn_kitap_ekle.Name = "btn_kitap_ekle";
            this.btn_kitap_ekle.Size = new System.Drawing.Size(376, 34);
            this.btn_kitap_ekle.TabIndex = 21;
            this.btn_kitap_ekle.Text = "EKLE";
            this.btn_kitap_ekle.UseVisualStyleBackColor = true;
            this.btn_kitap_ekle.Click += new System.EventHandler(this.btn_kitap_ekle_Click);
            // 
            // text_kitap_yayınevi
            // 
            this.text_kitap_yayınevi.Location = new System.Drawing.Point(181, 187);
            this.text_kitap_yayınevi.Multiline = true;
            this.text_kitap_yayınevi.Name = "text_kitap_yayınevi";
            this.text_kitap_yayınevi.Size = new System.Drawing.Size(219, 24);
            this.text_kitap_yayınevi.TabIndex = 20;
            // 
            // text_kitap_basım_yılı
            // 
            this.text_kitap_basım_yılı.Location = new System.Drawing.Point(181, 296);
            this.text_kitap_basım_yılı.Multiline = true;
            this.text_kitap_basım_yılı.Name = "text_kitap_basım_yılı";
            this.text_kitap_basım_yılı.Size = new System.Drawing.Size(219, 24);
            this.text_kitap_basım_yılı.TabIndex = 19;
            // 
            // txt_kitap_adet
            // 
            this.txt_kitap_adet.Location = new System.Drawing.Point(181, 241);
            this.txt_kitap_adet.Multiline = true;
            this.txt_kitap_adet.Name = "txt_kitap_adet";
            this.txt_kitap_adet.Size = new System.Drawing.Size(219, 24);
            this.txt_kitap_adet.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 292);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 24);
            this.textBox3.TabIndex = 19;
            // 
            // text_kitap_sayfa
            // 
            this.text_kitap_sayfa.Location = new System.Drawing.Point(181, 269);
            this.text_kitap_sayfa.Multiline = true;
            this.text_kitap_sayfa.Name = "text_kitap_sayfa";
            this.text_kitap_sayfa.Size = new System.Drawing.Size(219, 24);
            this.text_kitap_sayfa.TabIndex = 19;
            // 
            // txt_kitap_tür
            // 
            this.txt_kitap_tür.Location = new System.Drawing.Point(181, 215);
            this.txt_kitap_tür.Multiline = true;
            this.txt_kitap_tür.Name = "txt_kitap_tür";
            this.txt_kitap_tür.Size = new System.Drawing.Size(219, 24);
            this.txt_kitap_tür.TabIndex = 19;
            // 
            // txt_kitap_dil
            // 
            this.txt_kitap_dil.Location = new System.Drawing.Point(181, 160);
            this.txt_kitap_dil.Multiline = true;
            this.txt_kitap_dil.Name = "txt_kitap_dil";
            this.txt_kitap_dil.Size = new System.Drawing.Size(219, 24);
            this.txt_kitap_dil.TabIndex = 10;
            // 
            // txt_kitap_yazar
            // 
            this.txt_kitap_yazar.Location = new System.Drawing.Point(181, 130);
            this.txt_kitap_yazar.Multiline = true;
            this.txt_kitap_yazar.Name = "txt_kitap_yazar";
            this.txt_kitap_yazar.Size = new System.Drawing.Size(219, 24);
            this.txt_kitap_yazar.TabIndex = 9;
            // 
            // txt_kitap_isim
            // 
            this.txt_kitap_isim.Location = new System.Drawing.Point(181, 100);
            this.txt_kitap_isim.Multiline = true;
            this.txt_kitap_isim.Name = "txt_kitap_isim";
            this.txt_kitap_isim.Size = new System.Drawing.Size(219, 24);
            this.txt_kitap_isim.TabIndex = 8;
            // 
            // txt_kitap_id
            // 
            this.txt_kitap_id.Location = new System.Drawing.Point(181, 70);
            this.txt_kitap_id.Multiline = true;
            this.txt_kitap_id.Name = "txt_kitap_id";
            this.txt_kitap_id.Size = new System.Drawing.Size(219, 24);
            this.txt_kitap_id.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "BASIM YILI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "KİTABIN ADEDİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "SAYFA SAYISI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "KİTABIN TÜRÜ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "YAYINEVİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "KİTABIN DİLİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "YAZARI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "KİTAP ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "KİTAP ID:";
            // 
            // dataGridView_kitap
            // 
            this.dataGridView_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.adı,
            this.yazar,
            this.kitap_dili,
            this.yayınevi,
            this.tür,
            this.adet,
            this.sayfa_sayısı,
            this.basım_yılı});
            this.dataGridView_kitap.Location = new System.Drawing.Point(445, 68);
            this.dataGridView_kitap.Name = "dataGridView_kitap";
            this.dataGridView_kitap.RowHeadersWidth = 51;
            this.dataGridView_kitap.RowTemplate.Height = 24;
            this.dataGridView_kitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_kitap.Size = new System.Drawing.Size(720, 464);
            this.dataGridView_kitap.TabIndex = 3;
            this.dataGridView_kitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kitap_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "KİTAP ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // adı
            // 
            this.adı.HeaderText = "KİTAP ADI";
            this.adı.MinimumWidth = 6;
            this.adı.Name = "adı";
            this.adı.Width = 125;
            // 
            // yazar
            // 
            this.yazar.HeaderText = "YAZARI";
            this.yazar.MinimumWidth = 6;
            this.yazar.Name = "yazar";
            this.yazar.Width = 125;
            // 
            // kitap_dili
            // 
            this.kitap_dili.HeaderText = "KİTABIN DİLİ";
            this.kitap_dili.MinimumWidth = 6;
            this.kitap_dili.Name = "kitap_dili";
            this.kitap_dili.Width = 125;
            // 
            // yayınevi
            // 
            this.yayınevi.HeaderText = "YAYINEVİ";
            this.yayınevi.MinimumWidth = 6;
            this.yayınevi.Name = "yayınevi";
            this.yayınevi.Width = 125;
            // 
            // tür
            // 
            this.tür.HeaderText = "KİTABIN TÜRÜ";
            this.tür.MinimumWidth = 6;
            this.tür.Name = "tür";
            this.tür.Width = 125;
            // 
            // adet
            // 
            this.adet.HeaderText = "KİTABIN ADEDİ";
            this.adet.MinimumWidth = 6;
            this.adet.Name = "adet";
            this.adet.Width = 125;
            // 
            // sayfa_sayısı
            // 
            this.sayfa_sayısı.HeaderText = "SAYFA SAYISI";
            this.sayfa_sayısı.MinimumWidth = 6;
            this.sayfa_sayısı.Name = "sayfa_sayısı";
            this.sayfa_sayısı.Width = 125;
            // 
            // basım_yılı
            // 
            this.basım_yılı.HeaderText = "BASIM YILI";
            this.basım_yılı.MinimumWidth = 6;
            this.basım_yılı.Name = "basım_yılı";
            this.basım_yılı.Width = 125;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Oxygen-Icons.org-Oxygen-Actions-edit-redo.256.png");
            this.ımageList1.Images.SetKeyName(1, "Saki-Snowish-Actions-edit-clear.128.png");
            this.ımageList1.Images.SetKeyName(2, "Oxygen-Icons.org-Oxygen-Actions-list-add.256.png");
            this.ımageList1.Images.SetKeyName(3, "Hopstarter-Sleek-Xp-Basic-Close-2.256.png");
            // 
            // button_ara_kitap
            // 
            this.button_ara_kitap.Location = new System.Drawing.Point(445, 39);
            this.button_ara_kitap.Name = "button_ara_kitap";
            this.button_ara_kitap.Size = new System.Drawing.Size(75, 23);
            this.button_ara_kitap.TabIndex = 4;
            this.button_ara_kitap.Text = "ARA";
            this.button_ara_kitap.UseVisualStyleBackColor = true;
            this.button_ara_kitap.Click += new System.EventHandler(this.button_ara_kitap_Click);
            // 
            // button_yenile_kitap
            // 
            this.button_yenile_kitap.Location = new System.Drawing.Point(641, 39);
            this.button_yenile_kitap.Name = "button_yenile_kitap";
            this.button_yenile_kitap.Size = new System.Drawing.Size(75, 23);
            this.button_yenile_kitap.TabIndex = 4;
            this.button_yenile_kitap.Text = "YENİLE";
            this.button_yenile_kitap.UseVisualStyleBackColor = true;
            this.button_yenile_kitap.Click += new System.EventHandler(this.button_yenile_kitap_Click);
            // 
            // textBox_ara_kitap
            // 
            this.textBox_ara_kitap.Location = new System.Drawing.Point(526, 40);
            this.textBox_ara_kitap.Name = "textBox_ara_kitap";
            this.textBox_ara_kitap.Size = new System.Drawing.Size(109, 22);
            this.textBox_ara_kitap.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(751, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "KİTAPLARIM";
            // 
            // admin_kitap_sayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_ara_kitap);
            this.Controls.Add(this.button_yenile_kitap);
            this.Controls.Add(this.button_ara_kitap);
            this.Controls.Add(this.dataGridView_kitap);
            this.Controls.Add(this.groupBox_kitap_islemleri);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin_kitap_sayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_kitap_sayfası";
            this.Load += new System.EventHandler(this.admin_kitap_sayfası_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_kitap_islemleri.ResumeLayout(false);
            this.groupBox_kitap_islemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminProfiliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox_kitap_islemleri;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button btn_kitap_güncelle;
        private System.Windows.Forms.Button btn_kitap_sil;
        private System.Windows.Forms.Button btn_kitap_ekle;
        private System.Windows.Forms.TextBox txt_kitap_adet;
        private System.Windows.Forms.TextBox txt_kitap_tür;
        private System.Windows.Forms.TextBox txt_kitap_dil;
        private System.Windows.Forms.TextBox txt_kitap_yazar;
        private System.Windows.Forms.TextBox txt_kitap_isim;
        private System.Windows.Forms.TextBox txt_kitap_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox text_kitap_yayınevi;
        private System.Windows.Forms.TextBox text_kitap_sayfa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kitap_temizle;
        private System.Windows.Forms.TextBox text_kitap_basım_yılı;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView_kitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_dili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tür;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfa_sayısı;
        private System.Windows.Forms.DataGridViewTextBoxColumn basım_yılı;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button_ara_kitap;
        private System.Windows.Forms.Button button_yenile_kitap;
        private System.Windows.Forms.TextBox textBox_ara_kitap;
        private System.Windows.Forms.Label label10;
    }
}