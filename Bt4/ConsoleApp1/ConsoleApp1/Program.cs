namespace ConsoleApp1
{
    internal class Program
    {
        private static int i = 1;
        static void Main(string[] args)
        {
            Console.WriteLine(result(i, 4));
        }

        private static double result(int i, int n)
        {
            if (i <= n) return (1.0 / (2 * i)) + result(++i, n);
            else return 0;
        }
    }
}
