
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

        [SerializeField] private HealthBar _healthBar;

        private HealthSystem _healthSystem;
        
      
        public PlayerMoveController PlayerMovement => _playerMovement;
        
        private void OnEnable()
        {
            _playerMovement.OnPlayerMove += _animationController.PlayMovementAnimation;
            _attackController.OnAttack += _animationController.PlayAttackAnimation;
            
            _healthSystem = new HealthSystem(100);
            _healthBar.Setup(_healthSystem);
        }

        private void OnDisable()
        {
            _playerMovement.OnPlayerMove -= _animationController.PlayMovementAnimation;
            _attackController.OnAttack -= _animationController.PlayAttackAnimation;
        }
    }