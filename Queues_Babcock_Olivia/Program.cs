using System;
using System.Collections.Generic;


namespace Queues_Babcock_Olivia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates game object
            Game myGame = new Game(50, 49);

            // Creates Queue of Player objects
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            // Lists objects in the Queue and their values
            Player p1 = new Player(100, "MMSix");
            Player p2 = new Player(100, "xXAwesomenessXx");
            Player p3 = new Player(100, "Get Good");
            Player p4 = new Player(100, "ZombieSlayer");

            // Calls JoinGame on all Player objects and passing through as arguements
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            // Prints to the console
            Console.WriteLine("Players in the Q:");
            // Creates a foreach loop
            foreach(Player player in waitingToJoinQ)
            {
                // Prints player gamertags to the console
                Console.WriteLine(player);
            }

            // Calls KickPlayer on the game
            myGame.KickPlayer();
            // Calls CheckQueue on the game
            myGame.CheckQueue(waitingToJoinQ);

            // Prints to the console
            Console.WriteLine("\nPlayers in the Q:");
            // Creates foreach loop
            foreach (Player player in waitingToJoinQ)
            {   
                // Prints players to console
                Console.WriteLine(player);
            }
        }
    }
}