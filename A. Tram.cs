using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int amountLetters = 0;
            int count = 0;
            bool distinct = true;

            for (int i = 0; i < name.Length; i++)
            {
                distinct = true;
                for (int j = i; j < name.Length; j++)
                {
                    if (name[i] == name[j])
                        count++;
                    if (count == 2)
                    {
                        distinct = false;
                        break;
                    }
                }
                if (distinct == true)
                    amountLetters++;               
            }

            Console.WriteLine(amountLetters);
            Console.ReadLine();
        }
    }
}
