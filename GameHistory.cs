using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Game_State_Management
{
    // this class is the caretaker make Backup and stores in the Stack
    // and make UNDO the data 
    // this class deal with State Mangement class to Save Or Undo mementos 
    internal class GameHistory
    {
        private StateMangement statemangement;

        private Stack<IMemento> mementos = new Stack<IMemento>();

        public GameHistory(StateMangement StateMangement)
        {
            this.statemangement = StateMangement;
        }
        // Making a memento with the current state and store it into the stack (mementos)
        public void Backup()
        {
            Console.WriteLine($"Caretaker: Saving {statemangement.GetPlayerName().ToLower()}'s state...");
            mementos.Push(statemangement.CreateState());
            Console.WriteLine("Saved Successfully");
        }
        // resoring the date or Undo the previous state and set the state to the editor (Game)
        public void Undo()
        {
            if (mementos.Count == 0) Console.WriteLine("There is no History To Undo");

            IMemento memento = mementos.Pop();

            statemangement.Restore(memento);

            Console.WriteLine("The Data Restores Successfully");
        }
        // loop into the stack and show the data with datetime of saving it 
        public void ShowHistory()
        {
            if (mementos.Count == 0) Console.WriteLine("There is no History To Show");

            foreach (var memento in mementos)
            {
                Console.WriteLine(memento.GetName());
                Console.WriteLine($"The Player {statemangement.GetPlayerName().ToLower()} Pointes " + memento.GetPoints());
            }
        }

    }
}
