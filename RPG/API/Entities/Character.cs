using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public abstract class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level{ get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MagicAttack { get; set; }
        public int MagicDefense { get; set; }
        public int Speed { get; set; }
        public int Critical { get; set; }
        public int CriticalDamage { get; set; }
    }
}