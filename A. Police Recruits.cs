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

            var matrix = new int [init,init];
            int ans = 0;

            for (int i = 0; i < init; i++)
            {
                for (int j = 0; j < init; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                        matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                    ans = Math.Max(matrix[i,j],ans);
                }
            }

            Console.WriteLine(ans);
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
    }
}
