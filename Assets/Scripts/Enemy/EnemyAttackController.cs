using System;
using UnityEngine;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyAttackController : MonoBehaviour
    {
        public event Action<bool> OnAttack;

        private bool _isAttacking;
        public bool IsAttacking
        {
            get => _isAttacking;
            set
            {
                _isAttacking = value;
                OnAttack?.Invoke(_isAttacking);
            }
        }
    }
}