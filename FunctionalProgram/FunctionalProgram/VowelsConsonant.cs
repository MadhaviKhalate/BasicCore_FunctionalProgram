using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class VowelsConsonant
    {
        public void vowelsConsonant()
        {
            char ch;
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.Read());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
                || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine(ch + " is Vowel.");

            else
                Console.WriteLine(ch + " is Consonant.");
        }
    }
}
