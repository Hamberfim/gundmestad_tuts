using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Demo1
{
    // access modifier
    // public, internal, protected, private
 // terrible class name | this could be changed to an Abstract class from witch you can't create an object from but must use inheritance is a child class
    public class Character
    {
        // DATA replacing all with Auto-Implemented Properties
        public string Name { get; set; }
        public int Age { get; set; } = -1;
        public int Level { get; set; } = 1;
        public string Weakness { get; set; } = "'unknown'";

        // data - Instance Field -  the data your working with
        //private string _name;
        //private int _age;
        //private int _level;

        //// Use Property instead of using Mutators(Setters) & Accessors(Getters)
        //public string Name
        //{
        //    // get is the read block
        //    get { return _name; }
        //    // set is the write block
        //    set { _name = value; }
        //}

        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}

        //public int Level
        //{
        //    get { return _level; }
        //    set
        //    {
        //        if (value < 0 || value > 100)
        //        {
        //            _level = 1;
        //        }
        //        else
        //        {
        //            _level = value;
        //        }
        //    }
        //}

        //// use an Auto-Implemented Property (shorthand) and DOES NOT require an Instance field
        //public string Weakness { get; set; }  // can't use conditions that validate the data

        //// METHODS
        //// method: A Constructor - is a method that is called when an object is initialized into RAM (a default constructor is already available)
        //// Once you have create a parametrized constructor you have to create a default one - basically creating two constructors, one overloaded constructor
        //// this is now the default constructor
        //public Character() { }  // now the default constructor
        //// parameterized Constructor  -- (i.e., overloaded method)
        //public Character(string name, int age, int level = 1)
        //{
        //    this._name = name;
        //    this._age = age;
        //    this._level = level;
        //}

        //// method: Mutators - setters
        //// name parameter
        //public void setName(string name)
        //{
        //    // instance field _name equals the name parameter
        //    this._name = name;
        //}

        //// age parameter
        //public void setAge(int age)
        //{
        //    // instance field _age equals the age parameter
        //    this._age = age;
        //}

        //// method: Accessors - getters
        //public string getName()
        //{
        //    return this._name;  // return the instance field _name
        //}

        //public int getAge()
        //{
        //    return this._age;  // return the instance field _age
        //}

        // method: ToString()  // overrides the base ToString

        public virtual string Run() { return "ran 3 steps forward"; }

        public override string ToString()
        {
            // return $"{_name} is {_age} years old, level {_level} and has a weakness of {Weakness}.\n";
            return $"{Name} is {Age} years old, level {Level} and has a weakness for {Weakness}.\n";
        }
    }
}
