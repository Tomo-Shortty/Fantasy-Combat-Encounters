using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Reactions
{
    internal interface IReaction
    {
        int Id { get; set; }
        string Name { get; set; }
        bool UnlimitedUses { get; set; }
        int UsesPerTurn { get; set; }
        int UsesPerGame { get; set; }
    }
}
