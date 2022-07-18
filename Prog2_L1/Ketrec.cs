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



        public Ketrec()
        {

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
        
        


       
    }
}
