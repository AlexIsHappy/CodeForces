using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;


            for (int i = 1; sum <= c;i++ )
            {
                sum += sum + i;
                count++;
            }

          Console.WriteLine(count);
          Console.ReadLine();
        }
    }
}
