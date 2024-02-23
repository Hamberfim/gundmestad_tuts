using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class MarvelCharacter : Character
    {
        public override string Run()
        {
            return "the Marvel character leaped 10 steps forward";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
