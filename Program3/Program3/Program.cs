using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ниже будет представлено наименьшее число, не соответствующее второй гипотезе Гольдбаха (подождите немного)");
            for (int number = 1; ; number += 2) //сразу рассматриваем только нечетные
            {
                if (IsNumberComposite(number))
                {
                    int count = 0;
                    for (int i = 0; i < (number - 2); i++)
                    {
                        if (IsNumberSimple(i))
                        {
                            for (int x = 1; x <= (number - 1); x++)
                            {
                                if (i + 2 * (x * x) == number)
                                {
                                    count++;
                                }

                            }
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine($"    Это число {number}.");
                        break;
                    }

                }
                else 
                { 
                    continue; 
                }
            }

            Console.ReadKey();
        }

        static bool IsNumberSimple(int number)
        {
            bool flag = true;
            if (((number % 2 == 0) && (number != 2)) || ((number % 3 == 0) && (number != 3)) || ((number % 5 == 0) && (number != 5)) || ((number % 7 == 0) && (number != 7)))
            {
                flag = false;
            }
            else
            {
                for (int i = 2; i <= (number / 2); i++)
                {
                    if (number % (i + 1) == 0)
                    {
                        flag = false;
                    }
                }
            }

            return flag;
        }

        static bool IsNumberComposite(int number)
        {
            bool flag = false;
            int count = 0;
            for (int i = 2; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                flag = true;
            }

            return flag;
        }
    }
}
