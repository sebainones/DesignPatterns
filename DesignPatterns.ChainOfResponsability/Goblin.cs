namespace DesignPatterns.ChainOfResponsability
{
    public class Goblin : Creature
    {
        public Goblin(Game game) : base(game)
        {
            this.attack = 1;
            this.defense = 1;
            this.Name = nameof(Goblin);
        }
    }
}