public class Goblin : Creature
{
    public Goblin(Game game) :base(game)
    {
        this.Name= nameof(Goblin);
        this.Attack = this.Defense = 1;        
    }
}