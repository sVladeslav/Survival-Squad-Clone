
using System;
using Unity.Mathematics;
using UnityEngine;
using UnityTemplateProjects.Player;
using UnityTemplateProjects.View;

public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerMoveController _playerMovement;

        [SerializeField] private PlayerAnimationController _animationController;
        
        [SerializeField] private PlayerAttackController _attackController;

        [SerializeField] private HealthBar _healthBarPrefab;

        private HealthSystem _healthSystem;
        
      
        public PlayerMoveController PlayerMovement => _playerMovement;
        
        private void OnEnable()
        {
            _playerMovement.OnPlayerMove += _animationController.PlayMovementAnimation;
            _attackController.OnAttack += _animationController.PlayAttackAnimation;

            var healthObject = Instantiate(_healthBarPrefab, new Vector3(0, 2.7f, 0), quaternion.identity, transform);
            var healthBar = healthObject.GetComponent<HealthBar>();

            _healthSystem = new HealthSystem(100);
            healthBar.Setup(_healthSystem);
        }

        private void OnDisable()
        {
            _playerMovement.OnPlayerMove -= _animationController.PlayMovementAnimation;
            _attackController.OnAttack -= _animationController.PlayAttackAnimation;
        }
    }