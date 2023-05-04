using System;
using UnityEngine;

namespace UnityTemplateProjects.Items
{
    public class RotateByY:MonoBehaviour
    {
        private int _speed = 50;

        private void Update()
        {
            transform.Rotate(0, _speed * Time.deltaTime, 0);
        }
    }
}