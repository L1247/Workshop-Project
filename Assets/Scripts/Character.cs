namespace Workshop.Scripts
{
    public class Character
    {
        private int _currentHp = 100;

        public int GetHp() => _currentHp;

        public void TakeDamage(int amount)
        {
            _currentHp -= amount;
        }

        public void Heal(int amount)
        {
            _currentHp += amount;
        }
    }
}