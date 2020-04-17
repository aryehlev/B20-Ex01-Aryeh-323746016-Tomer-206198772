namespace B20_Ex01_3
{
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("Please enter the number of lines for the sand machine:");
            uint sizeOfClock = getLegalInputFromUser();
            sandClockAdvanced(sizeOfClock);
            System.Console.WriteLine("Please write enter to exit program:");
            System.Console.ReadLine();

        }

        private static uint getLegalInputFromUser()
        {
            
            string sizeOfClockStr = System.Console.ReadLine();
            uint sizeOfClock;
            while (!uint.TryParse(sizeOfClockStr, out sizeOfClock))
            {
                System.Console.WriteLine("Invalid number , Please enter the number of lines for the sand machine:");
                sizeOfClockStr = System.Console.ReadLine();

            }

            return sizeOfClock;

        }

       
        private static void sandClockAdvanced(uint i_SizeOfClock)
        {
            if(i_SizeOfClock % 2 == 0)
            {
                i_SizeOfClock++;
            }
            B20_Ex01_2.Program.SandClock(i_SizeOfClock);
        }
    }
}
