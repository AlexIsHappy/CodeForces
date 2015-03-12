using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<String> users = new List<string>();
            int count = 1;

            for (int i = 0; i < length; i++)
            {
                String[] repost = Console.ReadLine().Split();
                users.Add(repost[2]);
                users.Add(repost[0]);
            }

            for (int i = 1; i < users.Count; i++)
            {
                if (users[i] == users[i-1])
                    count++;
            }

            Console.WriteLine(count + 1);
                Console.ReadLine();
        }
    }
}
