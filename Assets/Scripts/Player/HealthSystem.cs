using System;

namespace UnityTemplateProjects.Player
{
    public class HealthSystem
    {
        public event Action OnHealthChanged;

        private int _maxHealth;
        private int _health;

        public HealthSystem(int maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
        }

        public float GetHealthPercent()
        {
            return (float) _health / _maxHealth;
        }
        
        public void Damage(int damageValue)
        {
            _health -= damageValue;
            if (_health < 0)
                _health = 0;
            
            OnHealthChanged?.Invoke();
        }

        public void Heal(int healValue)
        {
            _health += healValue;
            if (_health > _maxHealth)
                _health = _maxHealth;
            
            OnHealthChanged?.Invoke();
        }
    }
}