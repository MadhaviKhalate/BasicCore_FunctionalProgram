using System;

namespace FunctionalProgram;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Flip Coin\n2.Leap Year\n3.Power of Two\n4.Harmonic Number\n5.Prime Factors" +
            "\n6.Quotient and Remainder\n7.Swap Numbers\n8.Even Odd\n9.Vowels and Consonant\n10.Largest Number");
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
                PowerOfTwo power = new PowerOfTwo();
                power.powerOf2();
                break;
            case 4:
                HarmonicNumber harmonic = new HarmonicNumber();
                harmonic.harmonicNumber();
                break;
            case 5:
                PrimeFactor prime_factor = new PrimeFactor();
                prime_factor.primeFactor();
                break;
            case 6:
                QuotientRemainder quotient = new QuotientRemainder();
                quotient.quotientRemainder();
                break;
            case 7:
                SwapNumber swap_number = new SwapNumber();
                swap_number.swapNumber();
                break;
            case 8:
                EvenOdd even_odd = new EvenOdd();
                even_odd.evenOdd();
                break;
            case 9:
                VowelsConsonant vowels_consonant = new VowelsConsonant();
                vowels_consonant.vowelsConsonant();
                break;
            case 10:
                LargestNumber large_number = new LargestNumber();
                large_number.largestNumber();
                break;
            default:
                //basic.HeadTail();
                break;

        }
    }
}
