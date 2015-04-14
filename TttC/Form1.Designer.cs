namespace TttC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.overworldPanel = new System.Windows.Forms.Panel();
            this.overworldCharacter = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.combatPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monster = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.verseLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.mainMenuPanel.SuspendLayout();
            this.overworldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overworldCharacter)).BeginInit();
            this.combatPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.button2);
            this.mainMenuPanel.Controls.Add(this.label1);
            this.mainMenuPanel.Controls.Add(this.button1);
            this.mainMenuPanel.Location = new System.Drawing.Point(11, 11);
            this.mainMenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(257, 281);
            this.mainMenuPanel.TabIndex = 2;
            this.mainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainMenuPanel_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Prototype Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // overworldPanel
            // 
            this.overworldPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("overworldPanel.BackgroundImage")));
            this.overworldPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.overworldPanel.Controls.Add(this.overworldCharacter);
            this.overworldPanel.Location = new System.Drawing.Point(19, 96);
            this.overworldPanel.Margin = new System.Windows.Forms.Padding(2);
            this.overworldPanel.Name = "overworldPanel";
            this.overworldPanel.Size = new System.Drawing.Size(529, 247);
            this.overworldPanel.TabIndex = 2;
            this.overworldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.overworldPanel_Paint);
            // 
            // overworldCharacter
            // 
            this.overworldCharacter.BackColor = System.Drawing.Color.Transparent;
            this.overworldCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("overworldCharacter.BackgroundImage")));
            this.overworldCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.overworldCharacter.Location = new System.Drawing.Point(0, 155);
            this.overworldCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.overworldCharacter.Name = "overworldCharacter";
            this.overworldCharacter.Size = new System.Drawing.Size(41, 41);
            this.overworldCharacter.TabIndex = 0;
            this.overworldCharacter.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // combatPanel
            // 
            this.combatPanel.Controls.Add(this.panel1);
            this.combatPanel.Controls.Add(this.textBox1);
            this.combatPanel.Controls.Add(this.verseLabel);
            this.combatPanel.Location = new System.Drawing.Point(36, 0);
            this.combatPanel.Name = "combatPanel";
            this.combatPanel.Size = new System.Drawing.Size(529, 457);
            this.combatPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.hero);
            this.panel1.Controls.Add(this.monster);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 242);
            this.panel1.TabIndex = 3;
            // 
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Transparent;
            this.monster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("monster.BackgroundImage")));
            this.monster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monster.Location = new System.Drawing.Point(432, 57);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(54, 86);
            this.monster.TabIndex = 1;
            this.monster.TabStop = false;
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Transparent;
            this.hero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hero.BackgroundImage")));
            this.hero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hero.Location = new System.Drawing.Point(80, 106);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(37, 37);
            this.hero.TabIndex = 0;
            this.hero.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 391);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 53);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // verseLabel
            // 
            this.verseLabel.Location = new System.Drawing.Point(49, 349);
            this.verseLabel.Name = "verseLabel";
            this.verseLabel.Size = new System.Drawing.Size(440, 38);
            this.verseLabel.TabIndex = 0;
            this.verseLabel.Text = "Verse";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 456);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.combatPanel);
            this.Controls.Add(this.overworldPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Typing to the Cross";
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.overworldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overworldCharacter)).EndInit();
            this.combatPanel.ResumeLayout(false);
            this.combatPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel overworldPanel;
        private System.Windows.Forms.PictureBox overworldCharacter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel combatPanel;
        private System.Windows.Forms.Label verseLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer3;
    }
}

