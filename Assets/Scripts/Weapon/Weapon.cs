using System;
using UnityEngine;
using UnityTemplateProjects.General;

namespace UnityTemplateProjects.Player
{
    public class Weapon: MonoBehaviour, IDamager
    {
        [SerializeField] private WeaponData _weaponData;

        [SerializeField] private Collider[] _colliders;

        public WeaponData WeaponData => _weaponData;

        private void Awake()
        {
            SetActive(false);
        }

        public void DoDamage(IDamageable damageable)
        {
            damageable.ReceiveDamage(_weaponData.Damage);
        }

        public void SetActive(bool isActive)
        {
            foreach (var collider in _colliders)
            {
                collider.enabled = isActive;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            var damageable = other.GetComponent<IDamageable>();

            if (damageable == null)
            {
                return;
            }

            DoDamage(damageable);
        }
    }
}