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
            string name = Console.ReadLine();
            Char symbol = name[0];
            name = name.Remove(0, 1);
            if (Char.IsLower(symbol))
            {
                symbol = Char.ToUpper(symbol);

                Console.WriteLine(symbol + name);
            }
            else
            {
                Console.WriteLine(name);
            }
            
            Console.ReadLine();

        }
    }
}
