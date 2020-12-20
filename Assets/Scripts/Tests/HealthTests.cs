using NUnit.Framework;
using Workshop.Scripts;

namespace Tests
{
    public class HealthTests
    {
    #region Private Variables

        private Character _character;

    #endregion

    #region Setup/Teardown Methods

        [SetUp]
        public void SetUp()
        {
            _character = new Character();
        }

    #endregion

    #region Test Methods

        [Test]
        public void Hp_Is_100_When_Character_Spawn()
        {
            HpShouldBe(100);
        }

        [Test]
        [TestCase(7,93)]
        [TestCase(101,-1)]
        [TestCase(-6,106)]
        public void Hp_Decrease_When_Character_TakeDamage(int amount , int expected)
        {
            _character.TakeDamage(amount);
            HpShouldBe(expected);
        }

        [Test]
        [TestCase(8 , 100)]
        public void Hp_Have_MaxValue_When_Character_Heal_Then_Hp_Increase(int amount , int expected)
        {
            _character.Heal(amount);
            HpShouldBe(expected);
        }


    #endregion

    #region Private Methods

        private void HpShouldBe(int expected)
        {
            Assert.AreEqual(expected , _character.GetHp());
        }

    #endregion
    }
}