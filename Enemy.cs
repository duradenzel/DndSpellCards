using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndSpellCards
{
    public class Enemy
    {
        public string name { get; }
        public int healthPoints { get; set; }
        public int creatureRating { get; }

        public Image image;
      

        public Enemy(string _name, int _healthPoints, int _creatureRating, Image image)
        {
            this.name = _name;
            this.healthPoints = _healthPoints;
            this.creatureRating = _creatureRating;    
            this.image = image;
        }

        //Calulate damage to be done to current player
        public int Bite(Character character) {
            Random r = new Random();
            int damage = r.Next(1, 9) + 3 + r.Next(2,7) + r.Next(2, 7);
            character.health -= damage;
            return damage;
        }
    }
}
