//TTTC main prototype by Joshua Wilfong
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TttC
{
    public partial class Form1 : Form
    {
        //declare verses
        //John 3:16
        const string john316 = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        //2 Corinthians 4:16
        const string corinthians416 = "Therefore we do not lose heart. Even though our outward man is perishing, yet the inward man is being renewed day by day.";
        //Proverbs 1:8-9
        const string proverbs18 = "Listen, my son, to your father's instruction and do not forsake your mother’s teaching. They are a garland to grace your head and a chain to adorn your neck.";
        
        string[] verseDatabase = new string[3] { john316, corinthians416, proverbs18 };
        
        public Form1()
        {
            InitializeComponent();
            overworldPanel.Visible = false;
            combatPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        double totalTime;
        double totalWords;
        double savedTotalTime;

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
                    double words;
                    double WPM;
                    timer1.Enabled = false;
                    words = totalWords / 5;
                    totalTime = totalTime / 60;
                    WPM = words / totalTime;
                    MessageBox.Show("You win! Your Words Per Minute = " + (int)WPM);
                }

                if (overworldCharacter.Location.X % 150 == 0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Encounter! Prepare for Battle!");
                    overworldPanel.Visible = false;
                    combatPanel.Visible = true;
                    verseLabel.Text = verseDatabase[(int)(new Random().Next(0, verseDatabase.Length))];
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
             savedTotalTime = totalTime;
             timer3.Enabled = true;
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
                timer3.Enabled = false;
                totalWords += textBox1.Text.Length;
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
                    totalTime = savedTotalTime;
                    timer2.Enabled = true;
                    textBox1.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    monster.Location = new Point(432, 86);
                    totalTime = savedTotalTime;
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            totalTime += 1;
        }
    }
}
 

