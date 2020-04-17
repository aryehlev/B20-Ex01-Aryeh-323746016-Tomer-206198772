using System.Text;

namespace B20_Ex01_2
{
    class Program
    {
        static void Main()
        {
            SandClock(5);
        }

        public static void SandClock(int i_SizeOfSandClock)
        {
            sandClock(i_SizeOfSandClock, i_SizeOfSandClock);
        }
        private static void sandClock(int i_SizeOfSandClock, int i_NumberOfCharactersInLine)
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

        private static string generateRow(int i_SizeOfSandClock, int i_NumberOfCharactersInLine)
        { 
            StringBuilder row = new StringBuilder();
            row.Append(' ', (i_SizeOfSandClock - i_NumberOfCharactersInLine) / 2);
            row.Append('*', i_NumberOfCharactersInLine);
            row.Append(' ', (i_SizeOfSandClock - i_NumberOfCharactersInLine) / 2);
            return row.ToString();
        }
    }
}
