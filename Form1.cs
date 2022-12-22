using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DndSpellCards
{
    public partial class Form1 : Form
    {
        private BindingList<Character> characterList = new BindingList<Character>();
        private BindingList<Spell> spellList = new BindingList<Spell>();

        public Form1()
        {
            InitializeComponent();
            PopulateSpells();
            PopulateCharacters();
        }

        public void PopulateSpells() {
            lbSpellList.DataSource = spellList;
            spellList.Add(new Spell("Lightning Bolt", "Placeholder Description", 3, "Self(100ft Line)", Spell.MagicSchool.Evocation, "Instantaneous", Spell.ResourceCost.Action, false));
            spellList.Add(new Spell("Fireball", "Placeholder Description", 3, "150ft", Spell.MagicSchool.Evocation, "Instantaneous", Spell.ResourceCost.Action, false));
        }

        public void PopulateCharacters() {     
            characterList.Add(new Character("Stroheim", 5, 5));
            characterList.Add(new Character("Carter", 5, 0));
            cbCurrentCharacter.DataSource = characterList;
        }
        
        private void ChangeCharacter(object sender, EventArgs e)
        {
            if (cbCurrentCharacter.SelectedItem == null) { return; }
            lblCharacterName.Text = ((Character)cbCurrentCharacter.SelectedItem).characterName;
            lblSpellSlots.Text = ((Character)cbCurrentCharacter.SelectedItem).characterSpellSlots.ToString();            
            lbKnownSpells.DataSource = ((Character)cbCurrentCharacter.SelectedItem).characterSpellList;
        }


        private void btnLearnSpell_Click(object sender, EventArgs e)
        {
            if (cbCurrentCharacter.SelectedItem == null || lbSpellList.SelectedItem == null) { return; }
            Character character = (Character)cbCurrentCharacter.SelectedItem;
            Spell spell = (Spell)lbSpellList.SelectedItem;
            character.characterSpellList.Add(spell);            
        }
    }
}