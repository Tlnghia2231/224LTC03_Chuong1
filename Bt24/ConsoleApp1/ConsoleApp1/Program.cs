namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ung so le cua 555 : ");
            printNumber(555);
        }

        private static void printNumber(int n)
        {
            int i = 1;
            while (i <= n)
            {
                if ((n % i == 0) && ((i & 1) == 1))
                {
                    Console.Write(i + "\t");
                }
                i++;
            }
        }
    }
}
