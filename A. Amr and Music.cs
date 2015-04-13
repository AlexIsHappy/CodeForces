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

            int n = ReadInt();
            int k = ReadInt();
            var days = ReadIntArray();

            var b = Enumerable.Range(1, n).ToArray();

            Array.Sort(days, b);

            int sum = 0;
            List<int> keys = new List<int>();

            for (int i = 0; i < n; i++)
            {
                sum += days[i];

                if (sum <= k)
                    keys.Add(b[i]);
                else
                    break;
            }

            Write(keys.Count);
            WriteArray(keys);
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
