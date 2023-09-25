using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Babcock_Olivia
{
    // Creates a class for Player
    internal class Player
    {
        // Sets get and set values for Health
        public int Health { get; set; }

        // Sets get value for GamerTag
        public string GamerTag { get; }

        // Assigns parameters for health and name
        public Player(int healthParam, string nameParam)
        {
            // Assigns parameters to corresponding properties
            Health = healthParam;
            GamerTag = nameParam;
        }


        // Creates a method called JoinGame that takes two parameters
        public void JoinGame(Game game, Queue<Player> queue)
        {
            // Creates an if and else statement
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                // Calls Enqueue method and adds "this" player to the Queue
                queue.Enqueue(this);
            }
            else
            {
                // Prints to the console
                Console.WriteLine("Joining Game!");
                // Increases current players by 1
                game.CurrentPlayers++;
            }
        }

        // Overrides ToString
        public override string ToString()
        {
            // Returns GamerTag
            return GamerTag;
        }
    }
}
