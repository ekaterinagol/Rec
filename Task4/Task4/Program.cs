using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sarray = new int[] {2, 5, 7, 17, 37 };
            long n = 1;
            foreach (var variable in sarray)
            {
                n = n * variable;
            }
            long s = 0;
            for (int i = 7; i < n; i = i + 10)
            {
                if (IsKANumberOfRaff(i) == true)
                {
                    s += i;
                }
            }
            Console.WriteLine((s%1000000007));

            Console.ReadKey();
        }

        static bool IsKANumberOfRaff(int k)
        {
            if ((k %2 == 0) | (k % 5 == 0) | (k % 7 == 0) | (k % 17 == 0) | (k % 37 == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
