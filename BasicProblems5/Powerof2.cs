using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems5
{
    class Powerof2
    {
        public static void Powercalci()
        {
            Console.WriteLine("Display the Power of two");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int count = 1; count <= num; count++)
            {
                double pow = Math.Pow(2, count);
                Console.WriteLine("Power of 2 of {0} is {1}:", +count, +pow);

            }
        }
        static void Main(string[] args)
        {
            Powerof2.Powercalci();
            Console.ReadLine();
        }
    }
}