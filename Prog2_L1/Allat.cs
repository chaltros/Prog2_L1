using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_L1
{
    internal class Allat
    {
        private string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        private bool nem;
        public bool Nem
        {
            get { return nem; }
            set { nem = value; }
        }

        private int suly;
        public int Suly
        {
            get { return suly; }
            set { suly = value; }
        }

        private List<string> faj;
        public List<string> Faj
        {
            get { return faj; }
            set { faj = value; }
        }

        public Allat(string nev, bool nem, int suly, List<string> faj)
        {
            this.nev = nev;
            this.nem = nem;
            this.suly = suly;
            this.faj = faj;
        }

       
    }
}
