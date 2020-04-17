using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

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
            ushort firstDecimalNumber = convertBinaryToDecimal(firstBinaryNumberFromUser);
            ushort secondDecimalNumber = convertBinaryToDecimal(secondBinaryNumberFromUser);
            ushort thirdDecimalNumber = convertBinaryToDecimal(thirdBinaryNumberFromUser);
            string messageDecimal = string.Format(
                             "these are the numbers in decimal by order:{0} , {1} , {2}",
                             firstDecimalNumber, secondDecimalNumber, thirdDecimalNumber);
            System.Console.WriteLine(messageDecimal);
            byte avgNumZeros = averageNumberOfZeros(
                firstBinaryNumberFromUser,
                secondBinaryNumberFromUser,
                thirdBinaryNumberFromUser);
            string msgAverage = string.Format(
                "The average number of zeroes in all three numbers is: {0}{2}The average number of ones in all three numbers is:{1}",
                avgNumZeros, 9 - avgNumZeros, System.Environment.NewLine);
            System.Console.WriteLine(msgAverage);
            byte numberPowerOf2s = countPowerOf2s(
                firstBinaryNumberFromUser,
                secondBinaryNumberFromUser,
                thirdBinaryNumberFromUser);
            byte number 
            string msgPowerOf2s = string.Format(
                "The amount of numbers that are a power of two is: {0}",
                numberPowerOf2s);

            

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
            return i_BinaryNumber.IndexOf('1') != -1 && i_BinaryNumber.IndexOf('1') == i_BinaryNumber.LastIndexOf('1');
        }


        private static byte countNumbersWithAscendingOrder(ushort i_FirstDecimalNumber, ushort i_SecondDecimalNumber, ushort i_ThirdBDecimalNumber)
        {
            int count = 0;
            count += isAscendingOrder(i_FirstDecimalNumber) ? 1 : 0;
            count += isAscendingOrder(i_SecondDecimalNumber) ? 1 : 0;
            count += isAscendingOrder(i_ThirdBDecimalNumber) ? 1 : 0;
            return (byte)count;
        }

        private static bool isAscendingOrder(ushort i_DecimalNumber)
        {
            string strDecimalNumber = i_DecimalNumber.ToString();
            char previousDigit = '0';
            foreach(char currentDigit in strDecimalNumber)
            {
                if(currentDigit < previousDigit)
                {
                    return false;
                }

                previousDigit = currentDigit;
            }

            return true;
        }
    }
}