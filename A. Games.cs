using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();
            var sb = new StringBuilder();

            word = word.Replace("WUB", " ");

            while (word[0] == ' ')
               word.Remove(0,1);

            Console.WriteLine(word);
                Console.ReadLine();
        }

        public class Form
        {
            public static List<int> homeFormes = new List<int>();
            public static List<int> guestFormes = new List<int>();
            public int home;
            public int guest;

            public Form (int H, int G)
            {
                home = H;
                guest = G;

                homeFormes.Add(home);
                guestFormes.Add(guest);
            }
        }



    }
}
