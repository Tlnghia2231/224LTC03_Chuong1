namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cac so le nho hon 100 tru 5, 7, 93 la : ");
            printNumber();
        }

        private static void printNumber()
        {
            int i_231 = 1;
            while (i_231 < 100)
            {
                if (!(i_231 == 5 || i_231 == 7 || i_231 == 93) && ((i_231 & 1) == 1))
                {
                    Console.Write(i_231 + ", ");
                }
                i_231++;
            }
        }
    }
}
