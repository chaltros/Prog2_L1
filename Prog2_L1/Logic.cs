using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_L1
{
    internal class Logic
    {
        private Ketrec[] allatkertek = new Ketrec[4];
        public Ketrec[] Allatkertek
        {
            get { return allatkertek ; }
            set { allatkertek = value; }
        } 



        public Logic(int elso, int masodik, int harmadik, int negyedik)
        {
            for (int i = 0; i < allatkertek.Length; i++)
            {
                allatkertek[i] = new Ketrec();
            }
            allatkertek[0].Allatok = new Allat[elso];
            allatkertek[1].Allatok = new Allat[masodik];
            allatkertek[2].Allatok = new Allat[harmadik];
            allatkertek[3].Allatok = new Allat[negyedik];
        }

        public bool Feltoltes(string[] inputText)
        {
            bool back = false;
            if (allatkertek[allatkertek.Length - 1].Allatok[0] != null)
            {
                int counter = 0;
                for (int i = 0; i < allatkertek.Length; i++)
                {
                    for (int j = 0; j < allatkertek[i].Allatok.Length; j++)
                    {

                        allatkertek[i].Allatok[j] = TextToData(inputText[counter++]);
                    }
                }
                back = true;
            }
            return back;

            
        }
        bool Torol(ref Allat[] allatok, string allat)
        {
            bool back = false;
            Allat[] temp = new Allat[allatok.Length - 1];
            int counter = 0;
            for (int i = 0; i < allatok.Length; i++)
            {
                if (allatok[i].Nev != allat)
                {
                    temp[counter++] = allatok[i];
                }
                else
                {
                    back = true;
                }
                allatok = temp;
            }

            return back;
        }
        Allat TextToData(string text)
         {
            Allat back;
            string[] array = text.Split(' ');
            bool nem = true;

            if (array[1] == "nosteny"){
                nem = false;
            }
            List<string> faj = new List<string>();
            string[] tempArr = array[2].Split(' ');
            for (int i = 0; i < tempArr.Length; i++)
            {
                faj.Add(tempArr[i]);
            }
            back = new Allat(array[0], nem, int.Parse(array[2]), faj);

            return back;
         }

        public int FajDarab(string faj, int sorszam) 
        {
            int back = 0;
            Allat[] act = allatkertek[sorszam].Allatok;

            foreach (Allat i in act) 
            {
                foreach (string j in i.Faj)
                {
                    if (j == faj)
                    {
                        back++;
                    }
                }
            }

            return back;
        }

        bool FajEsNemVanE(string name, bool gender)
        {
            bool back = false;


            for (int i = 0; i < allatkertek.Length; i++)
            {
                for (int j = 0; j < allatkertek[i].Allatok.Length; j++)
                {
                    if (allatkertek[i].Allatok[j].Nev == name 
                        && allatkertek[i].Allatok[j].Nem == gender){
                        back = true;
                    }
                }
            }
            return back;
        }




    }
}
