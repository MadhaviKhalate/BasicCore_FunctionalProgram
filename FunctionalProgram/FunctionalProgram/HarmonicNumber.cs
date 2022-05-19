using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class HarmonicNumber
    {
        public void harmonicNumber()
        {
            int i, number;
            double result = 1.0;

            Console.WriteLine("Calculate the harmonic series and their sum:\n\n");
            Console.WriteLine("Enter Number ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write($"1/1");
            for (i = 2; i <= number; i++)
            {
                Console.Write($" + 1/{i} ");
                result += 1 / (double)i;
            }
            Console.Write($"\nSum of Series upto {number} terms : {result} \n");
        }
    }
}
