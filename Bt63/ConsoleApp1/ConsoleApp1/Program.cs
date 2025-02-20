namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BCNN cua 12 va 14 la : " + BCNN(12, 14));
        }

        private static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        static int BCNN(int a, int b)
        {
            return Math.Abs(a * b) / UCLN(a, b);
        }
    }
}
