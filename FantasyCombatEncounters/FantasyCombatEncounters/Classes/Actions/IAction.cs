using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal interface IAction
    {
        string Name { get; set; }
        ActionType Type { get; set; }
        string Message { get; set; } 
    }
}
