using System;
using System.Collections.Generic;
using System.Text;

namespace RST.Command
{
    public class Car : IUnit, IMovable, IFireble
    {
        public int Speed => 2;

        public int Damage => 1;
    }
}
