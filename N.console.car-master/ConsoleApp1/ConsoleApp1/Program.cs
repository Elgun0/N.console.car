using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ncars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("M5", "Bmw", 65, 15);


            string userInput;
            do
            {
                Console.WriteLine("Welcome to BP");
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top Up");
                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Reset");
                Console.WriteLine("5.Exit");
                userInput = Console.ReadLine();

                if (Utilities.IsNumber(userInput))
                {
                    switch (userInput)
                    {
                        case "1":
                            bmw.Go();
                            break;
                        case "2":
                            bmw.TopUp();
                            break;
                        case "3":
                            bmw.Stop();
                            break;
                        case "4":
                            bmw.Reset();
                            break;
                        default:
                            Console.WriteLine("Please write the numbers above");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please write only numeric number");
                }
                Console.ReadKey();

            } while (userInput != "5");

        }
    }
}
