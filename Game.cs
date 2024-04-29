using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    internal class Game
    {
        int team1Score = 0;
        int team2Score = 0;

        public void AddReferee(string name, int age)
        {
            Referee referee = new Referee(name, age);
            Console.WriteLine($"Referee Name: {referee.Name}; Referee Age: {referee.Age};\n");
        }

        public void Goals()
        {
            Console.WriteLine("Football Game Started!");
            Random random = new Random();                     

            int totalGoals = random.Next(6);
            List<string> goals = new List<string>();

            for (int i = 0; i < totalGoals; i++)
            {
                if (totalGoals == 0)
                {
                    Console.WriteLine("No goals were scored!");
                }

                int teamIndex = random.Next(2);
                if (teamIndex == 0)
                {
                    team1Score++;
                }
                else
                {
                    team2Score++;
                }

                string scorer = "Player " + (i + 1);
                int minute = random.Next(1, 91);
                string goal = $"{scorer} scored a goal at {minute} minute.";
                goals.Add(goal);
            }

            foreach (string goal in goals)
            {
                Console.WriteLine(goal);
            }

            Console.WriteLine("Football Game Ended!");
        }
        
        public void GameResult()
        {
            Console.WriteLine("The result of the gaem is:");
            Console.WriteLine("Team 1 score = " + team1Score);
            Console.WriteLine("Team 2 score = " + team2Score);

            if (team1Score > team2Score)
            {
                Console.WriteLine("Team 1 won!");
            }
            else if (team1Score < team2Score)
            {
                Console.WriteLine("Team 2 won!");
            }
            else if (team1Score == team2Score)
            {
                Console.WriteLine("It's a tie!");
            }
        }

    }

    
}
