namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2x + 6  = 0");
            result(2, 6);
        }

        private static void result(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0) Console.WriteLine("Vo so nghiem");
                else Console.WriteLine("Vo nghiem");
            }
            else Console.WriteLine(-b * 1.0 / a);
        }
    }
}
