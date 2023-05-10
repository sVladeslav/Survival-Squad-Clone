using System;
using UnityEngine;
using UnityTemplateProjects.PowerUp;

namespace UnityTemplateProjects.ScriptableObjects.Data
{
    [CreateAssetMenu(fileName = "ScriptableObjectFloat", menuName = "ScriptableObject/ScriptableObjectFloat")]
    public class ScriptableObjectFloat: ScriptableObjectData, IPowerable
    {
        public event Action<float> OnValueChenge;
        [SerializeField] private float _value;
        [SerializeField] private string _name;

        public float Value => _value;
        private void ChangeValue(float value)
        {
            _value = value;
            
            OnValueChenge?.Invoke(value);
        }

        public void IncreaseValue(float value)
        {
            ChangeValue( _value + value);
        }

        public void Decrease(float value)
        {
            ChangeValue(_value - value);
        }

        public override void Restore()
        {
            ChangeValue(PlayerPrefs.GetFloat(_name, 0));
        }
        
        public override void Save()
        {
            PlayerPrefs.SetFloat(_name, Value);
        }
    }
}