using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var str = Console.ReadLine().ToLower();
            var count = 0;

            List<char> keys = new List<char>();

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1] && keys.Contains(str[i]) == false)
                {
                    count++;
                    if (str[i] != str[i - 1])
                        keys.Add(str[i - 1]);
                }
                else
                {
                        keys.Remove(str[i]);
                }

                i++;
            }

            Console.WriteLine(count);
                Console.ReadLine();

        }
    }
}
