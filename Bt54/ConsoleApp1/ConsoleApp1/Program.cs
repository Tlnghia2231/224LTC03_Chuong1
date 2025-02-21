namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n : ");
            int n_231 = int.Parse(Console.ReadLine());
            result(n_231);
        }

        private static void result(int n_231)
        {
            Dictionary<int, int> dict_231 = new Dictionary<int, int>();
            int min_231 = int.MaxValue;
            while (n_231 > 0)
            {
                int tmp = n_231 % 10;
                if (!dict_231.ContainsKey(tmp)) { dict_231[tmp] = 0; }
                dict_231[tmp]++;
                if (min_231 > tmp) min_231 = tmp;
                n_231 /= 10;
            }
            Console.WriteLine("So be nhat la : " + min_231);
            Console.WriteLine("Xuat hien : " + dict_231[min_231] + " lan");

        }
    }
}
