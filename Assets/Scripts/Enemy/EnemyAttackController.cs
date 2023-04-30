using System;
using UnityEngine;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyAttackController : MonoBehaviour
    {
        public event Action<bool> OnAttack;

        private bool _isAttacking;
        private bool IsAttacking
        {
            get => _isAttacking;
            set
            {
                _isAttacking = value;
                OnAttack?.Invoke(_isAttacking);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if(!other.CompareTag(Constants.Tag.Player))
                return;
            
            IsAttacking = true;
        }

        private void OnTriggerExit(Collider other)
        {
            if(!other.CompareTag(Constants.Tag.Player))
                return;
            
            IsAttacking = false;
        }
    }
}