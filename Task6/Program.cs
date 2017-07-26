using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        private static int a1, a2, a3;
        static void Main(string[] args)
        {
            var defaultColor = Console.ForegroundColor;
            while (true)
            {
                a1 = Input.readInt("Введите a1");
                a2 = Input.readInt("Введите a2");
                a3 = Input.readInt("Введите a3");
                int N = Input.readInt("Введите N");
                int E = Input.readInt("Введите E");

                int currentN = 0;
                int i = 5;

                for (int j = 1; j <= 4; j++)
                    Console.WriteLine(Seq(j));

                while (currentN < N)
                {
                    int a_n = Seq(i);
                    int a_n_1 = Seq(i - 1);
                    if (Math.Abs(a_n - a_n_1) > E)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0} и {1} - {2} и {3}", a_n_1, a_n, i - 1, i);
                        Console.ForegroundColor = defaultColor;
                        currentN++;
                    }
                    else
                    {
                        Console.WriteLine(a_n);
                    }
                    i++;
                }
            }
        }

        static int Seq(int n)
        {
            switch (n)
            {
                case 1: return a1;
                case 2: return a2;
                case 3: return a3;
            }
            return Seq(n - 1) + 2 * Seq(n - 2) * Seq(n - 3);
        }
    }
}
