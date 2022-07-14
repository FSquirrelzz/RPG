using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public abstract class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get
        {
            return Level;
        } 
        set
        {
            if(Experience>100)
            {
                Level=(Experience/100) + 1;
            }
            else
            {
                Level=1;
            }
        } }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MagicAttack { get; set; }
        public int MagicDefense { get; set; }
        public int Speed { get; set; }
        public int CriticalChance { get; set; }
        public double CriticalMultiplier { get; set; }
        public int Experience { get; set; }
        public int IconID { get; set; }
        public Icon Icon { get; set; }
    }
}