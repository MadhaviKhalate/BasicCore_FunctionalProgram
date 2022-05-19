using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class QuotientRemainder
    {
        public void quotientRemainder()
        {
            int num1, num2, quotient = 0, remainder = 0;
            Console.WriteLine("Enter the value of num1 and num2");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            quotient = num1 / num2;
            remainder = num1 % num2;

            Console.WriteLine("Quotient when " + num1 + "/" + num2
                + " is: " + quotient);
            Console.WriteLine("Remainder when " + num1 + " is divided by "
                + num2 + " is: " + remainder);
        }
    }
}
