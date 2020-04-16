using System;

namespace B20_Ex01_1
{
    public class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Hi. Please enter three 9 digit binary numbers (and press enter):");
            string[] inputNumbersFromUser = new string[3];
            for(int i = 0; i < inputNumbersFromUser.Length; i++)
            {
                inputNumbersFromUser[i] = getLegalBinaryInputFromUser();
            }
            System.Console.WriteLine("Your numbers, converted to decimal:");
            for (int i = 0; i < inputNumbersFromUser.Length; i++)
            {
                System.Console.WriteLine(convertBinaryToDecimal(inputNumbersFromUser[i]) + "\n");
            }

        }

        private static string getLegalBinaryInputFromUser()
        {
            string numberFromUser = System.Console.ReadLine();
            while (numberFromUser != null && numberFromUser.Length != 9 || !isValidBinary(numberFromUser))
            {
                System.Console.WriteLine("invalid input. please enter a valid binary number (and press enter):");
                numberFromUser = System.Console.ReadLine();
            }

            return numberFromUser;
        }

        private static bool isValidBinary(string i_BinaryNumber)
        {
            foreach (char digit in i_BinaryNumber)
            {
                if (digit != '0' && digit != '1')
                {
                    return false;
                }
            }

            return true;
        }

        private static ushort convertBinaryToDecimal(string i_BinaryStrToConvert)
        {
            ushort convertedNumber = 0;
            for(int i = 0; i < i_BinaryStrToConvert.Length; i++)
            {
                if(i_BinaryStrToConvert[i_BinaryStrToConvert.Length - 1 - i] == '1')
                {
                    convertedNumber += (ushort) Math.Pow(2, i);
                }
            }

            return convertedNumber;
        }

        private static byte averageNumberOfZeros(string[] i_Binary)
        {
            return 0;
        }

        private static byte averageNumberOfOnes()
        {
            return 0;
        }

        private static byte countNumbersThatAreAPowerOf2(string[] i_Binary)
        {
            return 0;
        }


    }
}