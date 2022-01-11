using FantasyCombatEncounters.Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class MoveAway : IAction
    {
        public MoveAway()
        {
            Name = "Move";
            Type = ActionType.Move;
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }
    }
}
