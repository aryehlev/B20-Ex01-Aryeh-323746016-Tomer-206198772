using System;
using System.Text;


namespace B20_Ex01_1
{
    public class Program
    { 
        const int numOfArguments = 3;
        static void Main()
        {
            string firstMsg = string.Format(
                "Hi.Please enter {0} 9 digit binary numbers and after every one press enter: ",
                numOfArguments);
            Console.WriteLine(firstMsg);
            StringBuilder numsForMessageDecimal = new StringBuilder();
            byte numOfZeros = 0;
            byte numOfOnes = 0;
            byte countNumPowerOf2 = 0;
            byte numOfAscendingNumbers = 0;
            string binaryNumberFromUser = "";
            ushort decimalNumber = 0;
            ushort maxNum = 0;
            ushort minNum = ushort.MaxValue;
            for (int i = 0; i < numOfArguments; i++)
            { 
                binaryNumberFromUser = getLegalBinaryInputFromUser();
                decimalNumber = convertBinaryToDecimal(binaryNumberFromUser);
                numsForMessageDecimal.Append(string.Format("{0}, ", decimalNumber)); 
                numOfZeros += numberOfZeros(binaryNumberFromUser);
                if(isAPowerOf2(binaryNumberFromUser) == true)
                {
                    countNumPowerOf2++;
                }

                if(isAscendingOrder(decimalNumber) == true)
                {
                    numOfAscendingNumbers++;
                }

                if(decimalNumber > maxNum)
                {
                    maxNum = decimalNumber;
                }

                if(decimalNumber < minNum)
                {
                    minNum = decimalNumber;
                }
            }

            string msg = string.Format(
@"These are the numbers in decimal by order: {0} 
The average number of zeroes in all three numbers is: {1} 
The average number of ones in all three numbers is: {2}
The amount of numbers that are a power of 2 is: {3}
The amount of numbers that are in ascending orders is: {4}
The minimal number is: {5}, the maximal number is: {6}",
numsForMessageDecimal, numOfZeros / numOfArguments, 9 - (numOfZeros / numOfArguments),
countNumPowerOf2, numOfAscendingNumbers, minNum, maxNum
            );
            Console.WriteLine(msg);

        }
        private static string getLegalBinaryInputFromUser()
        {
            string numberFromUser = Console.ReadLine();
            while (numberFromUser != null && numberFromUser.Length != 9 || !isValidBinary(numberFromUser))
            {
                Console.WriteLine("invalid input. please enter a valid binary number (and press enter):");
                numberFromUser = Console.ReadLine();
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
        private static byte numberOfZeros(string i_BinaryNumber)
        {
            byte numberOfZeros = 0;
            foreach(char digit in i_BinaryNumber)
            {
                if(digit == '0')
                {
                    numberOfZeros++;
                }
            }

            return numberOfZeros;
        }
        private static bool isAPowerOf2(string i_BinaryNumber)
        {
            return i_BinaryNumber.IndexOf('1') != -1 && i_BinaryNumber.IndexOf('1') == i_BinaryNumber.LastIndexOf('1');
        }
        private static bool isAscendingOrder(ushort i_DecimalNumber)
        {
            string strDecimalNumber = i_DecimalNumber.ToString();
            char previousDigit = '0';
            foreach(char currentDigit in strDecimalNumber)
            {
                if(currentDigit <= previousDigit)
                {
                    return false;
                }

                previousDigit = currentDigit;
            }

            return true;
        }

        
    }
}