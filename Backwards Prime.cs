using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList r = iterPi(0.1);
            ArrayList c = new ArrayList { 10, 3.0418396189 };
            Console.WriteLine(r[0] + " " + r[1]);
            Console.ReadLine();
        }

        public static ArrayList iterPi(double epsilon)
        {
            double Pi = 0;
            double n = 0;

            while(Math.Abs(Pi - Math.PI) >= epsilon)
            {
                if (n % 2 == 0)
                    Pi += 4 * ( 1 / (2 * n + 1));
                else if (n % 2 != 0)
                    Pi +=  4* ((-1) / (2 * n + 1));

                n++;
                Console.WriteLine(Pi);
            }

            return new ArrayList{10,Math.Round(Pi,10)};
        }

     
    }
}
