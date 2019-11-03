using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.ChainOfResponsability;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ChainOfResponsabilityTest
    {
        [TestMethod]
        public void WhenOneGoblingIsCreatedThenGoblinDefenseIsDefaultOne()
        {
            //Arrange
            Game game = new Game();


            //Act.
            Creature goblinOne = new Goblin(game);

            //Assert.
            Assert.IsTrue(goblinOne.Attack == 1);
        }
        [TestMethod]
        public void WhenTwoGoblingsAreCreatedThenGoblinDefeneseIsModified()
        {
            //Arrange
            Game game = new Game();

            Creature goblinOne = new Goblin(game);
            Creature goblinTwo = new Goblin(game);

            //Act.

            game.AddCreature(goblinOne);
            game.AddCreature(goblinTwo);

            //Assert.
            Assert.IsFalse(goblinOne.Defense == 1);
            Assert.IsTrue(goblinOne.Defense == goblinTwo.Defense);
            Assert.IsTrue(goblinOne.Defense == 2); //As it has been modified!
        }
    }
}
