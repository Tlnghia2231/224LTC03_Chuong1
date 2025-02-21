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

        private static double result(int x_231,int n_231)
        {
            int i_231 = 0;
            double S_231 = 0;
            while (i_231 < n_231)
            {
                S_231 += Math.Pow(x_231, 2 * i_231 + 1);
                i_231++;
            }
            return S_231;
        }
    }
}
//2 + 8 + 32