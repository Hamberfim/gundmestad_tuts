using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class CombatAction : Character, IAbilities
    {
        public string EAbility()
        {
            return "-4 Damage to nearest enemy\n";
        }

        public string QAbility()
        {
            return "+5 to Shields\n";
        }

        public string RAbility()
        {
            return "+10 to Health\n";
        }

        public string WAbility()
        {
            throw new NotImplementedException();
        }

        public string ZAbility()
        {
            throw new NotImplementedException();
        }
    }
}
