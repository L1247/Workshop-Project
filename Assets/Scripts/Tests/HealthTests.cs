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
        public void Hp_Decrease_When_Character_TakeDamage()
        {
            _character.TakeDamage(7);
            HpShouldBe(93);
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