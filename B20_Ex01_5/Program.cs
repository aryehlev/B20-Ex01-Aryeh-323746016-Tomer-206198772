using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex01_5
{
    class Program
    {
        static void Main()
        {
            string input = getValidInput();
            string msg = string.Format(
@"the biggest digit is {0}
the smallest digit is {1}
the number of digits that are divisible by 3 is {2}
the number of digits that are bigger than the first digit is {3}",
                findBiggestDigit(input),
                findSmallestDigit(input),
                numOfDigitsDivisibleBy3(input),
                numOfDigitsBiggerThanFirstDigit(input));
            Console.WriteLine(msg);

        }

        private static string getValidInput()
        {
            Console.WriteLine("put in an 9 digit number ");
            string input = "";
            bool isValid = false;
            while (isValid == false)
            {
                input = Console.ReadLine();
                if (input.Length == 9 && int.TryParse(input, out _))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("input not legal: put in an 9 digit number");
                }
            }

            return input;
        }

        private static char findBiggestDigit(string i_str)
        {
            char maxDigit = '0';
            foreach(char c in i_str)
            {
                if(c > maxDigit)
                {
                    maxDigit = c;
                }
            }

            return maxDigit;
        }

        private static char findSmallestDigit(string i_str)
        {
            char minDigit = '9';
            foreach (char c in i_str)
            {
                if (c < minDigit)
                {
                    minDigit = c;
                }
            }

            return minDigit;
        }

        private static byte numOfDigitsDivisibleBy3(string i_str)
        {
            byte count = 0;
            foreach (char c in i_str)
            {
                if ((c - '0') % 3 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        private static byte numOfDigitsBiggerThanFirstDigit(string i_str)
        {
            byte count = 0;
            char firstDigit = i_str[i_str.Length-1];
            foreach (char c in i_str)
            {
                if (c > firstDigit)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
