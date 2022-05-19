using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class PowerOfTwo
    {
        public void powerOf2()
        {
            int N;
            Console.WriteLine("Enter value ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The table of powers of two upto 2^N ");
            for (int i = 0; i <= N; i++)
            Console.WriteLine("2^" + i + "=" + Math.Pow(i, 2));
        }
    }
}
