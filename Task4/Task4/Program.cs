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
            Console.WriteLine("Введите число k:");
            int k = int.Parse(Console.ReadLine());
            int[] sarray = CreateSetOfNumbers(k);

            long n = 1;
            foreach (var variable in sarray)
            {
                n = n * variable;
            }
            long s = 0;
            for (long i = 7; i < n; i = i + 10)
            {
                if (IsKANumberOfRaff(i,sarray) == true)
                {
                    s += i;
                }
            }
            Console.WriteLine((s%1000000007));

            Console.ReadKey();
        }

        static bool IsKANumberOfRaff(long k, int[] s)
        {
            int m = 0;
            foreach(var variable in s)
            {
                if (k % variable == 0)
                {
                    m += 1;
                }
            }
            if (m > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static int[] CreateSetOfNumbers(int k)
        {
            int m = k + 2;
            int[] setOfNumbers = new int[m];
            setOfNumbers[0] = 2;
            setOfNumbers[1] = 5;
            while (m > 2)
            {
                m = m - 1;
                
                setOfNumbers[m] = int.Parse(Console.ReadLine());
            }
            return setOfNumbers;
        }
    }
}
