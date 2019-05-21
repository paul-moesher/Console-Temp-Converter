using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cValue;
            int fValue;
            string input;
            string C_or_F;
                do
                {
                    Console.WriteLine("Enter Temperature you want to convert (numbers only) or type Exit to end: ");
                    input = Console.ReadLine();
                    if (input == "Exit")
                    {
                        break;
                    }
                     
                Console.WriteLine("Do you want to convert to F or to C? Please only enter F or C: ");
                     C_or_F = Console.ReadLine();
                    if (C_or_F == "F")
                    {
                       cValue = Int32.Parse(input);
                        fValue = (cValue * 9) / 5 + 32;
                        Console.WriteLine("Temperature in F is: " + fValue + " Press enter to continue");
                        Console.ReadLine();
                    }
                    if (C_or_F == "C")
                    {
                       fValue = Int32.Parse(input);
                    cValue = (fValue - 32) * 5 / 9;
                    Console.WriteLine("Temperature in C is: " + cValue + " Press enter to continue");
                        Console.ReadLine();
                    }

                  
             

                }

                    while (input != "Exit");
        }
    }
}
