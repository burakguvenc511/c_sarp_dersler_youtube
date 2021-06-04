using System;
using System.Collections.Generic;
using System.Text;

namespace ders3._8
{
    class yolcu
    {
        private string ad;
        private string soyAd;
        private int yas;
        private string cinsiyet;

        public string Ad
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
        public string SoyAd
        {
            get { return soyAd; }
            set { soyAd = value.ToUpper(); }
        }
        public int Yas
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value.ToLower(); }
        }

    }
}
