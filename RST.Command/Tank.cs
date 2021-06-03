namespace RST.Command
{
    public class Tank : IUnit, IMovable, IFireble
    {
        public int Speed => 3;

        public int Damage => 2;
    }
}