using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_L1
{
    internal class Logic
    {


        public Logic()
        {

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
            string[] array = text.Split(' ');
            bool nem = true;
            if (text[1] == nosteny){
                nem = false;
            }
            Allat back = new Allat(array[0], nem, array[2], array[3]);
            return back;
         }

    }
}
