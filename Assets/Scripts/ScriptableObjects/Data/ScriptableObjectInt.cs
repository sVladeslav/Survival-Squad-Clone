using System;
using UnityEngine;

namespace UnityTemplateProjects.ScriptableObjects.Data
{
    [CreateAssetMenu(fileName = "ScriptableObjectInt", menuName = "ScriptableObject/ScriptableObjectInt")]
    public class ScriptableObjectInt: ScriptableObjectData
    {
        public event Action<int> OnValueChenge;
        [SerializeField] private int _value;
        [SerializeField] private string _name;

        public int Value => _value;
        public void ChangeValue(int value)
        {
            _value = value;
            
            OnValueChenge?.Invoke(value);
        }
        
        public override void Restore()
        {
            ChangeValue(PlayerPrefs.GetInt(_name, 0));
        }
        
        public override void Save()
        {
            PlayerPrefs.SetInt(_name, Value);
        }
    }
}