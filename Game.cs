using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Game_State_Management
{
    // This is the Orginater
    // Stores onyl the data about the gane, get and set them
    internal class Game
    {
        private string Player { get; set; }
        public string playerName { get;  }
        private int Points { get; set; }

        public Game(string name)
        {
            playerName = name;
        }
        // getters and setters the data
        public void SetPlayer(string player) => Player = player;

        public void SetPoints(int points) => Points = points;

        public string GetPlayer() => Player;

        public int GetPoints() => Points;

    }
}
