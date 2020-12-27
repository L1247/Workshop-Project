using UnityEngine;

namespace Workshop.Scripts
{
    public class Character
    {
        private int _currentHp ;
        private int _maxHp;

        public Character(int maxHp)
        {
            _maxHp     = maxHp;
            _currentHp = _maxHp;
        }

        public int GetHp() => _currentHp;

        public void TakeDamage(int amount)
        {
            if (IsNegativeNumber(amount)) return;
            _currentHp -= amount;
            _currentHp =  Mathf.Max(0 , _currentHp);
        }

        public void Heal(int amount)
        {
            if (IsNegativeNumber(amount)) return;
            _currentHp += amount;
            _currentHp =  Mathf.Min(_maxHp , _currentHp);
        }

        private static bool IsNegativeNumber(int amount)
        {
            return amount < 0;
        }

        public void SetMaxHp(int amount)
        {
            _maxHp = amount;
        }
    }
}