using UnityEngine;

namespace Workshop.Scripts
{
    public class Character
    {
        private int _currentHp = 100;

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
            _currentHp =  Mathf.Min(100 , _currentHp);
        }

        private static bool IsNegativeNumber(int amount)
        {
            return amount < 0;
        }
    }
}