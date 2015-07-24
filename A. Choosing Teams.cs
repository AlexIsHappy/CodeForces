using System;
using System.Collections;
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
            Console.WriteLine(Chameleon(new int[] { 0, 0, 17 }, 1));
            Console.ReadLine();
        }

        public static int Chameleon(int[] chameleons, int desiredColor)
        {
            int [] cham = new int[2];
            int n = 0;
            int res = chameleons[desiredColor];

            for (int i = 0 ; i < chameleons.Length; i++)
            {
                if (i != desiredColor)
                {
                    cham[n] = chameleons[i];
                    n++;
                }
            }

            List<int> remainders = new List<int>();
            remainders.Add(chameleons[0] % 3);
            remainders.Add(chameleons[1] % 3);
            remainders.Add(chameleons[2] % 3);

            if (remainders.Distinct().Count() == 3 || cham[0] == 0 || cham[1] == 0 || desiredColor > Math.Max(cham[1], cham[0])
                return -1;

            
            return Math.Max(cham[1], cham[0]);
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
