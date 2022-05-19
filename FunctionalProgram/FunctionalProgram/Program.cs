using System;

namespace FunctionalProgram;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Flip Coin\n2.Leap Year\n3.Power of Two\n4.Harmonic Number\n5.Prime Factors" +
            "\n6.Quotient and Remainder\n7.Swap Numbers\n8.Even Odd\n9.Vowels and Consonant\nLargest Number");
        Console.WriteLine("Enter option ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                FlipCoin flip_coin = new FlipCoin();
                flip_coin.HeadTail();
                break;
            case 2:
                LeapYear leap_year = new LeapYear();
                leap_year.leapYear();
                break;
            case 3:
                //basic.HeadTail();
                break;
            case 4:
                //basic.HeadTail();
                break;
            case 5:
                //basic.HeadTail();
                break;
            case 6:
                //basic.HeadTail();
                break;
            case 7:
                //basic.HeadTail();
                break;
            case 8:
                //basic.HeadTail();
                break;
            case 9:
                //basic.HeadTail();
                break;
            case 10:
                //basic.HeadTail();
                break;
            default:
                //basic.HeadTail();
                break;

        }
    }
}
