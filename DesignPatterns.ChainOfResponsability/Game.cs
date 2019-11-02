using System.Collections.Generic;

public class Game
{
    public IList<Creature> Creatures;
    public IList<Query> Queries { get; internal set; }
}