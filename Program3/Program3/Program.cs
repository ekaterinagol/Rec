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
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsNumberSimple(n));

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
    }
}
