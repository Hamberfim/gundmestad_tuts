using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class DCCharacter : Character
    {
        public override string Run()
        {
            return "the DC character jumped 12 steps forward";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
