using RST.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBT.Test
{
    interface IRotatable : IUnit
    {
        Direction Direction { get; }
    }

    class RotateCommand : AbstractCommand<IRotatable>
    {
        protected override void ExecuteCommand(IRotatable unit)
        {
            Console.WriteLine($"Крутимся {unit.Direction}");
        }
    }
}
