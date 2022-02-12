using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck123
{
    public class RedheadDuck : Duckk
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
    }
}
