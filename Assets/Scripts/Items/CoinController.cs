using System;
using UnityEngine;
using UnityTemplateProjects.Collectable;
using UnityTemplateProjects.ScriptableObjects.Data;

namespace UnityTemplateProjects.Items
{
    public class CoinController : MonoBehaviour, ICollectable
    {
        [SerializeField] private ScriptableObjectInt _coinCount;

        [SerializeField] private int _count;
        
        public void DoCollect()
        {
            _coinCount.ChangeValue(_coinCount.Value + _count);
            
            Destroy(gameObject);
        }

        private void Start()
        {
            _coinCount.RestoreValue();
        }

        private void OnDestroy()
        {
            _coinCount.SaveValue();
        }
    }
}