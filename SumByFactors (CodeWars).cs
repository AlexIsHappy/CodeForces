using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            reader = Console.In;
            writer = Console.Out;

            var coord = ReadIntList();
            var xy = coord.Distinct().ToArray();

            if (xy.Count() > 2)
            {
                Console.WriteLine(-1);
                return;
            }

            var sb = new StringBuilder();

            // First pair of numbers
            if (coord[0] == coord[1])
            {
                if (coord[2] == coord[3])
                {
                    if (coord[0] == xy[0])
                        sb.Append(string.Format("{0} {1} {2} {3} ", xy[1], xy[1], xy[0], xy[0]));
                    else
                        sb.Append(string.Format("{0} {1} {2} {3} ", xy[0], xy[0], xy[1], xy[1]));

                    Console.WriteLine(sb.ToString().Remove(sb.Length - 1));
                    return;
                }
            }


                for (int i = 0; i < coord.Count; i++)
                {
                    if (coord[i] == xy[0])
                        sb.Append(string.Format("{0} ", xy[1]));
                    else
                        sb.Append(string.Format("{0} ", xy[0]));
                }

            string output = sb.ToString();
            Console.WriteLine(output);
                Console.ReadLine();
        }

        public static string Reverse (String s)
        {
                char[] Array = s.ToCharArray();
                Array.Reverse();
                return new string(Array);
        }


        // Utility finctions
        private static Queue<string> currentLineTokens = new Queue<string>();
        protected static TextReader reader;
        protected static TextWriter writer;
        private static string[] ReadAndSplitLine()
        {
            return reader.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string ReadToken()
        {
            if (currentLineTokens.Count == 0)
                currentLineTokens = new Queue<string>(ReadAndSplitLine());
            return currentLineTokens.Dequeue();
        }

        public static int ReadInt()
        {
            return int.Parse(ReadToken());
        }

        public static int[] ReadIntArray()
        {
            return ReadAndSplitLine().Select(int.Parse).ToArray();
        }

        public static List<int> ReadIntList()
        {
            return ReadAndSplitLine().Select(int.Parse).ToList();
        }
    }
}
