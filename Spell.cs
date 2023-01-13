using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndSpellCards
{
    public class Spell
    {
        public string name { get; }
        public string description { get; }
        public int level { get; }
        public string range { get; }

        public string duration { get;}

        public string? damage { get;}

        public bool recoveredAtShortRest { get;}

        private MagicSchool magicSchool;
        private ResourceCost resourceCost;
        public enum MagicSchool
        {
            Abjuration,
            Alteration,
            Conjuration,
            Divination,
            Enchantment,
            Evocation,
            Illusion,
            Invocation,
            Necromancy

        }

         public enum ResourceCost
        {
            Action,
            BonusAction,
            Reaction
        }

        
        public Spell(string _name, string _desc,int _level,string _range, MagicSchool _school, string _duration,string _damage, ResourceCost _cost, bool _recovery)
        {
            this.name = _name;
            this.description = _desc;
            this.level = _level;
            this.range = _range;
            this.duration = _duration;
            this.damage = _damage;
            this.magicSchool = _school;
            this.resourceCost = _cost;
            this.recoveredAtShortRest = _recovery;
            
        }
    }
}
