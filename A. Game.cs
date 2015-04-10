using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            var init =Console.ReadLine().Split(' ');
            int lenght = int.Parse(init[1]);
            int width = int.Parse(init[0]);
            var sb = new StringBuilder();

            for (int i = 1; i <= width; i++)
            {
                if (i % 2 != 0)
                    sb.AppendLine(new CompleteLine(lenght).Add());
                else
                {
                    if (i % 4 == 0)
                        sb.AppendLine(new Tail(lenght).Add());
                    else
                        sb.AppendLine(new Head(lenght).Add());
                }
            }

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }

    public struct CompleteLine
    {
        private char[] L;
        private string Line;
        public CompleteLine(int length)
        {
            L = new char[length];
            for(int i = 0; i < length; i++)
            {
                L[i] = '#';
            }
            this.Line = string.Concat(L);
        }

        public string Add()
        {
            return this.Line;
        }
    }

    public struct Head
    {
        private char[] L;
        public string Line;
        public Head(int length)
        {
            L = new char[length];
            for (int i = 0; i < length - 1; i++)
            {
                L[i] = '.';
            }
                L[length - 1] = '#';
                this.Line = string.Concat(L);
        }

        public string Add()
        {
            return Line;
        }
    }

    public struct Tail
    {
        private char[] L;
        public string Line;
        public Tail(int length)
        {
            L = new char[length];
            for (int i = 1; i < length; i++)
            {
                L[i] = '.';
            }
                L[0] = '#';
                this.Line = string.Concat(L);
        }

        public string Add()
        {
            return Line;
        }
    }
}
