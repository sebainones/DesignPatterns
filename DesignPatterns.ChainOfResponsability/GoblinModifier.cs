 public class GoblinModifier : CreatureModifier
  {
    public GoblinModifier(Game game, Creature creature) : base(game, creature)
    {
    }

    protected override void Handle(object sender, Query q)
    {
      if (q.CreatureName == creature.Name &&
          q.WhatToQuery == Query.Argument.Defense)
        q.Value += 1;
    }
  }