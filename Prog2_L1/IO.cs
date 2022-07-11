using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Prog2_L1
{
    enum Column
    {
        Nev,Nem,Suly,Faj
    }
    internal class IO
    {
        private string[] inputText;
        public string[] InputText
        {
            get { return inputText; }
            set { inputText = value; }
        }

        private string[] outputText;
        public string[] OutputText
        {
            get { return outputText; }
            set { outputText = value; }
        }

        public IO(string source)
        {
            Input(source);
        }

        void Input(string source)
        {
            this.inputText = File.ReadAllLines(source);
            
        }

        void Output()
        {

        }
    }
}
