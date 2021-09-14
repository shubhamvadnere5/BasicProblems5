using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems5
{
    class Leap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if ((Year % 4 == 0) && (Year % 100 != 0) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a LeapYear.", Year);
            }
            else
            {
                Console.WriteLine("{0} is not a LeapYear.", Year);

            }

            Console.ReadLine();
        }
    }
}

