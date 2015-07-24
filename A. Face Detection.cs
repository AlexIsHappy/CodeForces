using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    public struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int X,int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public double Distance(int x1, int y1)
        {
            return Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
        }
    }


    class Program
    {
       
        static void Main(string[] args)
        {
            int[] lst = new int[] { 8, 7, 5, 3 };
            Console.WriteLine(8 / 5);
            Console.WriteLine(8 % 5);

            Console.WriteLine(fromNb2Str(187, lst));
            Console.ReadLine();
        }

        public static String fromNb2Str(int n, int[] sys)
        {
            int mult = 1;
            var sb = new StringBuilder();
            sb.Append("--");

            for (int i = 0 ; i < sys.Count(); i++)
            {
                sb.Append(n % sys[i]);
                sb.Append("--");
                mult *= sys[i];
                for(int j = i + 1; j < sys.Count(); j++)
                {
                    if (GCD(sys[i], sys[j]) != 1)
                        return "Not applicable";
                }
            }

            if (mult < n)
                return "Not applicable";

            return sb.ToString().Substring(1,sb.Length - 2);
        }

        public static int GCD (int n1, int n2)
        {
            return n2 == 0 ? n1 : GCD(n2, n1 % n2);
        }
    }
}
