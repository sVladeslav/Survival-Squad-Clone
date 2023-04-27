using System;
using Unity.Mathematics;
using UnityEngine;
using UnityTemplateProjects.General;
using UnityTemplateProjects.Player;
using UnityTemplateProjects.View;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyController:MonoBehaviour, IDamageable
    {
        [SerializeField] private HealthBar _healthBarPrefab;

        private HealthSystem _healthSystem;

        private void Start()
        {
            var healthObject = Instantiate(_healthBarPrefab, new Vector3(0, 2.7f, 0), quaternion.identity, transform);
            var healthBar = healthObject.GetComponent<HealthBar>();

            _healthSystem = new HealthSystem(50);
            healthBar.Setup(_healthSystem);
        }

        public void ReceiveDamage(float damageValue)
        {
            _healthSystem.Damage(damageValue);
            
            if(_healthSystem.GetHealthPercent() == 0)
                Destroy(gameObject);
        }
    }
}