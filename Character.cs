using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndSpellCards
{
    public class Character
    {
        public string name { get; }
        public int level { get; set; }
        public int health { get; set; }
        public int spellSlots { get; private set; }

        public Image image;
        public BindingList<Spell> spellList {get; set; }


        //Overload constructor to allow characters to be created with or without learned spells
        public Character(string _name, int _level,  int _health, int _slots,Image _image, BindingList<Spell> _spellList)
        {
            this.name = _name;
            this.level = _level;
            this.health = _health;
            this.spellSlots = _slots;
            this.image = _image;
            this.spellList = _spellList;
        }
        public Character(string _name, int _level, int _health, int _slots, Image _image) : this( _name, _level, _health, _slots, _image, new BindingList<Spell>()){}

        //Decrease spell slots and calculate spell damage to be done to the current enemy
        public int CastSpell(Character character, Spell spell, Enemy enemy) {

            if (spell.level != 0) { character.spellSlots--; };
            int damage = CalculateDamage(spell.damage);
            enemy.healthPoints -= damage;
            return damage;
        }

        //Calculate damaged based on dice type and amount of dice
        private int CalculateDamage(string dmg) {

            string[] nums = dmg.Split("d");
            int amount = int.Parse(nums[0]);
            int diceType = int.Parse(nums[1]);

            Random r = new Random();
            int damage = 0;
            for (int i = 1; i <= amount; i++) {
                damage += r.Next(1, (diceType + 1));       
            }
            return damage;
        }
    }
}
