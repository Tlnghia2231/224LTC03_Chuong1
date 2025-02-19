namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(5));
        }

        private static double result(int n)
        {
            if (n > 0) return Math.Sqrt(n + result(n - 1));
            else return 1;
        }
    }
}
