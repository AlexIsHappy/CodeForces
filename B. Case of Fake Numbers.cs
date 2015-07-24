using System;
using System.Collections;
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
            var word = Console.ReadLine();
            var num = int.Parse(Console.ReadLine());
            var words = new String[num];

            int wordLength = (word.Length / num);

            int startIndex = 0;
            int endIndex = wordLength;

            for (int i = 0; i < num; i++)
            {
                words[i] = word.Substring(startIndex, wordLength);
                Console.WriteLine(words[i]);
                startIndex = endIndex;
                endIndex += wordLength;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (!isPalindrome(words[i]))
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
            Console.ReadLine();
        }

        public static bool isPalindrome(string str)
        {
            int min = 0;
            int max = str.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }


                char a = str[min];
                char b = str[max];

                if (a != b)
                {
                    return false;
                }

                min++;
                max--;
            }
        }
      
    }
}
