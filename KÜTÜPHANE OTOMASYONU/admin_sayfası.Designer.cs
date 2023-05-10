namespace KÜTÜPHANE_OTOMASYONU
{
    partial class admin_sayfası
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminProfiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_admin = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_admin_id = new System.Windows.Forms.TextBox();
            this.txt_admin_isim = new System.Windows.Forms.TextBox();
            this.txt_admin_soyisim = new System.Windows.Forms.TextBox();
            this.txt_admin_yetki = new System.Windows.Forms.TextBox();
            this.txt_admin_kullanıcı_adı = new System.Windows.Forms.TextBox();
            this.txt_admin_sifre = new System.Windows.Forms.TextBox();
            this.maskedTxt_tarih_admin = new System.Windows.Forms.MaskedTextBox();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminProfiliToolStripMenuItem,
            this.üyeİşlemleriToolStripMenuItem,
            this.kitaplarToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminProfiliToolStripMenuItem
            // 
            this.adminProfiliToolStripMenuItem.Name = "adminProfiliToolStripMenuItem";
            this.adminProfiliToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.adminProfiliToolStripMenuItem.Text = "Admin Profili";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(271, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMİN PROFİLİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_admin
            // 
            this.pictureBox_admin.Location = new System.Drawing.Point(43, 128);
            this.pictureBox_admin.Name = "pictureBox_admin";
            this.pictureBox_admin.Size = new System.Drawing.Size(161, 164);
            this.pictureBox_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_admin.TabIndex = 3;
            this.pictureBox_admin.TabStop = false;
            this.pictureBox_admin.Click += new System.EventHandler(this.pictureBox_admin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "İSİM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "SOYİSİM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "YETKİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "TARİH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "KULLANICI ADI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "ŞİFRE:";
            // 
            // txt_admin_id
            // 
            this.txt_admin_id.Location = new System.Drawing.Point(412, 123);
            this.txt_admin_id.Multiline = true;
            this.txt_admin_id.Name = "txt_admin_id";
            this.txt_admin_id.Size = new System.Drawing.Size(219, 24);
            this.txt_admin_id.TabIndex = 0;
            this.txt_admin_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_admin_isim
            // 
            this.txt_admin_isim.Location = new System.Drawing.Point(412, 153);
            this.txt_admin_isim.Multiline = true;
            this.txt_admin_isim.Name = "txt_admin_isim";
            this.txt_admin_isim.Size = new System.Drawing.Size(219, 24);
            this.txt_admin_isim.TabIndex = 1;
            this.txt_admin_isim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_admin_soyisim
            // 
            this.txt_admin_soyisim.Location = new System.Drawing.Point(412, 183);
            this.txt_admin_soyisim.Multiline = true;
            this.txt_admin_soyisim.Name = "txt_admin_soyisim";
            this.txt_admin_soyisim.Size = new System.Drawing.Size(219, 24);
            this.txt_admin_soyisim.TabIndex = 2;
            this.txt_admin_soyisim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_admin_yetki
            // 
            this.txt_admin_yetki.Location = new System.Drawing.Point(412, 213);
            this.txt_admin_yetki.Multiline = true;
            this.txt_admin_yetki.Name = "txt_admin_yetki";
            this.txt_admin_yetki.Size = new System.Drawing.Size(219, 24);
            this.txt_admin_yetki.TabIndex = 3;
            this.txt_admin_yetki.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_admin_kullanıcı_adı
            // 
            this.txt_admin_kullanıcı_adı.Location = new System.Drawing.Point(412, 270);
            this.txt_admin_kullanıcı_adı.Multiline = true;
            this.txt_admin_kullanıcı_adı.Name = "txt_admin_kullanıcı_adı";
            this.txt_admin_kullanıcı_adı.Size = new System.Drawing.Size(219, 24);
            this.txt_admin_kullanıcı_adı.TabIndex = 5;
            this.txt_admin_kullanıcı_adı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_admin_sifre
            // 
            this.txt_admin_sifre.Location = new System.Drawing.Point(412, 296);
            this.txt_admin_sifre.Multiline = true;
            this.txt_admin_sifre.Name = "txt_admin_sifre";
            this.txt_admin_sifre.Size = new System.Drawing.Size(219, 24);
            this.txt_admin_sifre.TabIndex = 6;
            this.txt_admin_sifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedTxt_tarih_admin
            // 
            this.maskedTxt_tarih_admin.Location = new System.Drawing.Point(412, 240);
            this.maskedTxt_tarih_admin.Mask = "00/00/0000 90:00";
            this.maskedTxt_tarih_admin.Name = "maskedTxt_tarih_admin";
            this.maskedTxt_tarih_admin.Size = new System.Drawing.Size(219, 27);
            this.maskedTxt_tarih_admin.TabIndex = 4;
            this.maskedTxt_tarih_admin.ValidatingType = typeof(System.DateTime);
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            this.kitaplarToolStripMenuItem.Click += new System.EventHandler(this.kitaplarToolStripMenuItem_Click);
            // 
            // admin_sayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.maskedTxt_tarih_admin);
            this.Controls.Add(this.txt_admin_sifre);
            this.Controls.Add(this.txt_admin_kullanıcı_adı);
            this.Controls.Add(this.txt_admin_yetki);
            this.Controls.Add(this.txt_admin_soyisim);
            this.Controls.Add(this.txt_admin_isim);
            this.Controls.Add(this.txt_admin_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin_sayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_sayfası";
            this.Load += new System.EventHandler(this.admin_sayfası_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminProfiliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_admin_id;
        private System.Windows.Forms.TextBox txt_admin_isim;
        private System.Windows.Forms.TextBox txt_admin_soyisim;
        private System.Windows.Forms.TextBox txt_admin_yetki;
        private System.Windows.Forms.TextBox txt_admin_kullanıcı_adı;
        private System.Windows.Forms.TextBox txt_admin_sifre;
        private System.Windows.Forms.MaskedTextBox maskedTxt_tarih_admin;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
    }
}