using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsability
{
    public class Game // mediator pattern
    {
        public IList<Creature> Creatures;
        public event EventHandler<Query> Queries; // effectively a chain

        private List<CreatureModifier> creatureModifiers = new List<CreatureModifier>();

        public Game()
        {
            this.Creatures = new List<Creature>();
        }

        public void AddCreature(Creature creature)
        {
            if (creature is GoblinKing)
            {
                creatureModifiers.Add(new GoblinKingModifier(this, creature));
            }
            else if (creature is Goblin)
            {
                creatureModifiers.Add(new GoblinModifier(this, creature));
            }
        }

        public void PerformQuery(object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }

}
