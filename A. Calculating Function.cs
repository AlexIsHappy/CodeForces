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
            var n = int.Parse(Console.ReadLine());
            List<Form> forms = new List<Form>();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                var form = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                forms.Add(new Form(form[0], form[1]));
            }

            foreach (int home in Form.guestFormes)
            {
                foreach(int guest in Form.homeFormes)
                {
                    if (home == guest)
                        count++;
                }
            }
            Console.WriteLine(count);
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
