using UnityEngine;

namespace Workshop.Scripts
{
    public class Character
    {
        private int _currentHp = 100;

        public int GetHp() => _currentHp;

        public void TakeDamage(int amount)
        {
            if (amount < 0) return;
            _currentHp -= amount;
            _currentHp =  Mathf.Max(0 , _currentHp);

        }

        public void Heal(int amount)
        {
            _currentHp += amount;
            _currentHp=Mathf.Min(100 , _currentHp);
        }
    }
}