using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicproblems5
{
    class Harmonic
    {
        public static double sum = 0.0;

        public static void HarmonicNumb()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (double d = 1; d <= num; d++)
            {
                sum = sum + 1 / d;
            }
            Console.WriteLine("the Nth number series is:", +sum);
        }
        static void Main(string[] args)
        {
            Harmonic.HarmonicNumb();
            Console.ReadLine();
        }
    }
}
