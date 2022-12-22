using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndSpellCards
{
    internal class Character
    {
        public string characterName { get; set; }
        public int characterLevel { get; set; }
        public int characterSpellSlots { get; set; }

        public BindingList<Spell> characterSpellList {get; set; }


        //This exists purely for overload purposes :)
        public Character(string _name, int _level, int _slots, BindingList<Spell> _characterSpellList)
        {
            this.characterName = _name;
            this.characterLevel = _level;
            this.characterSpellSlots = _slots;
            this.characterSpellList = _characterSpellList;
        }
        public Character(string _name, int _level, int _slots) : this( _name,  _level,  _slots, new BindingList<Spell>()){}
    }
}
