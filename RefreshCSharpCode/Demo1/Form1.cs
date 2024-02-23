using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // replacing all utilizing Auto-Implemented Properties using object initializer which is very flexible
            List<Character> myToons = new List<Character>();
            myToons.Add(new Character() { Name = "Bob", Age = 45, Level = 1, Weakness = "Thanksgiving Turkey" });
            myToons.Add(new Character() { Name = "Linda", Age = 45, Level = 1, Weakness = "Wine" });
            myToons.Add(new Character() { Name = "Tina", Age = 13, Level = 1, Weakness = "Zombie Fan Fiction" });
            myToons.Add(new Character() { Name = "Gene", Age = 11, Level = 1, Weakness = "the Lunch Lady" });
            myToons.Add(new Character() { Name = "Louise", Age = 9, Level = 1, Weakness = "Kuchi Kopi" });
            myToons.Add(new Character() { Name = "Mr. Fischoeder", Age = 65, Level = 1, Weakness = "Money" });
            myToons.Add(new Character() { Name = "Mort", Age = 55 });
            myToons.Add(new Character() { Name = "Teddy", Age = 51 });
            myToons.Add(new DCCharacter() { Name = "Superman", Weakness = "kryptonite" });
            myToons.Add(new MarvelCharacter() { Name = "Spider-Man" });

            // inheritance
            // List<MarvelCharacter> mCharacter = new List<MarvelCharacter>();
            // mCharacter.Add(new MarvelCharacter() {Name="Hulk", Weakness="Gas"});

            // polymorphism - an object will behave like the class it references/inherits from
            Character marvelCharacter = new MarvelCharacter();  // upcasting
            marvelCharacter.Name = "Hulk";

            Character dcCharacter = new DCCharacter();  // upcasting
            dcCharacter.Name = "Batman";

            // using auto-created default constructor
            //Character myCharacter = new Character();
            //Character yourCharacter = new Character();
            //myCharacter.setName("Bob");
            //myCharacter.setAge(45);
            //yourCharacter.setName("Tina");
            //yourCharacter.setAge(13);
            //label1.Text = myCharacter.getName() + " " + myCharacter.getAge();
            //label1.Text += "\n" + yourCharacter.getName() + " " + yourCharacter.getAge();

            // creating a List instead of calling the constructor for each character
            //List<Character> myToons = new List<Character>();
            ////// using the automatic/default  constructor
            //myToons.Add(new Character());  // will default to level zero because level doesn't have a value in the default constructor
            //myToons.Add(new Character());


            //myToons[0].setName("Bob");
            //myToons[0].setAge(45);

            //myToons[1].setName("Linda");
            //myToons[1].setAge(45);

            //// using Property instead of using Mutators(Setters)
            //myToons.Add(new Character());
            //myToons[2].Name = "Mr. Fischoeder";
            //myToons[2].Age = 65;
            //myToons[2].Level = 5;

            //// using the parametrized constructor
            //myToons.Add(new Character("Tina", 13));  // will default to level 1 because the param construct has a default value
            //myToons.Add(new Character("Gene", 11));
            //myToons.Add(new Character("Louise", 9, 5));

            //// using the Auto-Implemented Property
            //myToons[0].Weakness = "Thanksgiving Turkey";
            //myToons[1].Weakness = "Wine";
            //myToons[2].Weakness = "Greed";
            //myToons[3].Weakness = "Fan Fiction";
            //myToons[4].Weakness = "the Lunch Lady";
            //myToons[5].Weakness = "Kuchi Kopi";



            foreach (var character in myToons)
            {
                label1.Text += character.ToString();
            }

            label1.Text += "\n" + myToons[0] + myToons[0].Run() + "\n";
            label1.Text += "\n" + marvelCharacter + marvelCharacter.Run() + "\n";
            label1.Text += "\n" + dcCharacter + dcCharacter.Run() + "\n";

            // calls the run from the specific class that - the verb is dependent on the noun - Polymorphism
            doSomething(myToons[8]);  // DC(noun) Run(verb) - 12 steps
            doSomething(myToons[9]);  // Marvel(noun) Run(verb) - 10 steps


        }

        // outside of form load - what runs is specific to the class override of that Run() in its class
        public void doSomething(Character c)
        {
            label1.Text += "\n" + c + c.Run() + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CombatAction makeBattle = new CombatAction();
            label1.Text += makeBattle.EAbility();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CombatAction makeBattle = new CombatAction();
            label1.Text += makeBattle.QAbility();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CombatAction makeBattle = new CombatAction();
            label1.Text += makeBattle.RAbility();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // try/catch is to stop runtime crashes from occurring, an object oriented way of handling errors
            // try/catch can slow the software performance
            // traditional non-object oriented way of handling error is to use loops and if statements w/data validation
            CombatAction makeBattle = new CombatAction();
            try
            {
                label1.Text += makeBattle.WAbility();
            }
            catch(NotImplementedException error)
            {
                label1.Text += error.Message + " Button not functional!\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CombatAction makeBattle = new CombatAction();
            try
            {
                label1.Text += makeBattle.ZAbility();
            }
            // the parent class of all exception will catch this because the 'NotImplementedException' will be upcast to 'Exception'
            catch (Exception error)
            {
                // the custom message will need to be generic since you don't know what error you're catching
                label1.Text += error.Message + " something generic!\n";
            }
        }
    }
}
