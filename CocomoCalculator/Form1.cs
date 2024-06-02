using System;
using System.Windows.Forms;

namespace CocomoCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // AIN hesaplama işlevi
            int HesaplaAIN(int[] sayilar, int[] agirlikFaktorleri)
            {
                int toplam = 0;
                for (int i = 0; i < sayilar.Length; i++)
                {
                    toplam += sayilar[i] * agirlikFaktorleri[i];
                }
                return toplam;
            }

            // TKF hesaplama işlevi
            int HesaplaTKF(int[] cevaplar)
            {
                int toplam = 0;
                foreach (int cevap in cevaplar)
                {
                    toplam += cevap;
                }
                return toplam;
            }

            // IN hesaplama işlevi
            double HesaplaIN(int ain, int tkf)
            {
                return ain * (0.65 + 0.01 * tkf);
            }

            // KLOC hesaplama işlevi
            double HesaplaKLOC(int satirSayisi)
            {
                return (double)satirSayisi / 1000;
            }

            // Ortalama personel sayısını hesaplayan işlev
            double HesaplaOrtalamaPersonel(double isGucu, double gelismeSuresi)
            {
                return isGucu / gelismeSuresi;
            }

            // COCOMO hesaplama işlevi
            void HesaplaCOCOMO(double kloc)
            {
                // KLOC değerinin bin türünden alınması
                int klocBin = (int)kloc;

                // Katsayılar
                double a = 0, b = 0, c = 0, d = 0;

                // Model seçimi
                int secim = int.Parse(txtProjeTipi.Text);

                switch (secim)
                {
                    case 1: // Ayrık Proje
                        a = 2.4; b = 1.05; c = 2.5; d = 0.38;
                        break;
                    case 2: // Yarı Gömülü Proje
                        a = 3.0; b = 1.12; c = 2.5; d = 0.35;
                        break;
                    case 3: // Gömülü Proje
                        a = 3.6; b = 1.20; c = 2.5; d = 0.32;
                        break;
                    default:
                        MessageBox.Show("Geçersiz seçim.");
                        return;
                }

                // İş gücü hesapla
                double isGucu = a * Math.Pow(klocBin, b);
                // Geliştirme süresi hesapla
                double gelismeSuresi = c * Math.Pow(klocBin, d);

                // Ortalama personel sayısını hesapla
                double ortalamaPersonel = HesaplaOrtalamaPersonel(isGucu, gelismeSuresi);

                MessageBox.Show($"COCOMO Hesapları:\nİş Gücü (K): {isGucu:F2} Kişi Ay\nGeliştirme Süresi (T): {gelismeSuresi:F2} Ay\nOrtalama Personel Sayısı: {ortalamaPersonel:F2}");
            }

            try
            {
                int[] sayilar = Array.ConvertAll(txtSayilar.Text.Split(), int.Parse);
                int[] agirlikFaktorleri = Array.ConvertAll(txtAgirlikFaktorleri.Text.Split(), int.Parse);

                int[] cevaplar = new int[8];
                cevaplar[0] = int.Parse(txtCevap1.Text);
                cevaplar[1] = int.Parse(txtCevap2.Text);
                cevaplar[2] = int.Parse(txtCevap3.Text);
                cevaplar[3] = int.Parse(txtCevap4.Text);
                cevaplar[4] = int.Parse(txtCevap5.Text);
                cevaplar[5] = int.Parse(txtCevap6.Text);
                cevaplar[6] = int.Parse(txtCevap7.Text);
                cevaplar[7] = int.Parse(txtCevap8.Text);

                int ain = HesaplaAIN(sayilar, agirlikFaktorleri);
                int tkf = HesaplaTKF(cevaplar);
                double inDegeri = HesaplaIN(ain, tkf);
                int satirSayisi = (int)(30 * inDegeri);
                double kloc = HesaplaKLOC(satirSayisi);

                MessageBox.Show($"AIN Değeri: {ain}\nTKF Değeri: {tkf}\nIN Değeri: {inDegeri:F2}\nSatır Sayısı(LOC): {satirSayisi}\nKLOC: {kloc:F2}");

                HesaplaCOCOMO(kloc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }


        private void txtCevap1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCevap3_Click(object sender, EventArgs e)
        {

        }
    }
}

