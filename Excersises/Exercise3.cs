using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Excersises
{
    class Exercise3
    {
        public void TamrinSevom()
        {
            long product = 1;
            Console.WriteLine("Enter numbers (enter 0 to finish):");
            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                if (number == 0)
                {
                    break;
                }
                if (number != 0)
                {
                product *= number;
                    Console.WriteLine("The product is: {0}", product);
                }


            }

                Console.WriteLine("No numbers were entered before 0.");
        }
    }
}
