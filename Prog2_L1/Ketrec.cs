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

        

        void Felvetel(ref Allat[] allatok, Allat a)
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
        void Feltoltes(Allat[] allatok, string[] inputText)
        {
            allatok = new Allat[inputText.Length - 1];
            for (int i = 0; i < inputText.Length; i++)
            {
                string[] row = inputText[i].Split(' ');
                allatok[i].Nev
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
