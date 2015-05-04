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

            Dictionary<char, int> White = new Dictionary<char, int>();
            White.Add('Q', 9);
            White.Add('R', 5);
            White.Add('B', 3);
            White.Add('N', 3);
            White.Add('P', 1);
            White.Add('K', 0);

            White.Add('q', 9);
            White.Add('r', 5);
            White.Add('b', 3);
            White.Add('n', 3);
            White.Add('p', 1);
            White.Add('k', 0);

            int w = 0;
            int b = 0;

            for (int i = 0; i < 2 ;i++)
            {
                var line = Console.ReadLine();
                foreach(char c in line)
                {
                   if (c != '.')
                   {
                       if (char.IsLower(c))
                       {
                           b += White.First(s => s.Key == c).Value;
                       }
                       else if (char.IsUpper(c))
                       {
                           w += White.First(s => s.Key == c).Value;
                       }
                   }
                       
                }
            }

            Console.WriteLine(b + "--" + w);

            if (b == w)
                Console.WriteLine("Draw");
            else
               Console.WriteLine(b > w ? "Black" : "White");
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
    }
}
