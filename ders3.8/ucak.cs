using System;
using System.Collections.Generic;
using System.Text;

namespace ders3._8
{
    class ucak:yolcu
    {
        private string marka;
        private string kalkis;
        private string varis;

        public string Marka
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
        public string Kalkis
        {
            get { return kalkis; }
            set { kalkis = value.ToUpper(); }
        }
        public string Varis
        {
            get { return varis; }
            set { varis = value.ToUpper(); }
        }

    }
}
