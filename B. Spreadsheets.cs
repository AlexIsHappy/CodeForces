using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int am = int.Parse(Console.ReadLine());
            bool[] row = new bool[am];

            var sb = new StringBuilder();

            for (int i = 0; i < am; i++)
            {
                for (int j = 0 ; j < am; j++)
                {
                    if (i == 0)
                    {
                        if (j % 2 == 0)
                        {
                            row[j] = true;
                            sb.Append('C');
                        }
                        else
                        {
                            row[j] = false;
                            sb.Append('.');
                        }
                    }
                    else
                    {
                        if (row[j] == true)
                        {
                            sb.Append('.');
                            row[j] = false;
                        }
                        else
                        {
                            sb.Append('C');
                            row[j] = true;
                        }
                    }
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
                Console.ReadLine();
        }
    } 
}
