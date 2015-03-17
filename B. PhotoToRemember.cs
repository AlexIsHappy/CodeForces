﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] widths = new int [number];
            int[] heights = new int [number];
            bool checkHeight = false;
            StringBuilder output = new StringBuilder();

            int wSum = 0;
            int[] results = new int[number];

            // width   - first   - size
            // height  - second  - maximum

            for (int i = 0; i < number; i++)
            {
                int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
                widths[i] = size[0];
                heights[i] = size[1];
                wSum += size[0];
            }

            int max = 0;
            int secondMax = 0;

            // Calculate Max and Second Max Element
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > max)
                    max = heights[i];
            }

            if (heights.Where(h => h == max).Count() < 2)
            {
                checkHeight = true;
                secondMax = CalculateSecondMax(heights, max);
            } 
            

           for (int i = 0; i < number; i++)
             {
               int Height = 0;

               if (heights[i] == max && checkHeight == true)
                   Height = secondMax;
               else
                   Height = max;
 
                    int Width = wSum - widths[i];
                    output.Append(Height * Width + " ");
             }

            Console.WriteLine(output);
            Console.ReadLine();
        }

        public static int CalculateSecondMax (int [] heights, int max)
        {
            int  secondMax = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > secondMax && heights[i] != max)
                {
                    secondMax = heights[i];
                }
            }
            return secondMax;
        }

    }
}