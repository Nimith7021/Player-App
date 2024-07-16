using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeChecker.Models
{
    internal class Player
    {
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }

        static int DEFAULT_AGE = 18;

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            Age = DEFAULT_AGE;
        }

        public Player(int id , string name , int age):this(id,name)
        {
            Age = age;
        }

        public override string ToString()
        {
            Console.WriteLine("The player with the maximum age is:");
            return $"Player ID : {Id}\n" +
                $"Player Name : {Name}\n" +
                $"Player Age : {Age}";
        }

        public static Player WhoIsElder(Player[] players)
        {
            int maxAge = 0;
            Player tempObject = null;
           foreach(Player player in players)
            {
                if (player.Age > maxAge)
                {
                    maxAge = player.Age;
                    tempObject = player;
                }
            }

            return tempObject;
        }
    }
}
