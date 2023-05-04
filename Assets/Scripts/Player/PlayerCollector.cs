using System;
using System.Collections.Generic;
using UnityEngine;
using UnityTemplateProjects.Collectable;

namespace UnityTemplateProjects.Player
{
    public class PlayerCollector: MonoBehaviour, ICollector
    {
        private List<ICollectable> _collectables = new List<ICollectable>();
        public List<ICollectable> Collectables => _collectables;

        public void Collect(ICollectable collectable)
        {
            _collectables.Add(collectable);

            collectable.DoCollect();
        }

        private void OnTriggerEnter(Collider other)
        {
            var collectable = other.GetComponent<ICollectable>();
            if (collectable == null)
            {
                return;
            }

            Collect(collectable);
        }
    }
}