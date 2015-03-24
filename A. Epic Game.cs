using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            String number = Console.ReadLine();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '4' && number[i] != '7')
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
             Console.ReadLine();
        }

        public static int GCD (int A, int B)
        {
            return B == 0 ? A : GCD(B , A % B);
        }
    }
}
