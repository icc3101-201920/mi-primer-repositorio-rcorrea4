using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class combatcard
    {
        private string name;
        private int attackPoints;
        private bool hero;
        private string type;
        private string effect;

        public combatcard(string name1, int attackPoints1, bool hero1, string type1, string effect1)
        {
            name = name1;
            attackPoints = attackPoints1;
            hero = hero1;
            type = type1;
            effect = effect1;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int AttackPoints
        {
            get
            {
                return attackPoints;
            }
            set
            {
                attackPoints = value;

            }
        }
        public bool Hero
        {
            get
            {
                return hero;
            }
            set
            {
                hero = value;
            }

        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Efect
        {
            get
            {
                return effect;
            }
            set
            {
                effect = value;
            }
        }
    }
}
