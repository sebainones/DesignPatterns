namespace DesignPatterns.ChainOfResponsability
{
    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game)
        {
            this.attack = 3;
            this.defense = 3;
            this.Name = nameof(Goblin);
        }
    }
}
