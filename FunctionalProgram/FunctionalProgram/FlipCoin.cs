using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class FlipCoin
    {
        int heads = 0, tails = 0;
        double headspercent = 0.0, tailspercent = 0.0;
        Random Rand = new Random();
        public void HeadTail()
        {

            for (int i = 0; i < 1000; i++)
            {
                int coin = Rand.Next(0, 2);

                if (coin == 1)
                {
                    heads += 1;
                }
                else
                {
                    tails += 1;
                }
            }
            headspercent = Convert.ToDouble(heads / 10.0);
            tailspercent = Convert.ToDouble(100.0 - headspercent);

            Console.WriteLine($"Heads = {headspercent} ");
            Console.WriteLine($"Tails = {tailspercent} ");
        }
    }
}
