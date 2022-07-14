using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_L1
{
    internal class Logic
    {
        private Ketrec[] allatkertek = new Ketrec[4]
        {

        };

        public Ketrec[] Allatkertek
        {
            get { return allatkertek ; }
            set { allatkertek = value; }
        } 



        public Logic(int elso, int masodik, int harmadik, int negyedik)
        {
            allatkertek[0].Allatok = new Allat[elso];
            allatkertek[1].Allatok = new Allat[masodik];
            allatkertek[2].Allatok = new Allat[harmadik];
            allatkertek[3].Allatok = new Allat[negyedik];
        }

        public void Feltoltes(Ketrec[] allatkertek, string[] inputText)
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
            for (int i = 0; i < array[2].Split(',').Length; i++)
            {
                faj.Add(array[2].Split(',')[i]);
            }

            back = new Allat(array[0], nem, int.Parse(array[1]), faj);

            return back;
         }

    }
}
