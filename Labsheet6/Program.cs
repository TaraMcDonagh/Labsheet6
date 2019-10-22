using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet6
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 5 Player objects
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            //Create a List of type Player to hold all the Player objects.
            List<Player> allPlayers = new List<Player>();
            allPlayers.Add(player1);
            allPlayers.Add(player2);
            allPlayers.Add(player3);
            allPlayers.Add(player4);
            allPlayers.Add(player5);

            Display(allPlayers);

            /*In the Main method, create a loop that repeatedly asks the 
             *user to enter the number of the Player whose score they want 
             *to update */
            Console.WriteLine("Please enter number of player you wish to add score for");
            string response = Console.ReadLine();
            int playerNumber = int.Parse(response);


            //– the loop should repeat until the user enters 0 
            while (playerNumber !=0)
            {
                /*– the loop should evaluate which Player number (1-5) has been entered 
                 *using either If 	statements or Switch/Case statements and update that 
                 *player’s score using the 	IncreaseScore method e.g. player1.Increase.Score(1)*/
                Player selectedPlayer = allPlayers.ElementAt(playerNumber-1);
                selectedPlayer.IncreasedScore(1);


                /*– the loop should display the score of all players after each IncreaseScore 
                * method call using the Display method.*/
                Display(allPlayers);


                Console.WriteLine("Please enter number of player you wish to add score for");
                response = Console.ReadLine();
                playerNumber = int.Parse(response);
            }//end of while loop









        }
            /*Create a method to display Players scores for all players.
             * This method should have a List<Player> as a parameter.*/
            private static void Display(List<Player> players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");
            foreach (Player player in players)
            {
                Console.Write("{0,-10}",player.Score);
            }

            Console.WriteLine();

        }
    }
}
