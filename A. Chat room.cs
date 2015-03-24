using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] init = Console.ReadLine().Split(' ');

            int numCandles = int.Parse(init[0]);
            int thresh = int.Parse(init[1]);
            int count = numCandles;
            int restCandles = 0;

            while (numCandles >= thresh)
            {
                restCandles += numCandles % thresh;
                numCandles /= thresh;
                count += numCandles;
            }

            int finalRest = 0;

            while (restCandles >= thresh)
            {
                restCandles /= thresh;
                count += restCandles;
            }

            Console.WriteLine(count + restCandles);
            Console.ReadLine();
        }
    }
}
