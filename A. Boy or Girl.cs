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
            String team = Console.ReadLine();
            int count = 0;
            bool danger = false;

            for (int i = 0; i < team.Length; i++ )
            {
                if (count == 7)
                {
                    danger = true;
                } else
                {
                    if (team[i] == '1')
                        count++;
                    else count = 0;
                }
            }

            if (danger == true)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

                Console.ReadLine();
        }
    }
}
