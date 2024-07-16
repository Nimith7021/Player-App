using AgeChecker.Models;

namespace AgeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[] {

            new Player(100,"Adam",20),
            new Player(101,"Ajesh"),
            new Player(102,"Damian",38),
            new Player(103,"Arlo",29),
            new Player(104,"James",36),

            };

            Player maxPlayer = Player.WhoIsElder(players);

            Console.WriteLine(maxPlayer);
        }
    }
}
