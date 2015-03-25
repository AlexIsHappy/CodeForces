using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            String code = Console.ReadLine();

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == 'H' || code[i] == 'Q' || code[i] == '9')
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            Console.WriteLine("NO");
            Console.ReadLine();

        }
    }
}
