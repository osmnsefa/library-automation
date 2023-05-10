namespace KÜTÜPHANE_OTOMASYONU
{
    partial class Üye_Sayfası
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
            this.button_ara_üye = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txt_kitap_ara = new System.Windows.Forms.TextBox();
            this.button_yenile_üye = new System.Windows.Forms.Button();
            this.button_cıkıs_yap = new System.Windows.Forms.Button();
            this.dataGridView_kitap_üye = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_dili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tür = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfa_sayısı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basım_yılı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kitap_üye)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ara_üye
            // 
            this.button_ara_üye.Location = new System.Drawing.Point(12, 12);
            this.button_ara_üye.Name = "button_ara_üye";
            this.button_ara_üye.Size = new System.Drawing.Size(75, 23);
            this.button_ara_üye.TabIndex = 0;
            this.button_ara_üye.Text = "ARA";
            this.button_ara_üye.UseVisualStyleBackColor = true;
            this.button_ara_üye.Click += new System.EventHandler(this.button_ara_üye_Click);
            // 
            // txt_kitap_ara
            // 
            this.txt_kitap_ara.Location = new System.Drawing.Point(93, 12);
            this.txt_kitap_ara.Name = "txt_kitap_ara";
            this.txt_kitap_ara.Size = new System.Drawing.Size(120, 22);
            this.txt_kitap_ara.TabIndex = 1;
            // 
            // button_yenile_üye
            // 
            this.button_yenile_üye.Location = new System.Drawing.Point(219, 11);
            this.button_yenile_üye.Name = "button_yenile_üye";
            this.button_yenile_üye.Size = new System.Drawing.Size(75, 23);
            this.button_yenile_üye.TabIndex = 0;
            this.button_yenile_üye.Text = "YENİLE";
            this.button_yenile_üye.UseVisualStyleBackColor = true;
            this.button_yenile_üye.Click += new System.EventHandler(this.button_yenile_üye_Click);
            // 
            // button_cıkıs_yap
            // 
            this.button_cıkıs_yap.Location = new System.Drawing.Point(27, 439);
            this.button_cıkıs_yap.Name = "button_cıkıs_yap";
            this.button_cıkıs_yap.Size = new System.Drawing.Size(113, 31);
            this.button_cıkıs_yap.TabIndex = 0;
            this.button_cıkıs_yap.Text = "ÇIKIŞ YAP";
            this.button_cıkıs_yap.UseVisualStyleBackColor = true;
            this.button_cıkıs_yap.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_kitap_üye
            // 
            this.dataGridView_kitap_üye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kitap_üye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.adı,
            this.yazar,
            this.kitap_dili,
            this.yayınevi,
            this.tür,
            this.adet,
            this.sayfa_sayısı,
            this.basım_yılı});
            this.dataGridView_kitap_üye.Location = new System.Drawing.Point(12, 40);
            this.dataGridView_kitap_üye.Name = "dataGridView_kitap_üye";
            this.dataGridView_kitap_üye.RowHeadersWidth = 51;
            this.dataGridView_kitap_üye.RowTemplate.Height = 24;
            this.dataGridView_kitap_üye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_kitap_üye.Size = new System.Drawing.Size(893, 382);
            this.dataGridView_kitap_üye.TabIndex = 4;
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
            // Üye_Sayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 505);
            this.Controls.Add(this.dataGridView_kitap_üye);
            this.Controls.Add(this.txt_kitap_ara);
            this.Controls.Add(this.button_yenile_üye);
            this.Controls.Add(this.button_cıkıs_yap);
            this.Controls.Add(this.button_ara_üye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Üye_Sayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye_Sayfası";
            this.Load += new System.EventHandler(this.Üye_Sayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kitap_üye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ara_üye;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox txt_kitap_ara;
        private System.Windows.Forms.Button button_yenile_üye;
        private System.Windows.Forms.Button button_cıkıs_yap;
        private System.Windows.Forms.DataGridView dataGridView_kitap_üye;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_dili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tür;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfa_sayısı;
        private System.Windows.Forms.DataGridViewTextBoxColumn basım_yılı;
    }
}