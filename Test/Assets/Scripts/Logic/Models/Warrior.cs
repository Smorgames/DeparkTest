using System;

namespace Logic.Models
{
    public abstract class Warrior
    {
        public Action OnDead;

        public float Speed { get; set; }
        public float MaxHp { get; set; }
    
        private float _currentHp;

        public virtual void TakeDamage(float damage)
        {
            _currentHp -= damage;
        
            if (_currentHp <= 0)
                OnDead?.Invoke();
        }
    }
}