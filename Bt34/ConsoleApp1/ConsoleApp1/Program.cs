namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n : ");
            int n_231 = int.Parse(Console.ReadLine());
            Console.WriteLine(result(n_231));
        }

        private static double result(int n_231)
        {
            if (n_231 > 0) return Math.Sqrt(n_231 + result(n_231 - 1));
            else return 1;
        }
    }
}
