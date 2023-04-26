using UnityEngine;
using UnityTemplateProjects.General;

namespace UnityTemplateProjects.Player
{
    public class Weapon: MonoBehaviour, IDamager
    {
        [SerializeField] private WeaponData _weaponData;

        public WeaponData WeaponData => _weaponData;
        
        public void DoDamage(IDamageable damageable)
        {
            damageable.ReceiveDamage(_weaponData.Damage);
        }
    }
}