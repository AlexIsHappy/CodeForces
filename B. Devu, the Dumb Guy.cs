using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = Console.ReadLine();
            var n2 = Console.ReadLine();

            var l = n1.Length;
            var dist = 0;

            for (int i = 0; i < l; i++)
            {
                if (n1[i] != n2[i])
                {
                    dist++;
                }
            }

            var sb = new StringBuilder();

            if (dist % 2 == 0)
            {
                var half = dist / 2;
                for (int i = 0; i < l;i++)
                {
                    if (n1[i] != n2[i])
                    {
                        sb.Append(dist <= half ? n2[i] : n1[i]);
                        dist--;
                    }
                    else
                    {
                        sb.Append(n1[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("impossible");
                return;
            }

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }

    }
}
