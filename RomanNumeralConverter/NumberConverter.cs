using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverter
{
    public static class NumberConverter
    {

        private static Dictionary<int, string> romanNumerals = new Dictionary<int, string>()
        {
            {1000,"M"},
            {900,"CM"},
            {500,"D"},
            {400,"CD"},
            {100,"C"},
            {90,"XC"},
            {50,"L"},
            {40,"XL"},
            {10,"X"},
            {9,"IX"},
            {5,"V"},
            {4,"IV"},
            {1,"I"},
        };


        public static string ConvertFromNumber(int numberToConvert)
        {
            string romanNumeral = string.Empty;

            if (numberToConvert > 3000)
                throw new ArgumentOutOfRangeException("This method only supports numbers up to 3000");

            foreach(int key in romanNumerals.Keys)
            {
                if(numberToConvert >= key)
                {
                    int multiplier = numberToConvert / key;
                    for(int i=0;i<multiplier;i++)
                    {
                        romanNumeral += romanNumerals[key];
                    }
                    numberToConvert = numberToConvert % key;
                }
            }

            return romanNumeral;
        }


    }
}
