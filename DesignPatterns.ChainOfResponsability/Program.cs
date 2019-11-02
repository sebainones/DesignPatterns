using System;

namespace DesignPatterns.ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Game game = new Game();
            Creature goblinOne = new Goblin(game);

            Console.WriteLine(goblinOne.Attack);
            
            Creature goblinTwo = new Goblin(game);
            Creature goblinThree = new Goblin(game);

            game.AddCreature(goblinOne);
            game.AddCreature(goblinTwo);
            game.AddCreature(goblinThree);

            Console.WriteLine(goblinOne.Attack);
        }
    }
}
