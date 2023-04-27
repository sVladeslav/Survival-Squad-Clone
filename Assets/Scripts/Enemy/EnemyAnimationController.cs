using UnityEngine;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyAnimationController: MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        
        private string _isRunningParameter = "isRunning";
        private string _isAttackingParameter = "isAttacking";

        public void PlayMovementAnimation(bool isRunning)
        {
            _animator.SetBool(_isRunningParameter, isRunning);
        }
        
        public void PlayAttackAnimation(bool isAttacking)
        {
            _animator.SetBool(_isAttackingParameter, isAttacking);
            
            // _animator.SetLayerWeight(_attackLayerIndex, WeightFromBool(isAttacking));
        }
        
    }
}