using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class PrimeFactor
    {
        public void primeFactor()
        {
            int number;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime factors of {number} are ");
            for (int i = 2; i * i <= number;)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
                else
                    i += 1;
            }
            Console.WriteLine(number);

        }
    }
}
