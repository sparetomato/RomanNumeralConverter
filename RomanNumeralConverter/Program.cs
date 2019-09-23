using System;

namespace RomanNumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Convert to Roman Numerals");
            int numToConvert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numToConvert + " is " + NumberConverter.ConvertFromNumber(numToConvert) + " in Roman Numerals");
            Console.ReadKey();

        }
    }
}
