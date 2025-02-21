namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so x : ");
            int x_231 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so n : ");
            int n_231 = int.Parse(Console.ReadLine());
            Console.WriteLine(result(x_231, n_231));
        }

        private static double result(int x_231, int n_231)
        {
            double S_231 = 1;
            int i_231 = 0;
            while (i_231 <= n_231)
            {
                S_231 += (Math.Pow(-1, i_231 + 1) * Math.Pow(x_231, (2 * i_231 + 1)) / Giaithua(2 * i_231 + 1));
                i_231++;
            }
            return S_231;
        }
        private static long Giaithua(int n_231)
        {
            if (n_231 == 0 || n_231 == 1) return 1;
            return n_231 * Giaithua(n_231 - 1);
        }
    }
}
