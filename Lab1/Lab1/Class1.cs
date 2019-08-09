using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Class1
    {
        public class combatcard
        {
            private string name;
            private int attackPoints;
            private bool hero;
            private string type;
            private string efect;

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
                    return efect;
                }
                set
                {
                    efect = value;
                }
            }
        }
    }
}
