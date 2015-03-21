using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int strLength = int.Parse(Console.ReadLine());
            String str1 = Console.ReadLine();
            String str2 = Console.ReadLine();
            Dictionary<int,char> mist1 = new Dictionary<int, char>();
            Dictionary<int,char> mist2 = new Dictionary<int,char>();
            int minDistance = InitialDist (strLength, str1, str2, mist1, mist2);
            int position1 = -1;
            int position2 = -1;

            int count = 0;

            foreach (char value in mist1.Values)
            {
                int currentKey = mist1.First(x => x.Value == value).Key;
                if (mist2.ContainsValue(value))
                {
                    position1 = mist2.First(x => x.Value == value).Key;
                    if (mist1[position1] == mist2.First(x => x.Key == currentKey).Value)
                    {
                        count = 2;
                    } else
                    {
                        count = 1;
                    }
                    position2 = currentKey;

                    break;
                }
                
            }

            Console.WriteLine(minDistance - count);
            if (position1 >= 0 && position2 >= 0)
                Console.WriteLine("{0} {1}", position1 + 1, position2 + 1);
            else 
                Console.WriteLine("{0} {1}", position1, position2);
            Console.ReadLine();
        }

        public static string SwapChars (string str, int position1, int position2)
        {
            char[] strChars = str.ToCharArray();
            char temp = strChars[position1];
            strChars[position1] = strChars[position2];
            strChars[position2] = temp;
            return new String(strChars);
        }


        public static int InitialDist(int length, String str1, String str2, Dictionary<int, char> mist1, Dictionary<int,char> mist2)
        {
            int distance = 0;
            for (int i = 0; i < length; i++)
            {
                if (str1[i] != str2[i])
                {
                    distance++;
                    mist1.Add(i, str1[i]);
                    mist2.Add(i, str2[i]);
                }
            }
            return distance;
        }

        public static int HamDist (int length, String str1, String str2)
        {
            int distance = 0;
            for (int i = 0; i< length; i++)
            {
                if (str1[i] != str2[i])
                {
                    distance++;
                }
            }
            return distance;
        }
    }
}
