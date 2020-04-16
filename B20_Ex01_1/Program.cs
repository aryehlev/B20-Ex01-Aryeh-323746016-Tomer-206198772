using System;

namespace B20_Ex01_1
{
    public class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Hi. Please enter the first 9 digit binary number (and press enter):");
            string firstBinaryNumberFromUser = getLegalBinaryInputFromUser();
            string secondBinaryNumberFromUser = getLegalBinaryInputFromUser();
            string thirdBinaryNumberFromUser = getLegalBinaryInputFromUser();
            string messageDecimal = string.Format(
                " these are the numbers in decimal by order:{0} , {1} , {2}" , firstBinaryNumberFromUser, secondBinaryNumberFromUser, thirdBinaryNumberFromUser);

            System.Console.WriteLine(messageDecimal);


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

        private static byte averageNumberOfZeros(string i_FirstBinaryNumber, string i_SecondBinaryNumber, string i_ThirdBinaryNumber)
        {
            byte numberOfZeros = 0;
            string stringConcatination = string.Format("{0}{1}{2}", i_FirstBinaryNumber, i_SecondBinaryNumber, i_ThirdBinaryNumber);
            foreach(char digit in stringConcatination)
            {
                if(digit == '0')
                {
                    numberOfZeros++;
                }
            }

            return numberOfZeros / (stringConcatination.Length);
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