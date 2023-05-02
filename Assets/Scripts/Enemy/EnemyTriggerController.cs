using System;
using UnityEngine;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyTriggerController: MonoBehaviour
    {
        public event Action<bool, PlayerController> OnTriggerPlayer;
        private void OnTriggerEnter(Collider other)
        {
            if(!other.CompareTag(Constants.Tag.Player))
                return;
            
            OnTriggerPlayer?.Invoke(true, other.GetComponent<PlayerController>());
        }

        private void OnTriggerExit(Collider other)
        {
            if(!other.CompareTag(Constants.Tag.Player))
                return;
            
            OnTriggerPlayer?.Invoke(false, other.GetComponent<PlayerController>());
        }
    }
}