using System;

namespace DesignPatterns.ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GOblinsss!");

            Game game = new Game();
            Creature goblinOne = new Goblin(game);

            // Console.WriteLine($"G-1 attack: {goblinOne.Attack} - defenese {goblinOne.Defense}");

            game.AddCreature(goblinOne);           

             Console.WriteLine($"G-1 attack: {goblinOne.Attack} - defenese {goblinOne.Defense}");

            Creature goblinTwo = new Goblin(game);
            Creature goblinThree = new Goblin(game);

            Creature GoblingKing = new GoblinKing(game);

            game.AddCreature(goblinTwo);
            game.AddCreature(goblinThree);

            // Console.WriteLine($"G-1 attack: {goblinOne.Attack} - defenese {goblinOne.Defense}");


            game.AddCreature(GoblingKing);

            Console.WriteLine($"G-1 attack: {goblinOne.Attack} - defenese {goblinOne.Defense}");
            Console.WriteLine($"G-2 attack: {goblinTwo.Attack} - defenese {goblinTwo.Defense}");
            Console.WriteLine($"G-3 attack: {goblinThree.Attack} - defenese {goblinThree.Defense}");
            Console.WriteLine($"G-K attack: {GoblingKing.Attack} - defenese {GoblingKing.Defense}");

        }
    }
}
