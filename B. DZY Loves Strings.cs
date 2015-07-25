using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;
namespace ConsoleApplication25
{
    class Solution
    {
        static void Main(string[] args)
        {
            var start = Console.ReadLine();
            var x1 = char.ToUpper(start[0]) - 64;
            var y1 = start[1] - '0';

            var end = Console.ReadLine();
            var x2 = char.ToUpper(end[0]) - 64;
            var y2 = end[1] - '0';

            var count = 0;

            var moves = new List<string>();

            while (x1 != x2 || y1 != y2)
            {
                var sb = new StringBuilder();
                if (x1 < x2)
                {
                    sb.Append("R");

                }
                else if (x2 < x1)
                {
                    sb.Append("L");
                }

                if (y1 > y2)
                {
                    sb.Append("D");
                }
                else if (y1 < y2){
                    sb.Append("U");
                }

                switch(sb.ToString())
                {
                    case "R":
                        x1++;
                        break;
                    case "L":
                        x1--;
                        break;
                    case "U":
                        y1++;
                        break;
                    case "D":
                        y1--;
                        break;
                    case "RU":
                        y1++;
                        x1++;
                        break;
                    case "RD":
                        y1--;
                        x1++;
                        break;
                    case "LU":
                        x1--;
                        y1++;
                        break;
                    case "LD":
                        x1--;
                        y1++;
                        break;
                }
                count++;
                moves.Add(sb.ToString());
            }

            Console.WriteLine(count);
            foreach(string s in moves)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
