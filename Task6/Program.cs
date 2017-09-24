using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        private static double a1, a2, a3;
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести а1, а2, а3, N, E. Построить последовательность чисел ак = ак–1 + 2 * ак-2 * ак–3. " +
                              "Найти первые ее N элементов, такие что | ак – ак–1 | > E. Напечатать последовательность, выделить " +
                              "искомые элементы и их номера.");
            var defaultColor = Console.ForegroundColor;
            while (true)
            {
                a1 = Input.readInt("Введите a1");
                a2 = Input.readInt("Введите a2");
                a3 = Input.readInt("Введите a3");
                int N = Input.readInt("Введите N");
                int E = Input.readInt("Введите E");

                int currentN = 0;

                if (Math.Abs(a2 - a1) > E && currentN < N)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} и {1} - {2} и {3}", a1, a2, 1, 2);
                    Console.ForegroundColor = defaultColor;
                    currentN++;
                }
                else
                {
                    Console.WriteLine(a1);
                    Console.WriteLine(a2);
                }

                if (Math.Abs(a3 - a2) > E && currentN < N)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} и {1} - {2} и {3}", a2, a3, 2, 3);
                    Console.ForegroundColor = defaultColor;
                    currentN++;
                }
                else
                {
                    Console.WriteLine(a3);
                }

                int i = 4;
                bool needAnswer = true;
                while (currentN < N)
                {
                    if (needAnswer && i > 30)
                    {
                        Console.Write("Алгоритм расчета рекурсивный, экспоненциальный и продолжение работы алгоритма может занять большое количество времени. Продолжить? [y/n]: ");
                        var answer = Console.ReadLine();
                        if (answer != "y")
                            break;
                        needAnswer = false;
                    }
                    double a_n = Seq(i);
                    double a_n_1 = Seq(i - 1);
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

        static double Seq(int n)
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
