using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems5
{
    class QuotientRemainder
    {
        static void Main(string[] args)
        {
            int Dividend = 20, Divisor = 5;
            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;
            Console.WriteLine("Dividend:{0} Divisor:{1}", Dividend, Divisor);
            Console.WriteLine("quotient=" + Quotient);
            Console.WriteLine("Remainder=" + Remainder);
            Console.ReadLine();
        }
    }
}
