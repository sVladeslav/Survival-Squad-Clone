using UnityEngine;
using UnityTemplateProjects.General;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyController:MonoBehaviour, IDamageable
    {
        [SerializeField] private float hp = 20f;
        public void ReceiveDamage(float damageValue)
        {
            hp -= damageValue;
            if(hp<=0)
                Destroy(gameObject);
        }
    }
}