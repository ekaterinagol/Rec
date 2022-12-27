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
            int k = RightK();
            int[] sarray = CreateSetOfNumbers(k);

            long n = 1;
            foreach (var variable in sarray)
            {
                n = n * variable;
            }
            long sumOfK = 0;
            for (long i = 7; i < n; i = i + 10)
            {
                if (IsKANumberOfRaff(i,sarray) == true)
                {
                    sumOfK += i;
                }
            }
            long remaind = sumOfK % 1000000007;
            Console.WriteLine("Остаток от деления на 1000000007 суммы всех k-чисел Раффа, меньших Nk и оканчивающихся на 7 = " + remaind);

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
            Console.WriteLine($"Введите числа из множества (их должно быть {k} и они должны оканчиваться на 7)");
            while (m > 2)
            {
                m = m - 1;
                setOfNumbers[m] = int.Parse(Console.ReadLine());
            }
            return setOfNumbers;
        }

        static int RightK()
        {
            Console.WriteLine("Введите число k (от 3 до 9):");
            int k = int.Parse(Console.ReadLine());
            while ((k < 3) | (k  >9)) {
                Console.WriteLine("Пожалуйста, введите число от 3 до 9 (включительно):");
                k = int.Parse(Console.ReadLine());
            }
            return k;
        }
    }
}
