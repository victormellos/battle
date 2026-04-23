using System;

namespace battle
{
    public class Entity
    {
        public int MaxHealth { get; }
        public int Health { get; private set; }

        public bool IsAlive => Health > 0;

        public event Action<int> OnDamaged;
        public event Action OnDeath;

        public Entity(int maxHealth)
        {
            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        public void takeDamage(int amount)
        {
            if (!IsAlive) return;

            Health -= amount;

            if (Health < 0)
                Health = 0;

            OnDamaged?.Invoke(amount);

            if (Health == 0)
                OnDeath?.Invoke();
        }

        public void Heal(int amount)
        {
            if (!IsAlive) return;

            Health += amount;

            if (Health > MaxHealth)
                Health = MaxHealth;
        }
    }
}