using NUnit.Framework;
using Workshop.Scripts;

namespace Tests
{
    public class HealthTests
    {
        [Test]
        public void Hp_Is_100_When_Character_Spawn()
        {
            // arrange
            var character = new Character();
            // act
            var hp            = character.GetHp();
            // assert
            Assert.AreEqual(100 , hp);
        }
    }
}