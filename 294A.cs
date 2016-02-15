﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            var wires = int.Parse(Console.ReadLine());
            var birds = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var shots = int.Parse(Console.ReadLine());

            for (int i = 0; i < shots; i++)
            {
                var shot = Console.ReadLine().Split(' ');
                int wire = int.Parse(shot[0]) - 1;
                int bird = int.Parse(shot[1]);
                if (birds.Count == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                if (wire != 0 && wire != wires - 1)
                {
                    birds[wire - 1] += bird - 1;
                    birds[wire + 1] += (birds[wire] - bird);
                    birds[wire] = 0;
                }
                else
                {
                    if (wire == 0)
                    {
                        birds[wire + 1] += (birds[wire] - bird);
                        birds[wire] = 0;
                    }
                    else if (wire == wires - 1)
                    {
                        birds[wire - 1] += bird - 1;
                        birds[wire] = 0;
                    }
                }
            }

            for (int i = 0; i < wires; i++)
            {
                Console.WriteLine(birds[i]);
            }
            Console.ReadLine();
        }
    }
}