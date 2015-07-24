using System;
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
            Console.WriteLine(TicTacToeWinner("xxx|oxo|.oo"));
            Console.WriteLine(TicTacToeWinner(".ox|o.x|o.x"));
            Console.ReadLine();

        }

        public static string TicTacToeWinner(string board)
        {
            var b = board.Split('|').ToArray();
            string winner = "Game is a tie";

            for (int i = 0; i < b.Length; i++)
            {
                int l = b[i].Length;
                int posV = 0;
                char checkV = b[0][i];
                int posH = 0;
                char checkH = b[i][0];

                // Check vertically
                for (int v = 0; v < l; v++)
                {
                    if (b[v][i] == checkV && b[v][i] != '.')
                        posV++; 
                }
                // Check a winner
                Console.WriteLine("Vertically " + posV);
                if (posV == 3)
                {
                    winner = checkV == 'x' ? "Player X is the winner" : "Player O is the winner";
                    return winner;
                }
                
                // Check horizontally
                for (int h = 0; h < l; h++)
                {
                    if (b[i][h] == checkH && b[i][h] != '.')
                        posH++;
                }
                // Check a winner
                Console.WriteLine("Horizontally " + i +  posV);
                if (posH == 3)
                {
                    Console.WriteLine("Horizontally " + i + posV);
                    winner = checkH == 'x' ? "Player X is the winner" : "Player O is the winner";
                    return winner;
                } 
            }

            //Check diagonall
            var diag1 = new List<char>();
            diag1.Add(b[0][0]);
            diag1.Add(b[1][1]);
            diag1.Add(b[2][2]);

            if (diag1.Any(x => x == diag1[0]) && diag1[0] != '.')
            {
                winner = diag1[0] == 'x' ? "Player X is the winner" : "Player O is the winner";
                return winner;
            }

            var diag2 = new List<char>();
            diag2.Add(b[0][2]);
            diag2.Add(b[1][1]);
            diag2.Add(b[2][0]);

            if (diag2.Any(x => x == diag2[0]) && diag2[0] != '.')
            {
                winner = diag2[0] == 'x' ? "Player X is the winner" : "Player O is the winner";
                return winner;
            }

            return winner;
        }

    }
}
