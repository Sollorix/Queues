using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Babcock_Olivia
{
    // Creates class for Game
    internal class Game
    {
        // Sets get value for MaxPlayers
        public int MaxPlayers { get; }

        // Sets get and set values for CurrentPlayers
        public int CurrentPlayers { get; set; }

        // Creates constructor with two int parameters
        public Game(int maxP, int currentP)
        {
            // Assigns parameters to the corresponding properties.
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        // Creates method called KickPlayer
        public void KickPlayer()
        {
            // Decrements CurrentPlayers by 1
            CurrentPlayers--;
        }
        // Creates a method called CheckQUeue that takes a Queue<Player> parameter
        public void CheckQueue(Queue<Player> playerQueue)
        {
            // Creates an if statement
            if(CurrentPlayers < MaxPlayers)
            {
                // Creates an if and else statement
                if(playerQueue.Count > 0)
                {
                    // Calls Dequeue method the Queue
                    playerQueue.Dequeue();
                    // Increments current player by 1
                    CurrentPlayers++;
                }
                else
                {
                    // Prints to the console
                    Console.WriteLine("No players in the queue!");
                }
            }
        }
    }
}
