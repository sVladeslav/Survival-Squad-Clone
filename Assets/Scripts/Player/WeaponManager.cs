using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace UnityTemplateProjects.Player
{
    public class WeaponManager: MonoBehaviour
    {
        [SerializeField] private MultiParentConstraint ParentConstraint;

        public void ChangeStateWeapon()
        {
            ParentConstraint.weight = ParentConstraint.weight == 1
                ? 0
                : 1;
        }
    }
}