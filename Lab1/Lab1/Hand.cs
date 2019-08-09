using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Hand
    {
        public List<string> combatcard;
        public List<string> specialcard;

        public Hand(List<string> combatcard2, List<string> specialcard2)
        {
            combatcard = combatcard2;
            specialcard = specialcard2;
        }
        public List<string> Combatcard
        {
            get
            {
                return combatcard;

            }
            set
            {
                combatcard = value;
            }
        }
    }
}
