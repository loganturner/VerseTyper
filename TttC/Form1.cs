﻿using Microsoft.VisualBasic.FileIO;
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
using TttC;

namespace TttC
{
    public partial class Form1 : Form
    {
        public static List<Verse> AllVerses = new List<Verse>();
        public static List<Verse> SelectedVerses = new List<Verse>(); 
        public class Verse
        {
            public List<string> Tags = new List<string>();
            public string Reference;
            public string Text;

            public Verse(IEnumerable<string> tags, string reference, string text)
            {
                Tags = tags.ToList();
                Reference = reference;
                Text = text;
            }

            public static void ReadVerses()
            {
                TextFieldParser parser = new TextFieldParser("Typing to the Cross Verses.csv");

                parser.HasFieldsEnclosedInQuotes = true;
                parser.SetDelimiters(",");

                AllVerses.Clear();
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields[0].Contains("Tags")) continue;
                    Verse thisVerse = new Verse(fields[0].Split(',').Select(s => s.Trim()), fields[1], fields[2]);
                    AllVerses.Add(thisVerse);
                }
                parser.Close();
            }

            public static string GetVerse()
            {
                var thisVerse = SelectedVerses.FirstOrDefault();
                SelectedVerses.Remove(thisVerse);

                return thisVerse.Text;
            }

        }

        public Form1()
        {
            InitializeComponent();
            overworldPanel.Visible = false;
            combatPanel.Visible = false;
            mainMenuPanel.Visible = true;

            Verse.ReadVerses();
            foreach (var verse in AllVerses)
            {
                foreach (var tag in verse.Tags)
                {
                    if (!checkedListBox1.Items.Contains(tag))
                    {
                        checkedListBox1.Items.Add(tag);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check listBox to see which tags are selected,
            // and populate the verse list.
            SelectedVerses.Clear();
            foreach (var tag in checkedListBox1.CheckedItems)
            {
                SelectedVerses.AddRange(AllVerses.Where(x => x.Tags.Contains(tag.ToString())));
            }
            SelectedVerses.Shuffle();

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
                    
                    verseLabel.Text = Verse.GetVerse();
                    
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
