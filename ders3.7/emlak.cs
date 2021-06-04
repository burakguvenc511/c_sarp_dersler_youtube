using System;
using System.Collections.Generic;
using System.Text;

namespace ders3._7
{
    class emlak
    {
        private string semt;
        private string renk;
        private int odaSayısı;
        private int katNo;
        private double alan;


        public string Semt
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string Renk
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }
        public int OdaSayisi
        {
            get { return odaSayısı; }
            set { odaSayısı = Math.Abs(value); }
        }
        public int KatNo
        {
            get { return katNo; }
            set { katNo = Math.Abs(value); }
        }
        public double Alan
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }

    }
}
