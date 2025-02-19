namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(1234));
        }

        private static int result(int n)
        {
            int S = 0;
            while (n > 0)
            {
                S += n % 10;
                n /= 10;
            }
            return S;
        }
    }
}
