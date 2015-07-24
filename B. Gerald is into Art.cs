using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());

           List<string[]> tests = new List<string[]>();
           List<string[]> checks = new List<string[]>();

           for (int i = 0; i < T; i++)
           {
               var sizeT = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
               var matr = new string[sizeT[0]];

               for (int l = 0; l < sizeT[0]; l++)
               {
                   matr[l] = Console.ReadLine();
               }

               var sizeC = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
               var matC = new string[sizeC[0]];

               for (int c = 0; c < sizeC[0];c++)
               {
                   matC[c]= Console.ReadLine();
               }

                   tests.Add(matr);
                   checks.Add(matC);
           }

           bool[] ans = new bool[T];
           for (int i = 0; i < T; i++)
           {
               var matrix = tests[i];
               var check = checks[i];

              for (int r = 0; r < matrix.Length; r++)
              {
                  if (matrix[r].Contains(check[0]))
                  {
                      if (r < matrix.Length - 1)
                      {
                          var posit = matrix[r].IndexOf(check[0]);
                          var row = r + 1;
                          bool cont = true;

                          for (int c = 1; c < check.Length; c++)
                          {
                              if (!matrix[row].Contains(check[c]) || matrix[row].IndexOf(check[c]) != posit)
                              {
                                  cont = false;
                                  break;
                              }
                              row++;
                          }

                          if (cont == true)
                          {
                              ans[r] = true;
                              break;
                          }
                      }
                  }
              }
           }


           for (int i = 0; i < T; i++)
           {
               Console.WriteLine(ans[i] == true ? "YES" : "NO");
           }
               Console.ReadLine();
        }
    }
}
