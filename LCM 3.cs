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
            int[] lst = new int[] { 12, 15 };
            //Assert.AreEqual("(2 12)(3 27)(5 15)", SumOfDivided.sumOfDivided(lst));

            Console.WriteLine(sumOfDivided(lst));
            Console.ReadLine();
        }

        public static string sumOfDivided(int[] lst)
        {
            Dictionary<int, int> factors = new Dictionary<int, int>();

            for (int i = 0; i < lst.Length; i++)
            {
                int value = lst[i];
                for (int j = 2; j <= lst[i]; j++)
                {
                    int count = 0;
                    while (lst[i] % j == 0)
                    {
                        lst[i] /= j;
                        count++;
                    }

                    if (count >= 1)
                    {
                        if (factors.ContainsKey(j))
                            factors[j] += value;
                        else
                            factors.Add(j, value);
                    }

                }
            }

            var keys = factors.Keys.ToList();
            keys.Sort();

            var sb = new StringBuilder();

            foreach(int key in keys)
            {
                sb.Append(string.Format("({0} {1})", key, factors[key]));
            }

            return (sb.ToString());
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
