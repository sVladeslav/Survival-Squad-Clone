using System;

namespace UnityTemplateProjects.Player
{
    public class HealthSystem
    {
        public event Action OnHealthChanged;

        private float _maxHealth;
        private float _health;

        public HealthSystem(int maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
        }

        public float GetHealthPercent()
        {
            return (float) _health / _maxHealth;
        }
        
        public void Damage(float damageValue)
        {
            _health -= damageValue;
            if (_health < 0)
                _health = 0;
            
            OnHealthChanged?.Invoke();
        }

        public void Heal(float healValue)
        {
            _health += healValue;
            if (_health > _maxHealth)
                _health = _maxHealth;
            
            OnHealthChanged?.Invoke();
        }
    }
}