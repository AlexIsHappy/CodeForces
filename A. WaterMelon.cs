using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            String[] values = Console.ReadLine().Split();
            int[] intValues = new int[values.Length];
            int count = 0;

            for (int i = 0; i < values.Length - 1; i++)
            {
                intValues[i] = int.Parse(values[i]);
            }

            for (int i = 0; i < intValues.Length - 1;i ++)
            {
                if (intValues[i] == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                if (intValues[i] >= intValues[k])
                    count += 1;
            } 

                Console.WriteLine(count);
                Console.ReadLine();
        }
    }
}
