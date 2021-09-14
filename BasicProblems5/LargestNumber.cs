using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems5
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 10;
            if (a > b && a > c)
            {
                Console.WriteLine("a is Largest number", +a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("b is Largest number", +b);
            }
            else
            {
                Console.WriteLine("c is  larger", +c);
            }
            Console.ReadLine();
        }
    }
}