using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class SwapNumber
    {
        public void swapNumber()
        {
            int number1, number2, temp = 0;
            Console.WriteLine("Enter value for number1 ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for number1 ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
        }
    }
}
