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

            if (numberToConvert > 3000)
                throw new ArgumentOutOfRangeException("This method only supports numbers up to 89");

            if (numberToConvert >= 1000)
            {
                while (numberToConvert > 1000)
                {
                    romanNumeral += "M";
                    numberToConvert = numberToConvert - 1000;
                }
            }

            if (numberToConvert >= 900 && numberToConvert < 1000)
            {
                romanNumeral += "CM";
                numberToConvert = numberToConvert - 900;
            }

            if (numberToConvert >= 500)
            {
                romanNumeral += "D";
                numberToConvert = numberToConvert - 500;
            }

            if (numberToConvert >= 400 && numberToConvert <500)
            {
                    romanNumeral += "CD";
                    numberToConvert = numberToConvert - 400;
            }

            if (numberToConvert >= 100)
            {
                while (numberToConvert >= 100)
                {
                    romanNumeral += "C";
                    numberToConvert = numberToConvert - 100;
                }
            }

            if(numberToConvert >= 90 && numberToConvert <100)
            {
                romanNumeral += "XC";
                numberToConvert = numberToConvert - 90;
            }

            if(numberToConvert >=50 && numberToConvert < 90)
            {
                romanNumeral += "L";
                numberToConvert = numberToConvert - 50;
            }

            if(numberToConvert >=40 && numberToConvert<50)
            {
                romanNumeral += "XL";
                numberToConvert = numberToConvert - 40;
            }

            if(numberToConvert >= 10 && numberToConvert <=39)
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
