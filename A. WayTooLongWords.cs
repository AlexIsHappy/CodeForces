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
            String initialWord = Console.ReadLine().ToLower();
            List<string> consonants = new List<string>();

                for (int i = 0; i < initialWord.Length; i++)
                {
                    if (initialWord[i] == 'a' ||
                        initialWord[i] == 'e' ||
                        initialWord[i] == 'o' ||
                        initialWord[i] == 'y' ||
                        initialWord[i] == 'u' ||
                        initialWord[i] == 'i')
                    {
                       
                    } 
                    else
                    {
                        consonants.Add("." + initialWord[i]);
                    }
                }

                for (int i = 0; i < consonants.Count; i++)
                    Console.Write(consonants[i]);

                    Console.ReadLine();
        }
    }
}

