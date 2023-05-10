using UnityEngine;

namespace UnityTemplateProjects.PowerUp.PowerUpData
{
    [CreateAssetMenu(fileName = "ScriptableObjectFloatValue", menuName = "ScriptableObject/ScriptableObjectFloatValue")]
    public class ScriptableObjectFloatValue: ScriptableObject, IPowerUpValue
    {
        [SerializeField] private int _value;
        public int Value => _value;
    }
}