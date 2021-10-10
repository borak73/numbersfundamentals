using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace NypOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EkraniAyarla()
        {
            basTxtBox.Text = bitTxtBox.Text = "0";
            basTxtBox.Focus();
        }
        private Boolean kontrolEt(int sayi1, int sayi2)
        {
            if (sayi1 < 1 || sayi2 > 10000)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(basTxtBox.Text);
                Convert.ToInt32(bitTxtBox.Text);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private Boolean asalMi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            if (i == sayi)
            {
                return true;
            }
            return false;

        }
        private Boolean mukemmelSayiMi(int sayi)
        {
            int toplam = 0, n;

            n = sayi;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void calistirBTN_Click(object sender, EventArgs e)
        {
            teksayilarLV.Items.Clear();
            ciftsayilarLV.Items.Clear();
            asalsayilarLV.Items.Clear();
            mukemmelLV.Items.Clear();
            int bas = Convert.ToInt32(basTxtBox.Text), bit = Convert.ToInt32(bitTxtBox.Text);

            if (kontrolEt(bas, bit))
            {
                MessageBox.Show("Girdiğiniz Değerleri Kontrol Ediniz");
                EkraniAyarla();
            }
            else
            {
                if (Dogrula())
                {
                    BigInteger tekToplam = 0, tekCarpim = 1, ciftToplam = 0, ciftCarpim = 1, asalToplam = 0, asalCarpim = 1, mukToplam = 0, mukCarpim = 1;

                    for (int i = bas; i <= bit; i++)
                    {
                        if (i % 2 == 1)
                        {
                            tekToplam += i;
                            tekCarpim *= i;
                            teksayilarLV.Items.Add(i.ToString());
                        }
                        else if (i % 2 == 0)
                        {
                            ciftToplam += i;
                            ciftCarpim *= i;
                            ciftsayilarLV.Items.Add(i.ToString());

                        }
                        if (asalMi(i))
                        {

                            asalsayilarLV.Items.Add(i.ToString());
                            asalToplam += i;
                            asalCarpim *= i;
                        }
                        if (mukemmelSayiMi(i))
                        {
                            mukemmelLV.Items.Add(i.ToString());
                            mukToplam += i;
                            mukCarpim *= i;

                        }

                    }

                    teksayilarLV.Items.Add("Tek Sayıların Toplamı: " + tekToplam.ToString());
                    teksayilarLV.Items.Add("Tek Sayıların Çarpımı: " + tekCarpim.ToString());
                    ciftsayilarLV.Items.Add("Çift Sayıların Toplamı: " + ciftToplam.ToString());
                    ciftsayilarLV.Items.Add("Çift Sayıların Çarpımı: " + ciftCarpim.ToString());
                    asalsayilarLV.Items.Add("Asal Sayıların Toplamı: " + asalToplam.ToString());
                    asalsayilarLV.Items.Add("Asal Sayıların Çarpımı: " + asalCarpim.ToString());
                    mukemmelLV.Items.Add("Mükemmel Sayıların Toplamı: " + mukToplam.ToString());
                    mukemmelLV.Items.Add("Mükemmel Sayıların Çarpımı: " + mukCarpim.ToString());

                    EkraniAyarla();
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            EkraniAyarla();
        }

        private void notify(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipText = "Nesne Yönelimli Programlama";
            notifyIcon1.BalloonTipTitle = "Odev1";
            notifyIcon1.ShowBalloonTip(2000);

        }

    }

}