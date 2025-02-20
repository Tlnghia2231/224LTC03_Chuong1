namespace ConsoleApp1
{
    internal class Program
    {
        private static int i_231 = 1;
        static void Main(string[] args)
        {
            Console.Write("Nhap so n : ");
            int n_231 = int.Parse(Console.ReadLine());
            Console.WriteLine(result(i_231, n_231));
        }

        private static double result(int i_231, int n_231)
        {
            if (i_231 <= n_231) return (1.0 / (2 * i_231)) + result(++i_231, n_231);
            else return 0;
        }
    }
}
