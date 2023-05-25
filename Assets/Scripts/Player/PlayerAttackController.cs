using System;
using System.Collections.Generic;
using UnityEngine;
using UnityTemplateProjects.General;

namespace UnityTemplateProjects.Player
{
    public class PlayerAttackController: MonoBehaviour
    {
        [SerializeField] private WeaponManager _weaponManager;
         private List<IDamageable> _damageables = new List<IDamageable>();
        public event Action<bool> OnAttack;

        private int enemyCount;
        private int _enemyNearCounter
        {
            get => enemyCount;
            set
            {
                enemyCount = value;
                if (value == 0)
                {
                    IsAttacking = false;
                    _weaponManager.CurrentWeapon.SetActive(false);
                }
            }
        }

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

        private void OnDamagebleDie()
        {
            // if (_damageables.Contains(damageable))
            //     _damageables.Remove(damageable);
            _enemyNearCounter--;
        }
        private void OnTriggerEnter(Collider other)
        {
            var damageable = other.GetComponent<IDamageable>();

            if (damageable == null)
            {
                return;
            }
            _enemyNearCounter++; 
            damageable.OnDie += OnDamagebleDie;

            if (!_damageables.Contains(damageable))
            {
                _damageables.Add(damageable);
               
            }
            else
            {
                return;
            }

            Debug.Log($"+ {_damageables.Count}");
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

            if (_damageables.Contains(damageable))
            {
                _damageables.Remove(damageable);
            }

            Debug.Log($"- {_damageables.Count}");
            // if (_enemyNearCounter == 0)
            if (_damageables.Count == 0)
            {
                IsAttacking = false;
                _weaponManager.CurrentWeapon.SetActive(false);
            }
            
        }
    }
}