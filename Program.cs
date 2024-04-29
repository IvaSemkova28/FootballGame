using football;
using System;

class Program
{
    static void Main(string[] args)
    {
        Team team1 = new Team();
        Team team2 = new Team();

        Game game = new Game();

        team1.AddPlayers("Stoichkov", 27, 8, 165);
        team2.AddPlayers("Dimitrov", 29, 3, 169);
        team1.AddCoach("Ivanov", 48);
        team2.AddCoach("Petrov", 44);


        game.AddReferee("Ref 1", 59);
        game.AddReferee("Ref 2", 49);
        game.AddReferee("Assistant Ref", 55);

        game.Goals();
        Console.WriteLine("...");
        game.GameResult();
    }
}