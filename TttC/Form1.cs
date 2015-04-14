using Microsoft.VisualBasic.FileIO;
//TTTC main prototype by Joshua Wilfong
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TttC
{
    public partial class Form1 : Form
    {
        class Verse
        {
            string[] db = new string[3];
            List<string> database = new List<string>();
            List<Verse> verses = new List<Verse>();
            
            string tags;
            string reference;
            string text;

            public Verse()
            {

            }

            public Verse(string tags, string reference, string text)
            {
                this.tags = tags;
                this.reference = reference;
                this.text = text;
            }

            public void readVerses()
            {
                TextFieldParser parser = new TextFieldParser("Typing to the Cross Verses.csv");

                parser.HasFieldsEnclosedInQuotes = true;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    Verse thisVerse = new Verse(fields[0], fields[1], fields[2]);
                    verses.Add(thisVerse);
                }
                parser.Close();
            }

            internal string getVerse()
            {
                Verse verse;

                readVerses();
                
                int rand = (int)(new Random().Next(1, verses.Count));

                verse = verses.ElementAt(rand);

                string text = verse.text;

                return text;
            }

        }

        

        public Form1()
        {
            InitializeComponent();
            overworldPanel.Visible = false;
            combatPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            overworldPanel.Visible = true;

            timer1.Enabled = true;

        }

        private void mainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void overworldPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Move across the world map
                overworldCharacter.Location = new Point(overworldCharacter.Location.X + 3, 155);       
                if (overworldCharacter.Location.X > 450)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("You win!");
                }

                if (overworldCharacter.Location.X % 150 == 0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Encounter! Prepare for Battle!");
                    overworldPanel.Visible = false;
                    combatPanel.Visible = true;
                    
                    Verse v = new Verse();
                    verseLabel.Text = v.getVerse();
                    
                    textBox1.Focus();
                    timer2.Enabled = true;
                }



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

          

            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // move actors suring combat
            if (textBox1.Text.Length > 0) { 
            if (verseLabel.Text.Substring(textBox1.Text.Length - 1, 1) != textBox1.Text.Substring(textBox1.Text.Length - 1, 1))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.Select(textBox1.Text.Length, 0);
                Console.Beep();
                monster.Location = new Point(monster.Location.X - 9, 86);
            }
            else
            {
                monster.Location = new Point(monster.Location.X + 5, 86);
            }


            if (textBox1.Text.Length == verseLabel.Text.Length)
            {
                MessageBox.Show("You win Continue on your journey!");
                monster.Location = new Point(432, 86);
                textBox1.Text = "";
                overworldPanel.Visible = true;
                combatPanel.Visible = false;
                timer1.Enabled = true;
            }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //check monster location
            monster.Location = new Point(monster.Location.X - 1, 86);
            if (hero.Location.X > monster.Location.X)
            {
                timer2.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Retry battle to avoid burden?", "Retry?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    monster.Location = new Point(432, 86);
                    timer2.Enabled = true;
                    textBox1.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    monster.Location = new Point(432, 86);
                    textBox1.Text = "";
                    overworldPanel.Visible = true;
                    combatPanel.Visible = false;
                    timer1.Enabled = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 AFormInstance1 = new Form2();
            AFormInstance1.Show();
        }
    }
}
