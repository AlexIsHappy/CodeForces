using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var nLights = numbers[0];
            var length = numbers[1];

            var lights = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            lights.Sort();

            double maxDif = 0;

            for (int i = 1; i < nLights;i++)
            {
                if ((lights[i] - lights[i - 1]) / 2 > maxDif)
                {
                    maxDif = (lights[i] - lights[i - 1]) / 2;
                }
            }

            Console.WriteLine(Math.Max(Math.Max(lights[0] - 0,length - lights[lights.Count - 1]),maxDif));

                Console.ReadLine();

        }
    }
}
