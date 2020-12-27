using UniRx;
using UnityEngine;

namespace Workshop.Scripts
{
    public class Character
    {
        public IntReactiveProperty _currentHp;
        public int                 _maxHp;

        public Character(int maxHp)
        {
            _maxHp     = maxHp;
            _currentHp = new IntReactiveProperty(_maxHp);
        }

        public int GetHp() => _currentHp.Value;

        public void TakeDamage(int amount)
        {
            if (IsNegativeNumber(amount)) return;
            _currentHp.Value -= amount;
            _currentHp.Value =  Mathf.Max(0 , _currentHp.Value);
        }

        public void Heal(int amount)
        {
            if (IsNegativeNumber(amount)) return;
            _currentHp.Value += amount;
            _currentHp.Value =  Mathf.Min(_maxHp , _currentHp.Value);
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