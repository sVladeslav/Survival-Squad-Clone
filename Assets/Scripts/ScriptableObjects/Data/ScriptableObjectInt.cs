using System;
using UnityEngine;

namespace UnityTemplateProjects.ScriptableObjects.Data
{
    [CreateAssetMenu(fileName = "ScriptableObjectInt", menuName = "ScriptableObject/ScriptableObjectInt")]
    public class ScriptableObjectInt: ScriptableObject
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
        
        public void RestoreValue()
        {
            _value = PlayerPrefs.GetInt(_name, 0);
        }
        
        public void SaveValue()
        {
            PlayerPrefs.SetInt(_name, Value);
        }
    }
}