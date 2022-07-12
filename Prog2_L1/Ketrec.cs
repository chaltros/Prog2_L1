using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_L1
{
    internal class Ketrec
    {
        private Allat[] allatok;
        public Allat[] Allatok
        {
            get { return allatok; }
            set { allatok = value; }
        }

        private string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }


        public Ketrec(string nev)
        {
            this.nev = nev;
        }
        

        void Felvetel(Allat[] allatok, Allat a)
        {
            Allat[] temp = new Allat[allatok.Length];
            int counter = 0;
            for (int i = 0; i < allatok.Length; i++)
            {
                     temp[counter++] = allatok[i];
               
            }
            temp[temp.Length - 1] = a;
            allatok = temp;
            
        }
        void Torol(ref Allat[] allatok, string allat)
        {
            Allat[] temp = new Allat[allatok.Length - 1];
            int counter = 0;
            for (int i = 0; i < allatok.Length; i++)
            {
                if (allatok[i].Nev == allat)
                {
                    temp[counter++] = allatok[i];
                }
                allatok = temp;
            }

        }
        


        public int FajDarab(string faj)
        {
            int vissza = 0;
            for (int i = 0; i < allatok.Length; i++)
            {
                List<string> vizsgalt = allatok[i].Faj;
                foreach (string j in vizsgalt)
                {
                    if (j == faj)
                    {
                        vissza++;
                    }
                }
            }

            return vissza;
        }
    }
}
