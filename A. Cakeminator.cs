using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    public struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int X,int Y)
        {
            this.x = X;
            this.y = Y;
        }
    }


    class Program
    {
       
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = nums[0]; //Rows
            var m = nums[1]; // Columns

            var res = Enumerable.Range(0, n).Select(a => Console.ReadLine()).ToList();

            Coordinate[] directions = 
            {
                new Coordinate(-1, 0), // Wes
                new Coordinate(-1,-1), // North West
                new Coordinate(0, -1), // North
                new Coordinate(1, -1), // North East
                new Coordinate(1, 0),  // East
                new Coordinate(1, 1),  // South East
                new Coordinate(0, 1),  // South
                new Coordinate(-1, 1)  // South West
            };

            bool faceFound = false;
            int countFaces = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (res[i][j] == 'f')
                    {
                       if (SearchNext(res,'f', directions, new Coordinate(i, j)) == true)
                       {
                           countFaces++;
                           break;
                       }
                    }
                }
            }

            Console.WriteLine(countFaces);
            Console.ReadLine();
        }

        public static bool SearchNext(List<string> picture, char CurrentLetter, Coordinate[] directions, Coordinate start)
        {
            if (CurrentLetter == 'e')
                return true;
            List<int> x = new List<int>();
            List<int> y = new List<int>();

            x.Add(start.x);
            y.Add(start.y);

            for (int i = 0; i < directions.Count(); i++)
            {
                if (((start.x + directions[i].x) < picture.Count) &&
                    ((start.y + directions[i].y) < picture[0].Count()) &&
                    (start.x + directions[i].x) >= 0 &&
                    (start.y + directions[i].y) >= 0)
                {
                    switch (picture[start.x + directions[i].x][start.y + directions[i].y])
                    {
                        case('a'):
                            x.Add(start.x + directions[i].x);
                            y.Add(start.y + directions[i].y);
                            break;
                        case ('c'):
                            x.Add(start.x + directions[i].x);
                            y.Add(start.y + directions[i].y);
                            break;
                        case ('e'):
                            x.Add(start.x + directions[i].x);
                            y.Add(start.y + directions[i].y);
                            break;
                    }
                }
            }

            if (Math.Abs(x.Max() - x.Min()) == 1 &&
                Math.Abs(y.Max() - y.Min()) == 1)
                return true;

            return false;
        }
    }
}
