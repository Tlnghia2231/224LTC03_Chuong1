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
            int i = 1;
            while (i < 100)
            {
                if (!(i == 5 || i == 7 || i == 93) && ((i & 1) == 1))
                {
                    Console.Write(i + ", ");
                }
                i++;
            }
        }
    }
}
