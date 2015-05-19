using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());

            var perc = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            double totalPerc = 0;

            for (int i = 0; i < perc.Count; i++)
            {
                totalPerc += perc[i] / 100;
                Console.WriteLine(totalPerc);
            }

            Console.WriteLine((totalPerc / amount) * 100);
            Console.ReadLine();
        }
    } 
}
