// using System;
// using UnityTemplateProjects.ScriptableObjects.Data;
//
// namespace UnityTemplateProjects.PowerUp.Health
// {
//     public class HealthPowerUp: IPowerUp<float, ScriptableObjectFloat>
//     { 
//         public event Action OnDeactivated;
//         private float _powerUpData;
//         private ScriptableObjectFloat _targetChangeData;
//
//         public float PowerUpData => _powerUpData;
//         public ScriptableObjectFloat TargetChangeData => _targetChangeData;
//        
//         public void Initialize(float powerUpData, ScriptableObjectFloat targetChangeData)
//         {
//             _powerUpData = powerUpData;
//             _targetChangeData = targetChangeData;
//         }
//
//         public void Activate()
//         {
//             TargetChangeData.IncreaseValue(PowerUpData);
//         }
//
//         public void Deactivate()
//         {
//         }
//     }
// }