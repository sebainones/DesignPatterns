using System;

public abstract class Creature
{
    private Game game;
    public string Name;
    protected int attack, defense;

    public Creature(Game game)
    {
        this.game = game ?? throw new ArgumentNullException(paramName: nameof(game));    
    }

    public int Attack
    {
        get
        {
            var q = new Query(Name, Query.Argument.Attack, attack);
            game.PerformQuery(this, q);
            return q.Value;
        }

        set
        {
            var q = new Query(Name, Query.Argument.Attack, attack);
            game.PerformQuery(this, q);
            q.Value = attack;
        }
    }

    public int Defense
    {
        get
        {
            var q = new Query(Name, Query.Argument.Defense, defense);
            game.PerformQuery(this, q);
            return q.Value;
        }
        set
        {
            var q = new Query(Name, Query.Argument.Defense, defense);
            game.PerformQuery(this, q);
            q.Value = defense;
        }
    }

    public override string ToString() // no game
    {
        return $"{nameof(Name)}: {Name}, {nameof(attack)}: {Attack}, {nameof(defense)}: {Defense}";
    }
}