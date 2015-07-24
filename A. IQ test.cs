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

            var init = ReadInt();

            var nums = ReadIntList();

            var maxN = nums.Count(x => x == nums.Max());
            var minN = nums.Count(x => x == nums.Min());

            Console.Write(nums.Max() - nums.Min() + " ");
            Write(nums.Distinct().Count() <= 1 ? init * (init - 1) / 2 : maxN * minN);
            Console.ReadLine();
        }


        // Utility finctions. Reader
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


        //Utility functions.Writer
        public static void Write (params object [] array)
        {
            WriteArray(array);
        }

        public static void WriteArray<T> (IEnumerable<T> array)
        {
            writer.WriteLine(string.Join(" ", array));
        }
    }
}
