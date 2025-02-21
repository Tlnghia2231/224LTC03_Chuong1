namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so a : ");
            int a_231 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b : ");
            int b_231 = int.Parse(Console.ReadLine());
            Console.WriteLine("BCNN cua 2 so la : " + BCNN(a_231, b_231));
        }

        private static int UCLN(int a_231, int b_231)
        {
            while (b_231 != 0)
            {
                int temp = b_231;
                b_231 = a_231 % b_231;
                a_231 = temp;
            }
            return Math.Abs(a_231);
        }

        static int BCNN(int a_231, int b_231)
        {
            return Math.Abs(a_231 * b_231) / UCLN(a_231, b_231);
        }
    }
}
