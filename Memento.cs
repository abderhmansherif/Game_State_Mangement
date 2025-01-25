using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_State_Management
{
    // and this is memento class to save the current state into memento object
    internal class Memento : IMemento
    {
        private string player { get; }
        private int points { get; }
        private DateTime _date { get; }
        public Memento(string palyer, int points)
        {
            this.player = palyer;
            this.points = points;
            this._date = DateTime.Now;
        }

        public string GetName() => $"{_date} / {player}";
        public string GetPlayer() => player;
        public int GetPoints() => points;


    }
}
