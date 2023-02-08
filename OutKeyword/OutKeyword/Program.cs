using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            SumOfTwoNumber(2, 2, out result);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static void SumOfTwoNumber(int no1, int no2, out int result)
        {
            result = no1 + no2;
        }
    }
}
