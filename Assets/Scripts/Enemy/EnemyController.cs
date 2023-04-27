﻿using System;
using Unity.Mathematics;
using UnityEngine;
using UnityTemplateProjects.General;
using UnityTemplateProjects.Player;
using UnityTemplateProjects.View;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyController:MonoBehaviour, IDamageable
    {
        [SerializeField] private EnemyAttackController _attackController;
        [SerializeField] private EnemyAnimationController _animationController;
        
        [SerializeField] private HealthBar _healthBar;

        private HealthSystem _healthSystem;

        private void Start()
        {
            _healthSystem = new HealthSystem(50);
            _healthBar.Setup(_healthSystem);
        }

        public void ReceiveDamage(float damageValue)
        {
            _healthSystem.Damage(damageValue);
            
            if(_healthSystem.GetHealthPercent() == 0)
                Destroy(gameObject);
        }
    }
}