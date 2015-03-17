using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialNumbers = Console.ReadLine().Split();
            // Initial set of numbers
            int n = int.Parse(initialNumbers[0]);
            int T = int.Parse(initialNumbers[1]);
            double c = double.Parse(initialNumbers[2], System.Globalization.CultureInfo.InvariantCulture);

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
                Console.WriteLine(Math.Round(realValues[i],6) + " " + Math.Round(approxValues[i],6) + " " + Math.Round(errorValues[i],6));
            }

          Console.ReadLine();
        } 
    }
}
