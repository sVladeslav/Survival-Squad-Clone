using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using UnityTemplateProjects.General;
using UnityTemplateProjects.Player;
using UnityTemplateProjects.View;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyController:MonoBehaviour, IDamageable
    {
        public event Action OnDie;
        [SerializeField] private EnemyAttackController _attackController;
        [SerializeField] private EnemyMovement _movementController;
        [SerializeField] private EnemyAnimationController _animationController;
        [SerializeField] private EnemyTriggerController _triggerController;
        [SerializeField] private Transform _playerTarget;

        [SerializeField] private HealthBar _healthBar;

        private HealthSystem _healthSystem;

        private void Start()
        {
            _healthSystem = new HealthSystem(50);
            _healthBar.Setup(_healthSystem);

            _attackController.OnAttack += _animationController.PlayAttackAnimation;
            _triggerController.OnTriggerPlayer += DetectPlayerTrigger;
            
            _movementController.SetActiveMovement(true, _playerTarget);
        }

        private void DetectPlayerTrigger(bool isEntered, PlayerController player)
        {
            _attackController.IsAttacking = isEntered;
            _movementController.SetActiveMovement(!isEntered, player.transform);
        }

        public void ReceiveDamage(float damageValue)
        {
            _healthSystem.Damage(damageValue);
            
            if(_healthSystem.GetHealthPercent() == 0)
                Destroy(gameObject);
        }

        private void OnDestroy()
        {
            OnDie?.Invoke();
            _attackController.OnAttack -= _animationController.PlayAttackAnimation;
        }
    }
}