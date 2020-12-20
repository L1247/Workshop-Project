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

        [Test]
        public void Hp_Decrease_When_Character_TakeDamage()
        {
            // arrange
            var character = new Character();
            // act
            character.TakeDamage(7);
            var hp = character.GetHp();
            // assert
            Assert.AreEqual(93 , hp);
        }
    }
}