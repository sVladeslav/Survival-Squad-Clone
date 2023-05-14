using System;
using UnityTemplateProjects.PowerUp.PowerUpData;
using UnityTemplateProjects.ScriptableObjects.Data;

namespace UnityTemplateProjects.PowerUp.Damage
{
    public class DamagePowerUp: IPowerUp
    {
        private ScriptableObjectFloatValue _powerUpValue;
        public IPowerUpValue PowerUpValue => _powerUpValue;

        private ScriptableObjectFloat _powerable;
        public IPowerable Powerable => _powerable;
        public event Action OnDeactivated;
        public void Initialize(IPowerUpValue powerUpValue, IPowerable powerable)
        {
            throw new NotImplementedException();
        }

        public void Activate(Action onActivated)
        {
            throw new NotImplementedException();
        }
    }
}