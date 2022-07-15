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

        public void Feltoltes(string[] inputText)
        {

            int counter = 0;
            for (int i = 0; i < allatkertek.Length; i++)
			{
                for (int j = 0; j < allatkertek[i].Allatok.Length; j++)
			    {
                    allatkertek[i].Allatok[j] = TextToData(inputText[counter++]); 
			    }
			}
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

        public int FajDarab(string faj)
        {
            int vissza = 0;
            List<string> vizsgalt = new List<string>();
            for (int i = 0; i < allatkertek.Length; i++)
            {
                vizsgalt = allatkertek[i].Faj;
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
