using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
         
        {
            int num = int.Parse(Console.ReadLine());
            int sum = Sum(num);


            List<int> array = GenerateArray(num * num);

            List<List<int>> arrays = new List<List<int>>();


               for (int i = 0; i < num; i++)
                {
                    List<int> l = new List<int>();
                    while (l.Count < num) 
                    {
                        l.Add(array[0]);
                        l.Add(array[array.Count - 1]);
                        array.RemoveAt(0);
                        array.RemoveAt(array.Count - 1);
                    }
                    arrays.Add(l);
                }

            foreach(List<int> l in arrays)
            {
                foreach(int i in l)
                {
                    Console.Write(i + " ");
                } 
                Console.WriteLine();
            }

                Console.ReadLine();
        }

        public static int Sum(int n)
        {
            int res = 0;
            int num = n * n;
            while (num > 0)
            {
                res += num;
                num--;
            }
            return res;  
        }

        public static List<int> GenerateArray(int n)
        {
            List<int> array = new List<int>();

            for (int i = 0; i < n; i++)
            {
                array.Add(i + 1);
            }

            return array;
        }
    } 
}
