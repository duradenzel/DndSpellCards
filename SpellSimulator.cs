using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace DndSpellCards
{
    public partial class SpellSimulator : Form
    {
        //Create empty lists for characters, spells and enemies
        private BindingList<Character> characterList = new BindingList<Character>();
        private BindingList<Spell> spellList = new BindingList<Spell>();
        private BindingList<Enemy> enemyList = new BindingList<Enemy>();
        Enemy enemy;

        //path to recourse directory for images
        string imgPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\/Resources/"));

        public SpellSimulator()
        {
            InitializeComponent();
            PopulateSpells();
            PopulateCharacters();
            PopulateEnemies();
        }

        //Create Spell objects and add to spell list
        public void PopulateSpells() {
            lbSpellList.DataSource = spellList;
            spellList.Add(new Spell("Lightning Bolt", "Placeholder Description", 3, "Self(100ft Line)", Spell.MagicSchool.Evocation, "Instantaneous", "8d6", Spell.ResourceCost.Action, false));
            spellList.Add(new Spell("Fireball", "Placeholder Description", 3, "150ft", Spell.MagicSchool.Evocation, "Instantaneous", "8d6", Spell.ResourceCost.Action, false));
            spellList.Add(new Spell("Acid Splash", "Placeholder Description", 0, "60ft", Spell.MagicSchool.Conjuration, "Instantaneous", "2d6", Spell.ResourceCost.Action, false));

        }

        //Create Character objects and add to spell list
        public void PopulateCharacters() {     
            cbCharacter.DataSource = characterList;
            characterList.Add(new Character("Stroheim", 5, 28, 5, Image.FromFile($"{imgPath}Wizard.jpg")));
            characterList.Add(new Character("Carter", 5, 33, 2, Image.FromFile($"{imgPath}Sorcerer.jpg"), new BindingList<Spell>{ spellList.First(_spell => _spell.name == "Fireball") }));
            
            //Display character values on design

            Character character = characterList[0];
            lblSpellSlots.Text = character.spellSlots.ToString();
            lbKnownSpells.DataSource = character.spellList;
            lblCharacterName.Text = character.name;
            lblCharacterHp.Text = character.health.ToString();
            pbCharacter.Image = character.image;

            

        }

        //Create Enemy objects and add to spell list
        public void PopulateEnemies() {
            enemyList.Add(new Enemy("Hell Hound", 45, 3, Image.FromFile($"{imgPath}Hell_Hound.jpg") ));
            enemyList.Add(new Enemy("White Dragon", 95, 8, Image.FromFile($"{imgPath}White_Dragon.png") ));

            //Select random enemy from the list and display values

            Random r = new Random();
            enemy = enemyList[r.Next(enemyList.Count())];
            lblEnemyHp.Text = enemy.healthPoints.ToString();
            lblEnemyName.Text = enemy.name;
            pbEnemy.Image = enemy.image;
        }

        
        //Swap currently selected Character object and display new values
        private void ChangeCharacter(object sender, EventArgs e)
        {
            Character character = (Character)cbCharacter.SelectedItem;

            if (cbCharacter.SelectedItem == null) { return; }

            lblSpellSlots.Text = character.spellSlots.ToString();            
            lbKnownSpells.DataSource = character.spellList;
            lblCharacterName.Text = character.name;
            lblCharacterHp.Text = character.health.ToString();
            pbCharacter.Image = character.image;
        }


        //Add a new Spell object to the spell list of the currently selected class if one is selected and not yet learned
        private void btnLearnSpell_Click(object sender, EventArgs e)
        {
            if (cbCharacter.SelectedItem == null || lbSpellList.SelectedItem == null) { return; }

            Character character = (Character)cbCharacter.SelectedItem;
            Spell spell = (Spell)lbSpellList.SelectedItem;

            if (character.spellList.Any(e => e.name == spell.name)) { TypeWriter("Spell already learned", lblCharacterAction); return; }
            character.spellList.Add(spell);
            
        }

        //Use the currently selec
        private void btnCastSpell_Click(object sender, EventArgs e)
        {
            if (lbKnownSpells.SelectedItem == null) { return; }

            Character character = (Character)cbCharacter.SelectedItem;
            Spell spell = (Spell)lbKnownSpells.SelectedItem;

            if (character.health <= 0) { TypeWriter("Character is dead", lblCharacterAction); return; }
            if (character.spellSlots == 0) { TypeWriter("Character is out of spell slots", lblCharacterAction); return; }

            int damage = character.CastSpell(character, spell, enemy);
            TypeWriter($"{character.name} casts {spell.name} for {damage} damage!", lblCharacterAction);
            lblEnemyHp.Text = enemy.healthPoints.ToString();
            lblEnemyAction.Text = "";
            lblSpellSlots.Text = character.spellSlots.ToString();
            if (enemy.healthPoints > 0)
            {
                lblEnemyHp.Text = enemy.healthPoints.ToString();
                lblEnemyAction.Text = "";
            }
            else
            {
                lblEnemyHp.Text = "0";
                TypeWriter($"{enemy.name} has been defeated!", lblEnemyAction);
            }

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            Character character = (Character)cbCharacter.SelectedItem;
            //string msg = $"{enemy.name} uses Bite! You take {enemy.Bite(character)} damage!";
            if (enemy.healthPoints <= 0) { TypeWriter("Enemy is dead", lblEnemyAction); return; }

            TypeWriter($"{enemy.name} uses Bite! You take {enemy.Bite(character)} damage!", lblEnemyAction);
            if(character.health > 0)
            {
                lblCharacterHp.Text = character.health.ToString();
                lblCharacterAction.Text = "";
            }
            else
            {
                lblCharacterHp.Text = "0";
                TypeWriter($"{character.name} died a horrible death", lblCharacterAction);
            }
            
        }

        public async void TypeWriter(string msg, Label label)
        {
            label.Text = "";
            for (int i = 0; i < msg.Length; i++)
            {
                label.Text += msg[i];
                await Task.Delay(1);  
            }
        }
    }
}


