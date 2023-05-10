namespace KÜTÜPHANE_OTOMASYONU
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kullanıcı_adı = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(255, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(255, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // textBox_kullanıcı_adı
            // 
            this.textBox_kullanıcı_adı.Location = new System.Drawing.Point(363, 62);
            this.textBox_kullanıcı_adı.Name = "textBox_kullanıcı_adı";
            this.textBox_kullanıcı_adı.Size = new System.Drawing.Size(139, 22);
            this.textBox_kullanıcı_adı.TabIndex = 0;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(363, 102);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(139, 22);
            this.textBox_sifre.TabIndex = 1;
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.Location = new System.Drawing.Point(346, 156);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(75, 33);
            this.button_giris.TabIndex = 2;
            this.button_giris.Text = "GİRİŞ";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_temizle.Location = new System.Drawing.Point(427, 156);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(88, 33);
            this.button_temizle.TabIndex = 3;
            this.button_temizle.Text = "TEMİZLE";
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 254);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.textBox_kullanıcı_adı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kullanıcı_adı;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Button button_temizle;
    }
}

