namespace CocomoCalculator
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
            this.lblSayilar = new System.Windows.Forms.Label();
            this.txtSayilar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblAgirlikFaktorleri = new System.Windows.Forms.Label();
            this.lblCevap1 = new System.Windows.Forms.Label();
            this.lblCevap2 = new System.Windows.Forms.Label();
            this.lblCevap3 = new System.Windows.Forms.Label();
            this.lblCevap4 = new System.Windows.Forms.Label();
            this.lblCevap5 = new System.Windows.Forms.Label();
            this.lblCevap6 = new System.Windows.Forms.Label();
            this.lblCevap7 = new System.Windows.Forms.Label();
            this.lblCevap8 = new System.Windows.Forms.Label();
            this.lblProjeTipi = new System.Windows.Forms.Label();
            this.txtAgirlikFaktorleri = new System.Windows.Forms.TextBox();
            this.txtCevap1 = new System.Windows.Forms.TextBox();
            this.txtCevap2 = new System.Windows.Forms.TextBox();
            this.txtCevap3 = new System.Windows.Forms.TextBox();
            this.txtCevap4 = new System.Windows.Forms.TextBox();
            this.txtCevap5 = new System.Windows.Forms.TextBox();
            this.txtCevap6 = new System.Windows.Forms.TextBox();
            this.txtCevap7 = new System.Windows.Forms.TextBox();
            this.txtCevap8 = new System.Windows.Forms.TextBox();
            this.txtProjeTipi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSayilar
            // 
            this.lblSayilar.AutoSize = true;
            this.lblSayilar.BackColor = System.Drawing.Color.Transparent;
            this.lblSayilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblSayilar.Location = new System.Drawing.Point(35, 44);
            this.lblSayilar.Name = "lblSayilar";
            this.lblSayilar.Size = new System.Drawing.Size(384, 34);
            this.lblSayilar.TabIndex = 0;
            this.lblSayilar.Text = "Ölçüm Parametreleri:\r\n(Sayı değerlerini arada boşluk olacak şekilde art arda giri" +
    "n)";
            this.lblSayilar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSayilar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSayilar
            // 
            this.txtSayilar.ForeColor = System.Drawing.Color.Black;
            this.txtSayilar.Location = new System.Drawing.Point(125, 90);
            this.txtSayilar.Name = "txtSayilar";
            this.txtSayilar.Size = new System.Drawing.Size(234, 25);
            this.txtSayilar.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(397, 486);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(200, 34);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Cocomo Sonucunu Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblAgirlikFaktorleri
            // 
            this.lblAgirlikFaktorleri.AutoSize = true;
            this.lblAgirlikFaktorleri.BackColor = System.Drawing.Color.Transparent;
            this.lblAgirlikFaktorleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblAgirlikFaktorleri.Location = new System.Drawing.Point(549, 44);
            this.lblAgirlikFaktorleri.Name = "lblAgirlikFaktorleri";
            this.lblAgirlikFaktorleri.Size = new System.Drawing.Size(384, 34);
            this.lblAgirlikFaktorleri.TabIndex = 3;
            this.lblAgirlikFaktorleri.Text = "Ağırlık Faktörleri\r\n(Sayı değerlerini arada boşluk olacak şekilde art arda girin)" +
    "";
            this.lblAgirlikFaktorleri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCevap1
            // 
            this.lblCevap1.AutoSize = true;
            this.lblCevap1.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap1.Location = new System.Drawing.Point(35, 170);
            this.lblCevap1.Name = "lblCevap1";
            this.lblCevap1.Size = new System.Drawing.Size(247, 34);
            this.lblCevap1.TabIndex = 4;
            this.lblCevap1.Text = "1. Uygulama, güvenilir yedekleme ve \r\nkurtarma gerektiriyor mu? (0-5):";
            // 
            // lblCevap2
            // 
            this.lblCevap2.AutoSize = true;
            this.lblCevap2.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap2.Location = new System.Drawing.Point(35, 227);
            this.lblCevap2.Name = "lblCevap2";
            this.lblCevap2.Size = new System.Drawing.Size(247, 17);
            this.lblCevap2.TabIndex = 5;
            this.lblCevap2.Text = "2. Veri iletişimi gerektiriyor mu? (0-5):";
            // 
            // lblCevap3
            // 
            this.lblCevap3.AutoSize = true;
            this.lblCevap3.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap3.Location = new System.Drawing.Point(35, 279);
            this.lblCevap3.Name = "lblCevap3";
            this.lblCevap3.Size = new System.Drawing.Size(234, 17);
            this.lblCevap3.TabIndex = 6;
            this.lblCevap3.Text = "3. Dağıtılmış İşlemler var mı? (0-5):";
            this.lblCevap3.Click += new System.EventHandler(this.lblCevap3_Click);
            // 
            // lblCevap4
            // 
            this.lblCevap4.AutoSize = true;
            this.lblCevap4.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap4.Location = new System.Drawing.Point(35, 328);
            this.lblCevap4.Name = "lblCevap4";
            this.lblCevap4.Size = new System.Drawing.Size(201, 17);
            this.lblCevap4.TabIndex = 7;
            this.lblCevap4.Text = "4. Performans kritik mi? (0-5):";
            // 
            // lblCevap5
            // 
            this.lblCevap5.AutoSize = true;
            this.lblCevap5.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap5.Location = new System.Drawing.Point(598, 332);
            this.lblCevap5.Name = "lblCevap5";
            this.lblCevap5.Size = new System.Drawing.Size(252, 34);
            this.lblCevap5.TabIndex = 8;
            this.lblCevap5.Text = "8. Dönüştürme ve kurulun  tasarımda \r\ndikkate alınacak mı? (0-5):";
            // 
            // lblCevap6
            // 
            this.lblCevap6.AutoSize = true;
            this.lblCevap6.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap6.Location = new System.Drawing.Point(599, 167);
            this.lblCevap6.Name = "lblCevap6";
            this.lblCevap6.Size = new System.Drawing.Size(223, 34);
            this.lblCevap6.TabIndex = 9;
            this.lblCevap6.Text = "5. Girdiler, çıktılar, dosyalar ya da \r\nsorgular karmaşık mı? (0-5):";
            // 
            // lblCevap7
            // 
            this.lblCevap7.AutoSize = true;
            this.lblCevap7.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap7.Location = new System.Drawing.Point(598, 224);
            this.lblCevap7.Name = "lblCevap7";
            this.lblCevap7.Size = new System.Drawing.Size(239, 17);
            this.lblCevap7.TabIndex = 10;
            this.lblCevap7.Text = "6. İçsel işlemler karmaşık mı? (0-5):";
            // 
            // lblCevap8
            // 
            this.lblCevap8.AutoSize = true;
            this.lblCevap8.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap8.Location = new System.Drawing.Point(598, 276);
            this.lblCevap8.Name = "lblCevap8";
            this.lblCevap8.Size = new System.Drawing.Size(195, 34);
            this.lblCevap8.TabIndex = 11;
            this.lblCevap8.Text = "7. Tasarlanacak kod yeniden \r\nkullanılabilir mi? (0-5):";
            this.lblCevap8.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblProjeTipi
            // 
            this.lblProjeTipi.AutoSize = true;
            this.lblProjeTipi.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeTipi.Location = new System.Drawing.Point(377, 384);
            this.lblProjeTipi.Name = "lblProjeTipi";
            this.lblProjeTipi.Size = new System.Drawing.Size(242, 34);
            this.lblProjeTipi.TabIndex = 12;
            this.lblProjeTipi.Text = "Proje Tipi \r\n(1: Ayrık, 2: Yarı Gömülü, 3: Gömülü)";
            this.lblProjeTipi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAgirlikFaktorleri
            // 
            this.txtAgirlikFaktorleri.ForeColor = System.Drawing.Color.Black;
            this.txtAgirlikFaktorleri.Location = new System.Drawing.Point(625, 90);
            this.txtAgirlikFaktorleri.Name = "txtAgirlikFaktorleri";
            this.txtAgirlikFaktorleri.Size = new System.Drawing.Size(241, 25);
            this.txtAgirlikFaktorleri.TabIndex = 13;
            // 
            // txtCevap1
            // 
            this.txtCevap1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCevap1.Location = new System.Drawing.Point(304, 170);
            this.txtCevap1.Name = "txtCevap1";
            this.txtCevap1.Size = new System.Drawing.Size(100, 25);
            this.txtCevap1.TabIndex = 14;
            this.txtCevap1.TextChanged += new System.EventHandler(this.txtCevap1_TextChanged);
            // 
            // txtCevap2
            // 
            this.txtCevap2.Location = new System.Drawing.Point(304, 227);
            this.txtCevap2.Name = "txtCevap2";
            this.txtCevap2.Size = new System.Drawing.Size(100, 25);
            this.txtCevap2.TabIndex = 15;
            // 
            // txtCevap3
            // 
            this.txtCevap3.Location = new System.Drawing.Point(304, 279);
            this.txtCevap3.Name = "txtCevap3";
            this.txtCevap3.Size = new System.Drawing.Size(100, 25);
            this.txtCevap3.TabIndex = 16;
            // 
            // txtCevap4
            // 
            this.txtCevap4.Location = new System.Drawing.Point(304, 328);
            this.txtCevap4.Name = "txtCevap4";
            this.txtCevap4.Size = new System.Drawing.Size(100, 25);
            this.txtCevap4.TabIndex = 17;
            // 
            // txtCevap5
            // 
            this.txtCevap5.Location = new System.Drawing.Point(862, 332);
            this.txtCevap5.Name = "txtCevap5";
            this.txtCevap5.Size = new System.Drawing.Size(100, 25);
            this.txtCevap5.TabIndex = 18;
            // 
            // txtCevap6
            // 
            this.txtCevap6.Location = new System.Drawing.Point(862, 167);
            this.txtCevap6.Name = "txtCevap6";
            this.txtCevap6.Size = new System.Drawing.Size(100, 25);
            this.txtCevap6.TabIndex = 19;
            // 
            // txtCevap7
            // 
            this.txtCevap7.Location = new System.Drawing.Point(862, 224);
            this.txtCevap7.Name = "txtCevap7";
            this.txtCevap7.Size = new System.Drawing.Size(100, 25);
            this.txtCevap7.TabIndex = 20;
            // 
            // txtCevap8
            // 
            this.txtCevap8.Location = new System.Drawing.Point(862, 276);
            this.txtCevap8.Name = "txtCevap8";
            this.txtCevap8.Size = new System.Drawing.Size(100, 25);
            this.txtCevap8.TabIndex = 21;
            // 
            // txtProjeTipi
            // 
            this.txtProjeTipi.ForeColor = System.Drawing.Color.Black;
            this.txtProjeTipi.Location = new System.Drawing.Point(470, 432);
            this.txtProjeTipi.Name = "txtProjeTipi";
            this.txtProjeTipi.Size = new System.Drawing.Size(51, 25);
            this.txtProjeTipi.TabIndex = 22;
            this.txtProjeTipi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 546);
            this.Controls.Add(this.txtProjeTipi);
            this.Controls.Add(this.txtCevap8);
            this.Controls.Add(this.txtCevap7);
            this.Controls.Add(this.txtCevap6);
            this.Controls.Add(this.txtCevap5);
            this.Controls.Add(this.txtCevap4);
            this.Controls.Add(this.txtCevap3);
            this.Controls.Add(this.txtCevap2);
            this.Controls.Add(this.txtCevap1);
            this.Controls.Add(this.txtAgirlikFaktorleri);
            this.Controls.Add(this.lblProjeTipi);
            this.Controls.Add(this.lblCevap8);
            this.Controls.Add(this.lblCevap7);
            this.Controls.Add(this.lblCevap6);
            this.Controls.Add(this.lblCevap5);
            this.Controls.Add(this.lblCevap4);
            this.Controls.Add(this.lblCevap3);
            this.Controls.Add(this.lblCevap2);
            this.Controls.Add(this.lblCevap1);
            this.Controls.Add(this.lblAgirlikFaktorleri);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayilar);
            this.Controls.Add(this.lblSayilar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CocomoCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayilar;
        private System.Windows.Forms.TextBox txtSayilar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblAgirlikFaktorleri;
        private System.Windows.Forms.Label lblCevap1;
        private System.Windows.Forms.Label lblCevap2;
        private System.Windows.Forms.Label lblCevap3;
        private System.Windows.Forms.Label lblCevap4;
        private System.Windows.Forms.Label lblCevap5;
        private System.Windows.Forms.Label lblCevap6;
        private System.Windows.Forms.Label lblCevap7;
        private System.Windows.Forms.Label lblCevap8;
        private System.Windows.Forms.Label lblProjeTipi;
        private System.Windows.Forms.TextBox txtAgirlikFaktorleri;
        private System.Windows.Forms.TextBox txtCevap1;
        private System.Windows.Forms.TextBox txtCevap2;
        private System.Windows.Forms.TextBox txtCevap3;
        private System.Windows.Forms.TextBox txtCevap4;
        private System.Windows.Forms.TextBox txtCevap5;
        private System.Windows.Forms.TextBox txtCevap6;
        private System.Windows.Forms.TextBox txtCevap7;
        private System.Windows.Forms.TextBox txtCevap8;
        private System.Windows.Forms.TextBox txtProjeTipi;
    }
}

