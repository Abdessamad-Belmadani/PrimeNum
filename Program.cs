using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum
{
     class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("\nEnter a number (Positive): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine($"{num} is not a valid number");
                // Console.ReadKey();
                return;
            }
            if (num <= 2)
            {
                Console.WriteLine($"{num} is not a prime number");
                // Console.ReadKey();
                return;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} is not a prime number");
                        //Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{num} is a prime number");
                        // Console.ReadKey();
                        return;
                    }

                }

            }


            // Console.ReadKey();


        }
    }
}
