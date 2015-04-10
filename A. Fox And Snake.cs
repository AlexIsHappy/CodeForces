using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool legs = false;
            var init = Console.ReadLine().Split(' ').ToList();
            var inDist = init.Distinct().ToList();

            for (int i = 0; i < init.Distinct().Count(); i++)
            {
                if (init.Where(x => x == inDist[i]).Count() == 4)
                {
                    init.RemoveAll(x => x == inDist[i]);
                    legs = true;
                    break;
                }
            }

            if (legs == false)
            {
                Console.WriteLine("Alien");
                return;
            }

                Console.WriteLine(init[0] == init[1] ? "Elephant" : "Bear");
                Console.ReadLine();
            }

        }
    }
