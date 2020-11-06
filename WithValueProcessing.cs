using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int k2 = 0;
            int k17 = 0;

            Console.WriteLine("Введите длину массива (длина - 1)");
            string n1 = Console.ReadLine();

            int n;
            //обработка на ввод числа, возвращается в х
            bool result = int.TryParse(n1, out n);
            if (result == true)
            {
                Console.Write("Вы ввели корректные данные!");
            }
            else
            {
                Console.Write("Вы ввели НЕкорректные данные!");
            }

            for (int i = 0; i <= n; i += 1)
            {
                Console.WriteLine(" Введите элементы массива");


                string x1 = Console.ReadLine();

                int x;
                //обработка на ввод числа, возвращается в х
                bool resultat = int.TryParse(x1, out x);
                if (resultat == true)
                {
                    Console.Write("Вы ввели корректные данные! ");
                }
                else
                {
                    Console.Write("Вы ввели НЕкорректные данные! ");
                }


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
