using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverter
{
    public static class NumberConverter
    {
        public static string ConvertFromNumber(int numberToConvert)
        {
            string romanNumeral = string.Empty;

            if(numberToConvert >= 10)
            {
                while (numberToConvert >= 10)
                {
                    romanNumeral += "X";
                    numberToConvert = numberToConvert - 10;
                }
            }

            if(numberToConvert == 9)
            {
                romanNumeral += "IX";
                numberToConvert = 0;
            }

            if (numberToConvert >= 5 && numberToConvert <= 8)
            {
                romanNumeral += "V";
                numberToConvert = numberToConvert - 5;
            }

            if (numberToConvert == 4)
            {
                romanNumeral += "IV";
                numberToConvert = 0;
            }

            for(int i = 0; i< numberToConvert; i++)
            {
                romanNumeral += "I";
            }
            return romanNumeral;
        }
    }
}
