using UnityEngine;

namespace UnityTemplateProjects.Player
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "ScriptableObject/WeaponData")]
    public class WeaponData:ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private float _damage;

        public string Name => _name;
        public float Damage => _damage;
    }
}