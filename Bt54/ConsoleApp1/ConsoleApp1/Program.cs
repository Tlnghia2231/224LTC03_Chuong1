namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            result(4441);
        }

        private static void result(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int min = int.MaxValue;
            while (n > 0)
            {
                int tmp = n % 10;
                if (!dict.ContainsKey(tmp)) { dict[tmp] = 0; }
                dict[tmp]++;
                if (min > tmp) min = tmp;
                n /= 10;
            }
            Console.WriteLine("So be nhat la : " + min);
            Console.WriteLine("Xuat hien : " + dict[min] + " lan");

        }
    }
}
