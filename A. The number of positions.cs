using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };
            bool r = comp(a, b); // True
            Console.WriteLine(r);
            Console.ReadLine();
        }

        public static bool comp(int[] a, int [] b)
        {
            if ((a.Length == 0 && b.Length == 0))
                return true;
            if (a.Length == 0 || b.Length == 0 || a == null || b == null)
                return false;
            if (a.Length != b.Length)
                return false;
            int countT = 0;
            foreach (int i in b)
            {
                bool check = false;
                foreach(int j in a)
                {
                    if (Math.Sqrt(i) == j)
                    {
                        check = true;
                        countT++;
                        break;
                    }
                }

                if (check == false)
                    return false;
            }

            Console.WriteLine(b.Length + "  " + countT);
            return countT == b.Length ? true : false;
        }
    }
}
