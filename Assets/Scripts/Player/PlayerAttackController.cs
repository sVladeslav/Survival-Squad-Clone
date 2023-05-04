using System;
using UnityEngine;
using UnityTemplateProjects.General;

namespace UnityTemplateProjects.Player
{
    public class PlayerAttackController: MonoBehaviour
    {
        [SerializeField] private WeaponManager _weaponManager;
        public event Action<bool> OnAttack;
       
        private int _enemyNearCounter = 0;

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
        private void OnTriggerEnter(Collider other)
        {
            var damageable = other.GetComponent<IDamageable>();

            if (damageable == null)
            {
                return;
            }

            _enemyNearCounter++;
            IsAttacking = true;
            _weaponManager.CurrentWeapon.SetActive(true);
        }

        private void OnTriggerExit(Collider other)
        {
            var damageable = other.GetComponent<IDamageable>();

            if (damageable == null)
            {
                return;
            }
            
            if (_enemyNearCounter > 0)
            {
                _enemyNearCounter--;
            }
            else 
            {
                _enemyNearCounter = 0;
            }

            if (_enemyNearCounter == 0)
            {
                IsAttacking = false;
                _weaponManager.CurrentWeapon.SetActive(false);
            }
            
        }
    }
}