using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon
{
    class Arac
    {
        public Arac()
        {
            AracGirisSaat = DateTime.Now;
        }

        public string Plaka { get; set; }
        public AracTip AracTip { get; set; }
        public bool Kontak { get; set; }
        public bool Abone { get; set; }
        public DateTime AracGirisSaat { get; set; }
        public DateTime AracCikisSaat { get; set; }

        // arac iceride ne kadar sure kaldi?
        public int Sure {
            get
            {
                TimeSpan AracOtoparkKalisSure = AracCikisSaat - AracGirisSaat;

                if (AracOtoparkKalisSure-TimeSpan.FromHours((int)AracOtoparkKalisSure.TotalHours)>TimeSpan.Zero)
                {
                    // Bir ust saate yuvarliyoruz
                    AracOtoparkKalisSure = AracOtoparkKalisSure.Add(TimeSpan.FromHours(1));
                }

                return (int)AracOtoparkKalisSure.TotalHours;
            }
        }

        public decimal Ucret
        {
            get
            {
                decimal toplamTutar = AracTip.AracTipFiyat * (Sure-1) + AracTip.AracTipFiyat*2;

                if (Abone)
                {
                    toplamTutar *= 0.80m;
                }
                return toplamTutar;
            }
        }

        public override string ToString()
        {
            string aboneText = Abone?"Abone":"Abone Değil";
            string kontakText = Kontak?"Kontak Var":"Kontak Yok";
            return string.Format("{0}-{1}-{2}-{3}",Plaka,AracTip,aboneText,kontakText);
        }

    }

    class AracTip
    {
        public string AracTipAd { get; set; }
        public decimal AracTipFiyat { get; set; }

        public override string ToString()
        {
            return AracTipAd;
        }
    }
}
