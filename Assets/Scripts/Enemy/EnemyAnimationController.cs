using UnityEngine;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyAnimationController: MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        private string _isRunningParameter = "isRunning";
        private string _isAttackingParameter = "isAttacking";
        
        private string _topBodyLayer = "Top body";
        
        private int _attackLayerIndex;

        
        private void Awake()
        {
            _attackLayerIndex = _animator.GetLayerIndex(_topBodyLayer);
        }
        
        public void PlayMovementAnimation(bool isRunning)
        {
            _animator.SetBool(_isRunningParameter, isRunning);
        }
        
        public void PlayAttackAnimation(bool isAttacking)
        {
            _animator.SetBool(_isAttackingParameter, isAttacking);
            
             _animator.SetLayerWeight(_attackLayerIndex, WeightFromBool(isAttacking));
        }
        
        private int WeightFromBool(bool state)
        {
            if (state)
                return 1;
            return 0;
        }
    }
}