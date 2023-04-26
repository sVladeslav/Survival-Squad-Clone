using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace UnityTemplateProjects.Player
{
    public class WeaponManager: MonoBehaviour
    {
        [SerializeField] private MultiParentConstraint ParentConstraint;

        [SerializeField] private Weapon[] _weapons;

        [SerializeField] private WeaponData _defaultWeapon;

        
        //todo: create initializating method to work with initional menu
        private void Awake()
        {
            DeactivateAllWeapons();
            
            SetActiveWeapon(_defaultWeapon);
        }

        public void DeactivateAllWeapons()
        {
            foreach (var weapon in _weapons)
            {
                weapon.gameObject.SetActive(false);
            }
        }

        public void SetActiveWeapon(WeaponData weaponData)
        {
            var weapon = _weapons.FirstOrDefault(x => x.WeaponData == weaponData);
            weapon?.gameObject.SetActive(true);
        }
        
        public void ChangeStateWeapon()
        {
            ParentConstraint.weight = ParentConstraint.weight == 1
                ? 0
                : 1;
        }
    }
}