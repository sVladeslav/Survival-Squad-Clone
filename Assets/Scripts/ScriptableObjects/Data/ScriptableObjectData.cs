using UnityEngine;

namespace UnityTemplateProjects.ScriptableObjects.Data
{
    public class ScriptableObjectData: ScriptableObject, ISaveble
    {
        public virtual void Save()
        {
        }

        public virtual void Restore()
        {
        }
    }
}