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
            string bas = new String('*', init);

            string [] str = new string [init];
            int ds = 1;

            for (int i = 0; i < init; i++)
            {
                if (i < init / 2)
                {
                    if (i == 0)
                        str[i] = new String('*', init / 2) + new String('D', ds) + new String('*', init / 2);
                    else
                        str[i] = new String('*', init / 2 - i) + new String('D', ds) + new String('*', init / 2 - i);
                }
                else if (i == init/2)
                    str[i] = new String('D',init);

                else if (i > init/2)
                {
                    str[i] = str[init - i - 1];
                }
                 ds += 2;
            }

            foreach (string s in str)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        public static string ReplaceAt(string str, int init, int length, string replace)
        {
            return str.Remove(init, Math.Min(length, str.Length - init)).Insert(init, replace);
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
    }
}
