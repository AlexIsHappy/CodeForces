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
            var amount = int.Parse(Console.ReadLine());

            for (int n = 0; n < amount; n++)
            {
                var sb1 = new StringBuilder();
                var sb2 = new StringBuilder();
                int row = 0;
                int column = 0;
                var num = Console.ReadLine();
                bool[] nums = new bool[] { false, false };
                bool numbers = false;
                int curNum = 0;
                var colStr = new StringBuilder();

                //Check which type the string is 
                for (int i = 0; i < num.Length; i++)
                {
                    if (Char.IsDigit(num[i]))
                    {
                        numbers = true;
                        nums[curNum] = true;
                        if (curNum == 0)
                            sb1.Append(num[i]);
                        else
                            sb2.Append(num[i]);
                    }
                    else
                    {
                        if (numbers == false)
                            colStr.Append(num[i]);

                        if (nums[curNum] == true)
                            curNum++;
                    }
                }

                row = int.Parse(sb1.ToString());
                column = nums[1] == true ? int.Parse(sb2.ToString()) : 0;

                if (nums.All(x => x == true))
                {
                    Console.WriteLine(ConvertToColumn(column) + row.ToString());
                }
                else
                {
                    Console.WriteLine("R" + row.ToString() + "C" + ConvertFromColumn(colStr.ToString()));
                }
            }

            Console.ReadLine();
        }

        

        public static string ConvertToColumn(int num)
        {
            int number = num;
            int module = 0;
            String column = String.Empty;

            while (number > 0)
            {
                module = (number - 1) % 26;
                column = Convert.ToChar(module + 65).ToString() + column;
                number = (int)((number - module) / 26);
            }

            return column;
        }

        public static string ConvertFromColumn(string col)
        {
            int sum = 0;

            for (int i = 0; i < col.Length; i++)
            {
                sum *= 26;
                sum += (col[i] - 'A' + 1);
            }

            return sum.ToString();
        }
    } 
}
