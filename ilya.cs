using System;

namespace For_repos
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int k2 = 0;
            int k17 = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i += 1)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x % 34 != 0)
                {
                    if (x % 2 == 0)
                    {
                        k2 = k2 + 1;
                    }
                    else if (x % 17 == 0)
                    {
                        k17 = k17 + 1;
                    }
                    else
                    {
                        k = k + 1;
                    }
                }
            }
            Console.WriteLine((k2 * (k2 - 1) + k17 * (k17 - 1) + k * (k - 1)) / 2 + k2 * k + k17 * k);
        }
    }
}
