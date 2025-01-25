using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_State_Management
{
    // made this interface to reduce the coupling and achieve 5th principle (Dependancy Inversion)
    internal interface IMemento
    {
        public string GetName();
        public string GetPlayer();
        public int GetPoints();
    }
}
