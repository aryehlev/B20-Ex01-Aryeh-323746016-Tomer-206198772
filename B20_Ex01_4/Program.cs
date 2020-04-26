using System;
using System.Linq;
using System.Text;


namespace B20_Ex01_4
{
    class Program
    {
        static void Main()
        {
            string input = getValidInput();
            string isPalindromMsg = isPalindrom(input) ? "the string is a palindrom\n" : "the string is not a palindrom\n";
            string numOfCapitalsMsg = "";
            string divisibleBy5Msg = "";

            if (Char.IsLetter(input[0]))
            {
                numOfCapitalsMsg = string.Format("the number of capital letters is: {0}\n", countCapitalLetters(input));
            }

            else
            {
                divisibleBy5Msg = isDivisibleby5(input) ? "the number is divisible by 5\n" : "the number is not divisible by 5\n";
            }

            string msg = string.Format("{0}{1}{2}", isPalindromMsg, numOfCapitalsMsg, divisibleBy5Msg);
            Console.WriteLine(msg);
        }

        private static string getValidInput()
        {
            Console.WriteLine("put in an 8 digit number or a series of eight letters in english");
            string input = "";
            bool isValid = false;
            while(isValid == false)
            { 
                input = Console.ReadLine();
                if(input.Length == 8 && isAllLetters(input) || int.TryParse(input, out _))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("input not legal: put in an 8 digit number or a series of eight letters in english");
                }
            }

            return input;

        }

        private static bool isAllLetters(string i_stringToCheck)
        {
            
            foreach (char c in i_stringToCheck)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private static int countCapitalLetters(string i_inputStr)
        {
            int count = 0;
            foreach (char c in i_inputStr)
            {
                if(Char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool isDivisibleby5(string i_str)
        {
            return (i_str[7] == '5' || i_str[7] == '0');
        }

        private static bool isPalindrom(string i_str)
        {
            bool checkIfPalindrom = false;
            if(i_str.Length == 0)
            {
                checkIfPalindrom = true;
            }

            else if(i_str[0] != i_str[i_str.Length - 1])
            {
                checkIfPalindrom = false;
            }

            else
            {
                checkIfPalindrom = isPalindrom(i_str.Substring(1, i_str.Length - 2));
            }

            return checkIfPalindrom;
        }
    }
}
