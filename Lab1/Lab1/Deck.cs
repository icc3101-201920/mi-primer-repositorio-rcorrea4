using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Deck
    {
        private List<string> combatcardlist;
        private List<string> specialcardlist;

        public Deck(List<string> combatcardlist2, List<string> specialcardlist2)
        {
            combatcardlist = combatcardlist2;
            specialcardlist = specialcardlist2;
        }
        public List<string> Combatcardlist
        {
            get
            {
                return combatcardlist;
            }
            set
            {
                combatcardlist = value;
            }
        }
        public List<string> Specialcardlist
        {
            get
            {
                return specialcardlist;
            }
            set
            {
                specialcardlist = value;
            }
        }
        public void AddCombatCard()
        {

        }
        public void AddSpecialCard()
        {

        }
        public void destroycombatcard()
        {

        }
        public void destroyspecialcard()
        {

        }
        public void shuffle()
        {

        }


    }
}
