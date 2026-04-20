namespace Battle
{
    public class Entity
    {
        public int MaxHealth { get; private set; }
        public int Health { get; private set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public bool IsAlive => Health > 0;

        public Entity(int maxHealth, int attack, int defense)
        {
            MaxHealth = maxHealth;
            Health = maxHealth;
            Attack = attack;
            Defense = defense;
        }

        public void TakeDamage(int damage)
        {
            int finalDamage = damage - Defense;

            if (finalDamage < 1)
                finalDamage = 1;

            Health -= finalDamage;

            if (Health < 0)
                Health = 0;
        }

        public void Heal(int amount)
        {
            Health += amount;

            if (Health > MaxHealth)
                Health = MaxHealth;
        }

    }
}