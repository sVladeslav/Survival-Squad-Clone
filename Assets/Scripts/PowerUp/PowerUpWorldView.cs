using System;
using UnityEngine;
using UnityTemplateProjects.PowerUp.PowerUpData;
using UnityTemplateProjects.PowerUp.Speed;
using UnityTemplateProjects.ScriptableObjects.Data;

namespace UnityTemplateProjects.PowerUp
{
    public class PowerUpWorldView: MonoBehaviour
    {
        [SerializeField] private PowerUpType Type;
        [SerializeField] private ScriptableObjectFloatValue _powerUpValue;
        [SerializeField] private ScriptableObjectFloat _targetChangeValue;
    
        private IPowerUp _powerUp;
        public virtual IPowerUp PowerUp => _powerUp;
        
        private void Awake()
        {
            switch (Type)
            {
                case PowerUpType.Speed:
                    _powerUp = new SpeedPowerUp();
                    break;
                case PowerUpType.Damage:
                    break;
                case PowerUpType.Health:
                    break;
            }
            
            _powerUp.Initialize(_powerUpValue, _targetChangeValue);
        }

    }
}