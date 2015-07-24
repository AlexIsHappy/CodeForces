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

            var init = ReadIntList();
            var str = ReadToken();

            int s1 = str.Count(x => x == '1') * init[0];
            int s2 = str.Count(x => x == '2') * init[1];
            int s3 = str.Count(x => x == '3') * init[2];
            int s4 = str.Count(x => x == '4') * init[3];

            Write(s1 + s2 + s3 + s4);

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
