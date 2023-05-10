using System;
using UnityEngine;
using UnityTemplateProjects.PowerUp.PowerUpData;
using UnityTemplateProjects.ScriptableObjects.Data;

namespace UnityTemplateProjects.PowerUp.Speed
{
    public class SpeedPowerUpWorldView: PowerUpWorldView
    {
        [SerializeField] private ScriptableObjectFloatValue _powerUpValue;
        [SerializeField] private ScriptableObjectFloat _targetChangeValue;
        private void Awake()
        {
            _powerUp = new SpeedPowerUp();
            _powerUp.Initialize(_powerUpValue, _targetChangeValue);
        }
    }
}