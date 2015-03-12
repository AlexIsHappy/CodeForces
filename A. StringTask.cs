using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
          {
            int numberGroups = int.Parse(Console.ReadLine());
            String[] groupsString = Console.ReadLine().Split();
            int[] groups = new int[numberGroups];
            int[] repeatedNum = {0,0,0,0};
            int currentTaxi = 0;
            int countTaxi = 0;

            for (int i = 0; i < numberGroups; i++)
            {
                switch (groups[i])
                {
                    case 1:
                        repeatedNum[0]++;
                        break;
                    case 2:
                        repeatedNum[1]++;
                        break;
                    case 3:
                        repeatedNum[2]++;
                        break;
                    case 4:
                        repeatedNum[3]++;
                        break;
                }
            }

            Console.WriteLine(repeatedNum[3] + repeatedNum[2] + (repeatedNum[1] + repeatedNum[0])/4);
            Console.ReadLine();
        }
    }

}

