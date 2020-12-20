using NUnit.Framework;
using Workshop.Scripts;

namespace Tests
{
    public class HealthTests
    {
        [Test]
        public void Hp_Greater_Zero_When_Character_Spawn()
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