using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.ChainOfResponsability;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ChainOfResponsabilityTest
    {
        [TestMethod]
        public void ValidateModifiers()
        {
            //Arrange
            Game game = new Game();

            Creature goblinOne = new Goblin(game);

            //Act.
            

            //Assert.
            Assert.IsTrue(goblinOne.Attack == 1);
        }
    }
}
