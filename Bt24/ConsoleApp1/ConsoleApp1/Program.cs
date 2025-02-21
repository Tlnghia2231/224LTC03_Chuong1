namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n : ");
            int n_231 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ung so le cua " + n_231 + " : ");
            printNumber(n_231);
        }

        private static void printNumber(int n_231)
        {
            int i_231 = 1;
            while (i_231 <= n_231)
            {
                if ((n_231 % i_231 == 0) && ((i_231 & 1) == 1))
                {
                    Console.Write(i_231 + "\t");
                }
                i_231++;
            }
        }
    }
}
