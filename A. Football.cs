using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            String team = Console.ReadLine();
            String newTeam = team.Remove(0,1);
            String output = null;

            newTeam = newTeam.ToLower();
            char firstLetter = team[0];

            if (char.IsLower(firstLetter) == true)
            {
                output = string.Concat(team.ToUpper()[0].ToString(),newTeam);
            }
            else
                output = string.Concat(firstLetter.ToString() + newTeam);

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
