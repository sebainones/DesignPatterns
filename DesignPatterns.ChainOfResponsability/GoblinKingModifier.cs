public class GoblinKingModifier : CreatureModifier
{
    public GoblinKingModifier(Game game, Creature creature) : base(game, creature)
    {
    }

    protected override void Handle(object sender, Query q)
    {
        if (q.CreatureName == creature.Name &&
            q.WhatToQuery == Query.Argument.Attack &&
            !(sender is GoblinKing))
        {
            q.Value += 1;
        }

    }
}