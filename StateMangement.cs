using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game_State_Management
{
    // and this class responsible for Create and restore mementos based on The data from Gmae Class
    // and achieve 1th principle Single Responsibilty
    internal class StateMangement
    {
        private Game game;

        public StateMangement(Game game) => this.game = game;

        // Saves the current state inside a memento.
        public IMemento CreateState() => new Memento(game.GetPlayer(), game.GetPoints());

        // at some point, the prev state of the gane can be restores using memento object
        public void Restore(IMemento memento)
        {
            game.SetPlayer(memento.GetPlayer());
            game.SetPoints(memento.GetPoints());
        }
        public string GetPlayerName() => game.playerName;

    }
}
