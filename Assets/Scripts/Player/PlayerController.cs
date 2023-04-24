
using UnityEngine;
using UnityTemplateProjects.Player;

public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerMoveController _playerMovement;

        [SerializeField] private PlayerAnimationController _animationController;
        
        [SerializeField] private PlayerAttackController _attackController;
        
      
        public PlayerMoveController PlayerMovement => _playerMovement;
        
        private void OnEnable()
        {
            _playerMovement.OnPlayerMove += _animationController.PlayMovementAnimation;
            _attackController.OnAttack += _animationController.PlayAttackAnimation;
        }

        private void OnDisable()
        {
            _playerMovement.OnPlayerMove -= _animationController.PlayMovementAnimation;
            _attackController.OnAttack -= _animationController.PlayAttackAnimation;
        }
    }