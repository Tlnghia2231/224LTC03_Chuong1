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
            result(a_231, b_231);
        }

        private static void result(int a_231, int b_231)
        {
            Console.WriteLine(a_231 + "x + " + b_231 + " = 0");
            if (a_231 == 0)
            {
                if (b_231 == 0) Console.WriteLine("=> Vo so nghiem");
                else Console.WriteLine("=> Vo nghiem");
            }
            else Console.WriteLine("=> x = " + (-b_231 * 1.0 / a_231));
        }
    }
}
