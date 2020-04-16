using System;
using System.Runtime.InteropServices;

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
                             "these are the numbers in decimal by order:{0} , {1} , {2}" ,
                             firstBinaryNumberFromUser, secondBinaryNumberFromUser, thirdBinaryNumberFromUser); 
            System.Console.WriteLine(messageDecimal);
            byte averageNumberOfZero = averageNumberOfZeros(
                firstBinaryNumberFromUser,
                secondBinaryNumberFromUser,
                thirdBinaryNumberFromUser);
            string messageAverage = string.Format(
                "The average number of zeroes in all three numbers is: {0}{2}The average number of ones in all three numbers is:{1}",
                averageNumberOfZero, 9 - averageNumberOfZero, System.Environment.NewLine);
            System.Console.WriteLine(messageAverage);
            byte countPowerOf2s = countPowerOf2s(
                firstBinaryNumberFromUser,
                secondBinaryNumberFromUser,
                thirdBinaryNumberFromUser);
            string messageAverage = string.Format(
                "The average number of zeroes in all three numbers is: {0}{2}The average number of ones in all three numbers is:{1}",
                averageNumberOfZero, 9 - averageNumberOfZero, System.Environment.NewLine);
            
            string messagePowerOf2 = string.Format("")

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
            int numberOfZeros = 0;
            string stringConcatenation = string.Format("{0}{1}{2}", i_FirstBinaryNumber, i_SecondBinaryNumber, i_ThirdBinaryNumber);
            foreach(char digit in stringConcatenation)
            {
                if(digit == '0')
                {
                    numberOfZeros++;
                }
            }

            return (byte)(numberOfZeros / 3);
        }

        private static byte countPowerOf2s(string i_FirstBinaryNumber, string i_SecondBinaryNumber, string i_ThirdBinaryNumber)
        {
            int count = 0;
            count += isAPowerOf2(i_FirstBinaryNumber) ? 1 : 0;
            count += isAPowerOf2(i_SecondBinaryNumber) ? 1 : 0;
            count += isAPowerOf2(i_ThirdBinaryNumber) ? 1 : 0;
            return (byte)count;
        }


        private static bool isAPowerOf2(string i_BinaryNumber)
        {
            return i_BinaryNumber.IndexOf('1') != i_BinaryNumber.LastIndexOf('1');
        }


    }
}