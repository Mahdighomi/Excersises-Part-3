﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersises
{
    class Exercise1
    {
        public void TamrinAval()
        {
            Console.Write("Enter a number (1 to 7): ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1: Console.WriteLine("Saturday"); break;
                case 2: Console.WriteLine("Sunday"); break;
                case 3: Console.WriteLine("Monday"); break;
                case 4: Console.WriteLine("Tuesday"); break;
                case 5: Console.WriteLine("Wednesday"); break;
                case 6: Console.WriteLine("Thursday"); break;
                case 7: Console.WriteLine("Friday"); break;
                default: Console.WriteLine("END"); break;
            }
        }
    }
}
