using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApplication
{
    internal class Sinema
    {
        List<Sinema> sinemalar = new List<Sinema>();
        public string SinemaAdi { get; set; }
        public int KisiSayisi { get; set; }
        public bool OgrenciMi { get; set; }
        public double Bakiye { get; set; }
        public int OgrenciBiletAdet { get; set; }
        public int TamBiletAdet { get; set; }

        public int KalanKoltukAdet { get; set; }


        public Sinema()
        {

        }
        public Sinema(Sinema cn)
        {
            sinemalar.Add(cn);
        }
        public Sinema(string sinemaAd, int kisiSayisi)
        {
            this.SinemaAdi = sinemaAd;
            this.KisiSayisi = kisiSayisi;
            Bakiye = 0;
            KalanKoltukAdet = KisiSayisi;
            
        }
        public double BakiyeGoster() => Bakiye;

        public int TamFiyat { get; set; } = 100;

        public int OgrenciFiyat { get; set; } = 75;

        public void BiletSat(bool kontrol, RichTextBox text)
        {
            
            if (KalanKoltukAdet > 0)
            {
                if (kontrol)
                {
                    Bakiye += OgrenciFiyat;
                    OgrenciBiletAdet++;
                }
                else
                {
                    Bakiye += TamFiyat;
                    TamBiletAdet++;
                }
                KalanKoltukAdet--;
                text.Text += $"Koltuk satıldı. satılan bilet: {(kontrol ? "Öğrenci" : "Tam")}";
            }
            else
            {
                text.Text += "Tüm koltuklar dolu!\n";
            }
            
        }
        public void BiletIade(bool kontrol, RichTextBox text, Sinema sinema)
        {
            if (Bakiye > 0 && sinema.KalanKoltukAdet<=sinema.KisiSayisi)
            {
                if (kontrol)
                {
                    Bakiye -= OgrenciFiyat;
                    OgrenciBiletAdet--;
                }
                else
                {
                    Bakiye -= TamFiyat;
                    TamBiletAdet--;
                }
                KalanKoltukAdet++;
                text.Text += "Koltuk iade edildi.";
            }
            else
            {
                text.Text += "Bir hata oluştu!\n";
            }
           
        }
       
    }
}
