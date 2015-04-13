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
            int numbrooms = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0;i < numbrooms; i++)
            {
                String[] room = Console.ReadLine().Split(' ');
                int occup = int.Parse(room[0]);
                int capac = int.Parse(room[1]);

                if (capac - occup >= 2)
                    count++;
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static int GCD (int A, int B)
        {
            return B == 0 ? A : GCD(B , A % B);
        }
    }
}
