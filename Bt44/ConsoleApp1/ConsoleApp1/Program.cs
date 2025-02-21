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

        private static int result(int n_231)
        {
            int S_231 = 0;
            while (n_231 > 0)
            {
                S_231 += n_231 % 10;
                n_231 /= 10;
            }
            return S_231;
        }
    }
}
