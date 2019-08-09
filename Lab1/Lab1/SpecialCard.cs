using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SpecialCard
    {
        private string name;
        private string type;
        private string bufftype;
        private string effect;

        public SpecialCard(string name2,string type2, string bufftype2,string effect2)
        {
            name = name2;
            type = type2;
            bufftype = bufftype2;
            effect = effect2;
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
        public string Bufftype
        {
            get
            {
                return bufftype;
            }
            set
            {
                bufftype = value;

            }

        }
        public string Effect
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
