namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(2, 3));
        }

        private static double result(int x,int n)
        {
            int i = 0;
            double S = 0;
            while (i < n)
            {
                S += Math.Pow(x, 2 * i + 1);
                i++;
            }
            return S;
        }
    }
}
//2 + 8 + 32