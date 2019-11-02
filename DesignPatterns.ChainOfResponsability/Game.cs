using System;
using System.Collections.Generic;

public class Game // mediator pattern
{
    private IList<Creature> Creatures;
    public event EventHandler<Query> Queries; // effectively a chain

    public Game()
    {
        this.Creatures = new List<Creature>();
    }

    public void AddCreature(Creature creature)
    {
        if(creature.Name == nameof(Goblin))
        {
            using(var goblinModifier = new GoblinModifier(this,creature))
            {

            }
        }
        else if(creature.Name == nameof(GoblinKing))
        {
            using(var goblinModifier = new GoblinKingModifier(this,creature))
            {

            }

        }
    }

    public void PerformQuery(object sender, Query q)
    {
        Queries?.Invoke(sender, q);
    }
}