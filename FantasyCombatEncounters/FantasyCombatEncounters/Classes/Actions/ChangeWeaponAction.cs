using FantasyCombatEncounters.Classes.Combatants;
using FantasyCombatEncounters.Classes.Types;
using FantasyCombatEncounters.Classes.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCombatEncounters.Classes.Actions
{
    internal class ChangeWeaponAction : IAction
    {
        public ChangeWeaponAction()
        {
            Name = "Change Weapon";
            Type = ActionType.Action;
            Message = "";
        }

        public string Name { get; set; }
        public ActionType Type { get; set; }
        public string Message { get; set; }

        public IWeapon ChangeWeapon(ICombatant combatant, IWeapon weapon)
        {
            if (((weapon.Type == WeaponType.Melee || weapon.Type == WeaponType.MeleeOrRanged) && !weapon.IsTwoHanded) && combatant.HasShield)
            {
                combatant.ToggleShield(true);
            }
            combatant.ActiveWeapon = weapon;
            Message = combatant.Name + " is now using its " + weapon.Name.ToLower();
            return weapon;
        }
    }
}
