using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            var gr = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            for (int i = 0 ; i< gr; i++)
            {
                var str = Console.ReadLine();

                if (str.StartsWith("miao.") && str.EndsWith("lala.") == false)
                    sb.AppendLine("Rainbow's");
                else if (str.EndsWith("lala.") && str.StartsWith("miao.") == false)
                    sb.AppendLine("Freda's");
                else
                    sb.AppendLine("OMG>.< I don't know!");
            }

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }

    public class Pair
    {
        public int index { get; set; }
        public int count { get; set; }

        public Pair(int ind, int c)
        {
            this.index = ind;
            this.count = c;
        }
    }
}
