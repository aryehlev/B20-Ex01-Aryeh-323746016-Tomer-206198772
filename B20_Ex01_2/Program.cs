using System.Text;

namespace B20_Ex01_2
{
    public class Program
    {
        static void Main()
        {
            SandClock(5);
        }

        public static void SandClock(uint i_SizeOfSandClock)
        {
            sandClock(i_SizeOfSandClock, i_SizeOfSandClock);
        }
        private static void sandClock(uint i_SizeOfSandClock, uint i_NumberOfCharactersInLine)
        {
            string rowToPrint = "";
            if (i_NumberOfCharactersInLine == 1)
            {
                rowToPrint = generateRow(i_SizeOfSandClock, i_NumberOfCharactersInLine);
            }
            else
            {
                rowToPrint = generateRow(i_SizeOfSandClock, i_NumberOfCharactersInLine);
                System.Console.WriteLine(rowToPrint);
                sandClock(i_SizeOfSandClock, i_NumberOfCharactersInLine - 2);
            }
            System.Console.WriteLine(rowToPrint);
        }

        private static string generateRow(uint i_SizeOfSandClock, uint i_NumberOfCharactersInLine)
        { 
            StringBuilder row = new StringBuilder();
            row.Append(' ', (int)(i_SizeOfSandClock - i_NumberOfCharactersInLine) / 2);
            row.Append('*', (int)i_NumberOfCharactersInLine);
            row.Append(' ', (int)(i_SizeOfSandClock - i_NumberOfCharactersInLine) / 2);
            return row.ToString();
        }
    }
}
