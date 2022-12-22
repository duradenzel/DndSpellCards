namespace DndSpellCards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSpellList = new System.Windows.Forms.GroupBox();
            this.lbSpellList = new System.Windows.Forms.ListBox();
            this.gbCharStats = new System.Windows.Forms.GroupBox();
            this.lblUsedSpellSlots = new System.Windows.Forms.Label();
            this.lblSpellSlots = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCurrentCharacter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKnownSpells = new System.Windows.Forms.GroupBox();
            this.lbKnownSpells = new System.Windows.Forms.ListBox();
            this.btnLearnSpell = new System.Windows.Forms.Button();
            this.gbSpellList.SuspendLayout();
            this.gbCharStats.SuspendLayout();
            this.gbKnownSpells.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSpellList
            // 
            this.gbSpellList.BackColor = System.Drawing.Color.Snow;
            this.gbSpellList.Controls.Add(this.lbSpellList);
            this.gbSpellList.Location = new System.Drawing.Point(-2, -2);
            this.gbSpellList.Name = "gbSpellList";
            this.gbSpellList.Size = new System.Drawing.Size(264, 521);
            this.gbSpellList.TabIndex = 0;
            this.gbSpellList.TabStop = false;
            this.gbSpellList.Text = "Spell List";
            // 
            // lbSpellList
            // 
            this.lbSpellList.DisplayMember = "spellName";
            this.lbSpellList.FormattingEnabled = true;
            this.lbSpellList.ItemHeight = 20;
            this.lbSpellList.Location = new System.Drawing.Point(6, 26);
            this.lbSpellList.Name = "lbSpellList";
            this.lbSpellList.Size = new System.Drawing.Size(252, 484);
            this.lbSpellList.TabIndex = 0;
            // 
            // gbCharStats
            // 
            this.gbCharStats.BackColor = System.Drawing.Color.Snow;
            this.gbCharStats.Controls.Add(this.lblUsedSpellSlots);
            this.gbCharStats.Controls.Add(this.lblSpellSlots);
            this.gbCharStats.Controls.Add(this.lblCharacterName);
            this.gbCharStats.Controls.Add(this.label4);
            this.gbCharStats.Controls.Add(this.cbCurrentCharacter);
            this.gbCharStats.Controls.Add(this.label3);
            this.gbCharStats.Controls.Add(this.label2);
            this.gbCharStats.Controls.Add(this.label1);
            this.gbCharStats.Location = new System.Drawing.Point(1096, -2);
            this.gbCharStats.Name = "gbCharStats";
            this.gbCharStats.Size = new System.Drawing.Size(264, 521);
            this.gbCharStats.TabIndex = 1;
            this.gbCharStats.TabStop = false;
            this.gbCharStats.Text = "Character Stats";
            // 
            // lblUsedSpellSlots
            // 
            this.lblUsedSpellSlots.AutoSize = true;
            this.lblUsedSpellSlots.Location = new System.Drawing.Point(186, 210);
            this.lblUsedSpellSlots.Name = "lblUsedSpellSlots";
            this.lblUsedSpellSlots.Size = new System.Drawing.Size(18, 20);
            this.lblUsedSpellSlots.TabIndex = 7;
            this.lblUsedSpellSlots.Text = "...";
            // 
            // lblSpellSlots
            // 
            this.lblSpellSlots.AutoSize = true;
            this.lblSpellSlots.Location = new System.Drawing.Point(186, 180);
            this.lblSpellSlots.Name = "lblSpellSlots";
            this.lblSpellSlots.Size = new System.Drawing.Size(18, 20);
            this.lblSpellSlots.TabIndex = 6;
            this.lblSpellSlots.Text = "...";
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(186, 150);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(18, 20);
            this.lblCharacterName.TabIndex = 5;
            this.lblCharacterName.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select:";
            // 
            // cbCurrentCharacter
            // 
            this.cbCurrentCharacter.DisplayMember = "characterName";
            this.cbCurrentCharacter.FormattingEnabled = true;
            this.cbCurrentCharacter.Location = new System.Drawing.Point(99, 26);
            this.cbCurrentCharacter.Name = "cbCurrentCharacter";
            this.cbCurrentCharacter.Size = new System.Drawing.Size(151, 28);
            this.cbCurrentCharacter.TabIndex = 3;
            this.cbCurrentCharacter.SelectionChangeCommitted += new System.EventHandler(this.ChangeCharacter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Used Spell Slots";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spell Slots";
            // 
            // gbKnownSpells
            // 
            this.gbKnownSpells.BackColor = System.Drawing.Color.Snow;
            this.gbKnownSpells.Controls.Add(this.lbKnownSpells);
            this.gbKnownSpells.Location = new System.Drawing.Point(394, -2);
            this.gbKnownSpells.Name = "gbKnownSpells";
            this.gbKnownSpells.Size = new System.Drawing.Size(264, 521);
            this.gbKnownSpells.TabIndex = 1;
            this.gbKnownSpells.TabStop = false;
            this.gbKnownSpells.Text = "Known Spells";
            // 
            // lbKnownSpells
            // 
            this.lbKnownSpells.DisplayMember = "spellName";
            this.lbKnownSpells.FormattingEnabled = true;
            this.lbKnownSpells.ItemHeight = 20;
            this.lbKnownSpells.Location = new System.Drawing.Point(6, 26);
            this.lbKnownSpells.Name = "lbKnownSpells";
            this.lbKnownSpells.Size = new System.Drawing.Size(252, 484);
            this.lbKnownSpells.TabIndex = 1;
            // 
            // btnLearnSpell
            // 
            this.btnLearnSpell.Location = new System.Drawing.Point(277, 40);
            this.btnLearnSpell.Name = "btnLearnSpell";
            this.btnLearnSpell.Size = new System.Drawing.Size(94, 29);
            this.btnLearnSpell.TabIndex = 2;
            this.btnLearnSpell.Text = "Learn Spell";
            this.btnLearnSpell.UseVisualStyleBackColor = true;
            this.btnLearnSpell.Click += new System.EventHandler(this.btnLearnSpell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 516);
            this.Controls.Add(this.btnLearnSpell);
            this.Controls.Add(this.gbKnownSpells);
            this.Controls.Add(this.gbCharStats);
            this.Controls.Add(this.gbSpellList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSpellList.ResumeLayout(false);
            this.gbCharStats.ResumeLayout(false);
            this.gbCharStats.PerformLayout();
            this.gbKnownSpells.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbSpellList;
        private GroupBox gbCharStats;
        private Label label2;
        private Label label1;
        private GroupBox gbKnownSpells;
        private Label lblUsedSpellSlots;
        private Label lblSpellSlots;
        private Label lblCharacterName;
        private Label label4;
        private ComboBox cbCurrentCharacter;
        private Label label3;
        private ListBox lbSpellList;
        private ListBox lbKnownSpells;
        private Button btnLearnSpell;
    }
}