namespace Workshop.Scripts
{
    public class Character
    {
        private uint _currentHp = 100;

        public uint GetHp() => _currentHp;

        public void TakeDamage(uint amount)
        {
            _currentHp -= amount;
        }
    }
}