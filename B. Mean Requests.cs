using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo nfi_e = new CultureInfo("en-US", false).NumberFormat; 

            var initialNumbers = Console.ReadLine().Split();
            // Initial set of numbers
            int n = int.Parse(initialNumbers[0]);
            int T = int.Parse(initialNumbers[1]);
            double c = Convert.ToDouble(initialNumbers[2],nfi_e);

            // at  кол во обращений в секунду
            int[] at = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // m - кол-во моментов времение для отпута
            int m = int.Parse(Console.ReadLine());

            // pj - time moment
            var pj = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // First we have to calculate real values
            double[] realValues = new double[m];

            for (int i = 0; i < m; i++)
            {
                int count = 0;
                for (int j = i; j < i + T; j++)
                {
                    count += at[j];
                }
                double Value = (double)count / (double)T;
                realValues[i] = Value;
                //Console.WriteLine(realValues[i]);
            }

            // Now lets calculate approx values
            double[] approxValues = new double[m];

            // Key (int) - number of position
            // Value (int) - mean on this step
            Dictionary<int, double> means = new Dictionary<int, double>();

            double firstMean = 0;
            for (int i = 0; i < pj[0]; i++)
            {
                firstMean = (firstMean + (double)at[i]/(double)T)/ c;
            }

            means[pj[0]] = firstMean;
            approxValues[0] = firstMean;


            for (int i = 1; i < m; i++)
            {
                double currentMean = 0;

                if (pj[i] - pj[i - 1] <= 1)
                {
                    currentMean = (means[pj[i - 1]] + (double)at[pj[i - 1]] / (double)T) / c;
                }
                else
                {
                    currentMean = means[pj[i - 1]];
                    for (int j = pj[i - 1]; j < pj[i]; j++)
                    {
                        currentMean = (currentMean + (double)at[pj[j - 1]] / (double)T) / c;
                    }
                }

                means[pj[i]] = currentMean;
                approxValues[i] = currentMean;
            }

            // error
            double[] errorValues = new double[m];

            for (int i = 0; i < m; i++)
            {
                errorValues[i] = Math.Abs(approxValues[i] - realValues[i]) / realValues[i];
                Console.Write("{0:0.000000}", realValues[i].ToString(nfi_e));
                Console.Write(" ");
                Console.Write("{0:0.000000}", approxValues[i].ToString(nfi_e));
                Console.Write(" ");
                Console.Write("{0:0.000000}", errorValues[i].ToString(nfi_e));
                Console.WriteLine();
            }

          Console.ReadLine();
        } 
    }
}
