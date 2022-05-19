using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class LargestNumber
    {
        public void largestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter value for number1 ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for number2 ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for number3 ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.Write(num1 + " is the largest number\n");
            else if (num2 > num3)
                Console.Write(num2 + " is the largest number\n");
            else
                Console.Write(num3 + " is the largest number\n");
        }
    }
}
