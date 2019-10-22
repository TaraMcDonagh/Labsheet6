using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet6
{
    //Create a class called Player with properties for PlayerID, PlayerName and Score.
    public class Player
    {        
        /*Provide public accessors for these properties with auto-implemented Getters 
        and Setters for each – and make PlayerID a read-only accessor.*/
        public int ID  { get;  }
        public string Name { get; set; }
        public int Score { get; private set; }
        //Create a Constructor for the class which takes in parameters for each of these properties.
        public Player(int id,string name,int score)
        {
            ID = id;
            Name = name;
            Score = score;
        }
        /*Create a method called IncreaseScore that takes in one parameter 
         *of type int, to add a value to a Player’s score. */
        public void IncreasedScore(int valueToAdd)
        {
            if (Score < 100)
            {
                Score += valueToAdd;
            }
        }
    }
}
