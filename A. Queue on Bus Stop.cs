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
            var init = Console.ReadLine();
            var sb = new StringBuilder();

            if (init.Skip(0).All(x => x == '1'))
            {
                int ind = init.LastIndexOf('1');
               init =  init.Remove(ind, 1);
            }
            else
            {
                int ind = init.IndexOf('0');
                init =  init.Remove(ind, 1);
            }

            Console.WriteLine(init);
            Console.ReadLine();
        }

    }
}
