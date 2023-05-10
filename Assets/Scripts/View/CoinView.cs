using System;
using UnityEngine;
using UnityEngine.UI;
using UnityTemplateProjects.ScriptableObjects.Data;

namespace UnityTemplateProjects.View
{
    public class CoinView: MonoBehaviour
    {
        [SerializeField] private ScriptableObjectInt _coin;
        [SerializeField] private Text _text;

        private void OnEnable()
        {
            _coin.OnValueChenge += OnChangeValueHandler;
        }

        private void OnDisable()
        {
            _coin.OnValueChenge -= OnChangeValueHandler;
        }

        private void OnChangeValueHandler(int value)
        {
            _text.text = $"Coin: {value}";
        }

  
    }
}