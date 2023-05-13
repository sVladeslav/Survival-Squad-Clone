using System;

namespace UnityTemplateProjects.General
{
    public interface IDamageable
    {
        event Action OnDie;
        void ReceiveDamage(float damageValue);
    }
}