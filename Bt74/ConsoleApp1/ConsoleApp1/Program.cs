namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(2, 4));
        }

        private static double result(int x, int n)
        {
            double S = 1;
            int i = 0;
            while (i <= n)
            {
                S += (Math.Pow(-1, i + 1) * Math.Pow(x, (2 * i + 1)) / Giaithua(2 * i + 1));
                i++;
            }
            return S;
        }
        private static long Giaithua(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * Giaithua(n - 1);
        }
    }
}
