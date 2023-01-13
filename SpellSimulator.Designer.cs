namespace DndSpellCards
{
    partial class SpellSimulator
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
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnLearnSpell = new System.Windows.Forms.Button();
            this.btnCastSpell = new System.Windows.Forms.Button();
            this.lblSpellSlots = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCharacter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharacterHp = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.gbKnownSpells = new System.Windows.Forms.GroupBox();
            this.lbKnownSpells = new System.Windows.Forms.ListBox();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyAction = new System.Windows.Forms.Label();
            this.lblEnemyHp = new System.Windows.Forms.Label();
            this.lblCharacterAction = new System.Windows.Forms.Label();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.pbEnemyHealth = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbSpellList.SuspendLayout();
            this.gbCharStats.SuspendLayout();
            this.gbKnownSpells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSpellList
            // 
            this.gbSpellList.BackColor = System.Drawing.Color.Snow;
            this.gbSpellList.Controls.Add(this.lbSpellList);
            this.gbSpellList.Location = new System.Drawing.Point(4, 20);
            this.gbSpellList.Name = "gbSpellList";
            this.gbSpellList.Size = new System.Drawing.Size(264, 278);
            this.gbSpellList.TabIndex = 0;
            this.gbSpellList.TabStop = false;
            this.gbSpellList.Text = "Spell List";
            // 
            // lbSpellList
            // 
            this.lbSpellList.DisplayMember = "name";
            this.lbSpellList.FormattingEnabled = true;
            this.lbSpellList.ItemHeight = 20;
            this.lbSpellList.Location = new System.Drawing.Point(6, 26);
            this.lbSpellList.Name = "lbSpellList";
            this.lbSpellList.Size = new System.Drawing.Size(252, 224);
            this.lbSpellList.TabIndex = 0;
            // 
            // gbCharStats
            // 
            this.gbCharStats.BackColor = System.Drawing.Color.Snow;
            this.gbCharStats.Controls.Add(this.btnEndTurn);
            this.gbCharStats.Controls.Add(this.btnLearnSpell);
            this.gbCharStats.Controls.Add(this.btnCastSpell);
            this.gbCharStats.Controls.Add(this.lblSpellSlots);
            this.gbCharStats.Controls.Add(this.label4);
            this.gbCharStats.Controls.Add(this.cbCharacter);
            this.gbCharStats.Controls.Add(this.label1);
            this.gbCharStats.Location = new System.Drawing.Point(1096, -2);
            this.gbCharStats.Name = "gbCharStats";
            this.gbCharStats.Size = new System.Drawing.Size(264, 629);
            this.gbCharStats.TabIndex = 1;
            this.gbCharStats.TabStop = false;
            this.gbCharStats.Text = "Character Stats";
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(31, 581);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(94, 29);
            this.btnEndTurn.TabIndex = 7;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnLearnSpell
            // 
            this.btnLearnSpell.Location = new System.Drawing.Point(31, 255);
            this.btnLearnSpell.Name = "btnLearnSpell";
            this.btnLearnSpell.Size = new System.Drawing.Size(94, 29);
            this.btnLearnSpell.TabIndex = 2;
            this.btnLearnSpell.Text = "Learn Spell";
            this.btnLearnSpell.UseVisualStyleBackColor = true;
            this.btnLearnSpell.Click += new System.EventHandler(this.btnLearnSpell_Click);
            // 
            // btnCastSpell
            // 
            this.btnCastSpell.Location = new System.Drawing.Point(137, 255);
            this.btnCastSpell.Name = "btnCastSpell";
            this.btnCastSpell.Size = new System.Drawing.Size(94, 29);
            this.btnCastSpell.TabIndex = 3;
            this.btnCastSpell.Text = "Cast Spell";
            this.btnCastSpell.UseVisualStyleBackColor = true;
            this.btnCastSpell.Click += new System.EventHandler(this.btnCastSpell_Click);
            // 
            // lblSpellSlots
            // 
            this.lblSpellSlots.AutoSize = true;
            this.lblSpellSlots.Location = new System.Drawing.Point(137, 217);
            this.lblSpellSlots.Name = "lblSpellSlots";
            this.lblSpellSlots.Size = new System.Drawing.Size(18, 20);
            this.lblSpellSlots.TabIndex = 6;
            this.lblSpellSlots.Text = "...";
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
            // cbCharacter
            // 
            this.cbCharacter.DisplayMember = "name";
            this.cbCharacter.FormattingEnabled = true;
            this.cbCharacter.Location = new System.Drawing.Point(99, 26);
            this.cbCharacter.Name = "cbCharacter";
            this.cbCharacter.Size = new System.Drawing.Size(151, 28);
            this.cbCharacter.TabIndex = 3;
            this.cbCharacter.Text = "Select Character";
            this.cbCharacter.SelectionChangeCommitted += new System.EventHandler(this.ChangeCharacter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spell Slots";
            // 
            // lblCharacterHp
            // 
            this.lblCharacterHp.AutoSize = true;
            this.lblCharacterHp.BackColor = System.Drawing.Color.Transparent;
            this.lblCharacterHp.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterHp.Location = new System.Drawing.Point(618, 522);
            this.lblCharacterHp.Name = "lblCharacterHp";
            this.lblCharacterHp.Size = new System.Drawing.Size(25, 30);
            this.lblCharacterHp.TabIndex = 12;
            this.lblCharacterHp.Text = "0";
            this.lblCharacterHp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.BackColor = System.Drawing.Color.Transparent;
            this.lblCharacterName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterName.Location = new System.Drawing.Point(571, 333);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(136, 30);
            this.lblCharacterName.TabIndex = 5;
            this.lblCharacterName.Text = "Player Name";
            // 
            // gbKnownSpells
            // 
            this.gbKnownSpells.BackColor = System.Drawing.Color.Snow;
            this.gbKnownSpells.Controls.Add(this.lbKnownSpells);
            this.gbKnownSpells.Location = new System.Drawing.Point(4, 309);
            this.gbKnownSpells.Name = "gbKnownSpells";
            this.gbKnownSpells.Size = new System.Drawing.Size(264, 278);
            this.gbKnownSpells.TabIndex = 1;
            this.gbKnownSpells.TabStop = false;
            this.gbKnownSpells.Text = "Known Spells";
            // 
            // lbKnownSpells
            // 
            this.lbKnownSpells.DisplayMember = "name";
            this.lbKnownSpells.FormattingEnabled = true;
            this.lbKnownSpells.ItemHeight = 20;
            this.lbKnownSpells.Location = new System.Drawing.Point(6, 26);
            this.lbKnownSpells.Name = "lbKnownSpells";
            this.lbKnownSpells.Size = new System.Drawing.Size(252, 224);
            this.lbKnownSpells.TabIndex = 1;
            // 
            // pbEnemy
            // 
            this.pbEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnemy.Location = new System.Drawing.Point(571, 57);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(150, 150);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy.TabIndex = 2;
            this.pbEnemy.TabStop = false;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnemyName.Location = new System.Drawing.Point(571, 24);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(142, 30);
            this.lblEnemyName.TabIndex = 7;
            this.lblEnemyName.Text = "Enemy Name";
            this.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyAction
            // 
            this.lblEnemyAction.AutoSize = true;
            this.lblEnemyAction.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyAction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnemyAction.ForeColor = System.Drawing.Color.White;
            this.lblEnemyAction.Location = new System.Drawing.Point(525, 257);
            this.lblEnemyAction.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblEnemyAction.Name = "lblEnemyAction";
            this.lblEnemyAction.Size = new System.Drawing.Size(0, 23);
            this.lblEnemyAction.TabIndex = 8;
            this.lblEnemyAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyHp
            // 
            this.lblEnemyHp.AutoSize = true;
            this.lblEnemyHp.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHp.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnemyHp.Location = new System.Drawing.Point(618, 213);
            this.lblEnemyHp.Name = "lblEnemyHp";
            this.lblEnemyHp.Size = new System.Drawing.Size(25, 30);
            this.lblEnemyHp.TabIndex = 10;
            this.lblEnemyHp.Text = "0";
            this.lblEnemyHp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharacterAction
            // 
            this.lblCharacterAction.AutoSize = true;
            this.lblCharacterAction.BackColor = System.Drawing.Color.Transparent;
            this.lblCharacterAction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterAction.ForeColor = System.Drawing.Color.White;
            this.lblCharacterAction.Location = new System.Drawing.Point(525, 568);
            this.lblCharacterAction.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblCharacterAction.Name = "lblCharacterAction";
            this.lblCharacterAction.Size = new System.Drawing.Size(0, 23);
            this.lblCharacterAction.TabIndex = 13;
            this.lblCharacterAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCharacter
            // 
            this.pbCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCharacter.Location = new System.Drawing.Point(571, 366);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(150, 150);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharacter.TabIndex = 11;
            this.pbCharacter.TabStop = false;
            // 
            // pbEnemyHealth
            // 
            this.pbEnemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemyHealth.Image = global::DndSpellCards.Properties.Resources.heart;
            this.pbEnemyHealth.Location = new System.Drawing.Point(584, 213);
            this.pbEnemyHealth.Name = "pbEnemyHealth";
            this.pbEnemyHealth.Size = new System.Drawing.Size(30, 30);
            this.pbEnemyHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyHealth.TabIndex = 14;
            this.pbEnemyHealth.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DndSpellCards.Properties.Resources.heart;
            this.pictureBox3.Location = new System.Drawing.Point(584, 522);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // SpellSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DndSpellCards.Properties.Resources.battleback1;
            this.ClientSize = new System.Drawing.Size(1358, 620);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbEnemyHealth);
            this.Controls.Add(this.lblCharacterHp);
            this.Controls.Add(this.lblCharacterAction);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.lblEnemyHp);
            this.Controls.Add(this.lblEnemyAction);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.gbKnownSpells);
            this.Controls.Add(this.gbCharStats);
            this.Controls.Add(this.gbSpellList);
            this.Name = "SpellSimulator";
            this.Text = "SpellSimulator";
            this.gbSpellList.ResumeLayout(false);
            this.gbCharStats.ResumeLayout(false);
            this.gbCharStats.PerformLayout();
            this.gbKnownSpells.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbSpellList;
        private GroupBox gbCharStats;
        private Label label1;
        private GroupBox gbKnownSpells;
        private Label lblSpellSlots;
        private Label lblCharacterName;
        private Label label4;
        private ComboBox cbCharacter;
        private ListBox lbSpellList;
        private ListBox lbKnownSpells;
        private Button btnLearnSpell;
        private Button btnCastSpell;
        private PictureBox pbEnemy;
        private Label lblEnemyName;
        private Label lblEnemyAction;
        private Label lblEnemyHp;
        private Button btnEndTurn;
        private Label lblCharacterHp;
        private Label lblCharacterAction;
        private PictureBox pbCharacter;
        private PictureBox pbEnemyHealth;
        private PictureBox pictureBox3;
    }
}