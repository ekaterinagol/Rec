using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thingy9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////for (int i = 10; i < 1000000000; i++)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine(MakeNumberToThePowerOf(3,3));
            
            Console.ReadKey();
        }

        static int MakeNumberToThePowerOf(int number, int degree)
        {
            int num = number;
            for (int i = 1; i < degree; i++)
            {
                num = num * number;
            }
            return num;
        }
    }
}
