using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Input
    {
        public static int readInt(string msg)
        {
            return readInt(msg, x => true, "");
        }

        public static int readInt(string msg, Func<int, bool> filter, string errFilter)
        {
            int n = 0;
            bool ok = true;

            do
            {
                try
                {
                    Console.Write("{0}: ", msg);
                    n = Int32.Parse(Console.ReadLine());
                    if (!filter(n))
                    {
                        Console.WriteLine(errFilter);
                        ok = false;
                    }
                    else
                        ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите число");
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы ввели слишком большое число");
                    ok = false;
                }
            } while (!ok);
            return n;
        }
    }
}
