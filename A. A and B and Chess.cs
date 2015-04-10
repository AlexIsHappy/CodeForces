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

            var init = ReadIntArray();

            int count = 1;
            count += init[0] - 1 + init[1] - 1;
            int max = Math.Max(init[0], init[1]);
            int min = Math.Min(init[0], init[1]);

            int curMax = 1;
            int curMin = 1;

            Console.WriteLine(count);


            for (int i = 0; i < count ;i++)
            {
                if (i == 0)
                    Console.WriteLine('1' + " " + '1');
                if (curMin <= min)
                {
                   
                }
                else
                {

                }
            }
            
            Console.ReadLine();
        }

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

        public static string[] ReadLines(int count)
        {
            string[] lines = new string[count];
            for (int i = 0; i < count; i++)
            {
                lines[i] = reader.ReadLine().Trim();
            }
            return lines;
        }
    }
}
