
using UnityEngine;

    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private MoveByPhysicsJoysticController _playerMovement;

        [SerializeField] private PlayerAnimationController _animationController;
        
      
        public MoveByPhysicsJoysticController PlayerMovement => _playerMovement;
        
        private void OnEnable()
        {
            _playerMovement.OnPlayerMove += _animationController.PlayMovementAnimation;
        }

        private void OnDisable()
        {
            _playerMovement.OnPlayerMove -= _animationController.PlayMovementAnimation;
        }
    }