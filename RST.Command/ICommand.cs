using System;

namespace RST.Command
{
    
    public interface ICommand
    {
        void Execute(IUnit unit);

    }

    // Возможно придется поменять интерфейсы 
    public interface IMovable : IUnit 
    {
        int Speed { get; }
    }

    public interface IFireble : IUnit
    {
        int Damage { get; }
    }

    public abstract class AbstractCommand<T> : ICommand where T : IUnit
    {
        public void Execute(IUnit unit)
        {
            if(unit is T) ExecuteCommand((T)unit);
        }

        protected abstract void ExecuteCommand(T unit);
    }
       

    public class MoveCommand : AbstractCommand<IMovable>
    {
        protected override void ExecuteCommand(IMovable unit)
        {
            Console.WriteLine($"Двигаем объект {unit.Speed}");
        }
    }

    public class FireCommand : AbstractCommand<IFireble>
    {
        protected override void ExecuteCommand(IFireble unit)
        {
            Console.WriteLine($"Стреляем {unit.Damage}");
        }
    }
}