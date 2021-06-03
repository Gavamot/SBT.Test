using RST.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBT.Test
{
    class Helicopter : IRotatable, IMovable
    {
        public int Speed => 5;

        public Direction Direction => Direction.Down;
    }
}
