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
            String[] line = Console.ReadLine().Split(' ');
            int Simon = int.Parse(line[0]);
            int AntiSimon = int.Parse(line[1]);
            int heap = int.Parse(line[2]);

            for (int i = 0; ; i++)
            {
                if (i%2 == 0)
                {
                    heap -= GCD(Simon, heap);
                    if (heap < 0)
                    {
                        Console.WriteLine("1");
                        break;
                    }
                }
                else
                {
                    heap -= GCD(AntiSimon, heap);
                    if (heap < 0)
                    {
                        Console.WriteLine("0");
                        break;
                    }
                }
            }

                Console.ReadLine();
        }

        public static int GCD (int A, int B)
        {
            return B == 0 ? A : GCD(B , A % B);
        }
    }
}
