using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    internal class Team
    {        
        public void AddPlayers(string name, int age, int number, double heigth)
        {
            FootballPlayer player = new FootballPlayer(name, age, number, heigth);
            Console.WriteLine($"Player Name: {player.Name}; Player Age: {player.Age}; Player Number: {player.Number}; Player Height: {player.Height};\n");
        }

        public void AddCoach(string name, int age)
        {
            Coach coach = new Coach(name, age);
            Console.WriteLine($"Coach Name: {coach.Name}; Coach Age: {coach.Age};\n");
        }

        


        public static double CalculateAvgAge(List<Person> team)
        {
            double totalAge = 0;

            foreach (FootballPlayer FootballPlayer in team)
            {
                totalAge += FootballPlayer.Age;
            }

            double avgAge = totalAge / team.Count;

            return avgAge;
        }
    }
}
