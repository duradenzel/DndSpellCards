using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndSpellCards
{
    internal class Spell
    {
        public string spellName { get; set; }
        public string spellDescription { get; set; }
        public int spellLevel { get; set; }
        public string spellRange { get; set; }

        public string spellDuration { get; set; }

        public bool spellRecoveredAtShortRest { get; set; }

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

        
        public Spell(string _name, string _desc,int _level,string _range, MagicSchool _school, string _duration, ResourceCost _cost, bool _recovery)
        {
            this.spellName = _name;
            this.spellDescription = _desc;
            this.spellLevel = _level;
            this.spellRange = _range;
            this.spellDuration = _duration;
            this.magicSchool = _school;
            this.resourceCost = _cost;
            this.spellRecoveredAtShortRest = _recovery;
            
        }
    }
}
