using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            List<string> cola = new List<string>();
            cola.Add("Sheldon");
            cola.Add("Leonard");
            cola.Add("Penny");
            cola.Add("Rajesh");
            cola.Add("Howard");

            int i = 0;
            int count = 0;

            while (count < numb)
            {
                if (i < 5)
                {
                    cola.Add(cola[i]);
                    cola.Add(cola[i]);
                    cola.RemoveAt(0);
                    i++;
                } 
                else
                {
                    i = 0;
                }

                count++;
            }

            
            Console.WriteLine(cola[0]);
            Console.ReadLine();
                //Console.WriteLine(cola[numb - 1]);

        }
    }
}
