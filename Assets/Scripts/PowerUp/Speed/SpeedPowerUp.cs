using System;
using System.Threading.Tasks;
using UnityTemplateProjects.PowerUp.PowerUpData;
using UnityTemplateProjects.ScriptableObjects.Data;

namespace UnityTemplateProjects.PowerUp.Speed
{
    public class SpeedPowerUp: IPowerUp
    {
        public event Action OnDeactivated;

        private ScriptableObjectFloatValue _powerUpValue;
        public IPowerUpValue PowerUpValue => _powerUpValue;
        
        private ScriptableObjectFloat _powerable;
        public IPowerable Powerable => _powerable;
        

        private int activeSeconds = 3;
        
        
        public void Initialize(IPowerUpValue powerUpValue, IPowerable powerable)
        {
            _powerUpValue = powerUpValue as ScriptableObjectFloatValue;
            _powerable = powerable as ScriptableObjectFloat;
        }

        public void Activate(Action onActivated)
        {
            _powerable.IncreaseValue(_powerUpValue.Value);

            Task.Run(async () =>
            {
                await Task.Delay(activeSeconds * 1000);
                Deactivate();
                return 0;
            });
            
            onActivated?.Invoke();
        }

        public void Deactivate()
        {
            _powerable.Decrease(_powerUpValue.Value);
        }
    }
}