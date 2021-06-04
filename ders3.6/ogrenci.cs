using System;
using System.Collections.Generic;
using System.Text;

namespace ders3._6
{
    class ogrenci
    {

        private string ad;
        private string soyAd;
        private int yas;
        private string bolum;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SoyAd
        {
            get { return soyAd; }
            set { soyAd = value; }
        }
        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }
        public int Yas
        {
            get { return yas; }
            set { if (value < 18) { yas = 18; } else { yas = value; } }
        }

    }
}
