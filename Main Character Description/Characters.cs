using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.Main_Character_Description
{
    public abstract class Characters
    {
        public virtual string Name { get; set; }
        public virtual double hp { get; set; } = 50;
        public virtual int gold { get; set; } = 0;
        public virtual double agility { get; set; } = 20;
        public virtual int armor { get; set;}
        public virtual int speed { get; set; }

    }
}
