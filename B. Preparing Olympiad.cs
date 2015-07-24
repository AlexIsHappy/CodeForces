using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> board = new List<string>();

            for (int i = 0; i < n; i++)
            {
                board.Add(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int c = 0;
                    if (i > 0 && board[i - 1][j] == 'o')
                        c++;
                    if (j > 0 && board[i][j - 1] == 'o')
                        c++;
                    if (i < n - 1 && board[i + 1][j] == 'o')
                        c++;
                    if (j < n - 1 && board[i][j + 1] == 'o')
                        c++;

                    if (c % 2 == 1)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                        

                }
            }
            Console.WriteLine("YES");
                Console.ReadLine();

        }

        static string IntToBinaryString(int bits, bool removeTrailingZero)
        {
            var sb = new StringBuilder(8);
            for (int i = 0; i < 8; i++)
            {
                if ((bits & 0x00000001) != 0)
                {
                    sb.Append("1");
                }
                else
                {
                    sb.Append("0");
                }
                bits = bits << 1;
            }
            string s = sb.ToString();
            if (removeTrailingZero)
            {
                return s.TrimStart('0');
            }
            else
            {
                return s;
            }
        }



    }
}
