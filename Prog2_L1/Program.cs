﻿using System;

namespace Prog2_L1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IO io = new IO("source.txt");
            Logic sol = new Logic(5,3,3,5);
            sol.Feltoltes(io.InputText);
            Console.WriteLine(sol.FajDarab("kutya", 0) +" db kutya az első ketrecben");



            Console.ReadLine();
        }
    }
}