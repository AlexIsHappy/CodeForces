using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;
namespace ConsoleApplication25
{
    class Solution
    {
        static void Main(string[] args)
        {
            var init = int.Parse(Console.ReadLine());

            var num = Console.ReadLine();

            var fh = num.Substring(0,init);
            var sh = num.Substring(init, init);

            var fhint = new int[init];
            var shint = new int[init];

            for (int i = 0; i < init;i++)
            {
                var fc = fh[i];
                var sc = sh[i];

                fhint[i] = fc - '0';
                shint[i] = sh[i] - '0';

            }

            Array.Sort(fhint);
            Array.Sort(shint);


            bool order = fhint[0] > shint[0] ? true : false;

            for (int i = 0; i < init; i++)
            {
                Console.WriteLine(fhint[i] + " " + shint[i]);
               if (order == true)
               {
                   if (fhint[i] <= shint[i])
                   {
                       Console.WriteLine("NO");
                   }
               }
               else
               {
                   if (fhint[i] >= shint[i])
                   {
                       Console.WriteLine("NO");
                   }
               }
            }

            Console.WriteLine("YES");
                Console.ReadLine();

        }
    }
}
