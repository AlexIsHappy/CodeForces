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
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length;i++)
            {
                if (int.Parse(line[i].ToString())%2 == 0)
                {
                    char[] array = line.ToCharArray();
                    char l = array[i];
                    array[i] = array[array.Length - 1];
                    array[array.Length - 1] = l;
                    Console.WriteLine(new String(array));
                    return;
                }

            }

            Console.WriteLine(-1);
                Console.ReadLine();
        }


    }
}
