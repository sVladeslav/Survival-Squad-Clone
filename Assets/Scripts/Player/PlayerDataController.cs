using UnityEngine;
using UnityEngine.Serialization;
using UnityTemplateProjects.ScriptableObjects.Data;

namespace UnityTemplateProjects.Player
{
    public class PlayerDataController: MonoBehaviour
    {
        [SerializeField] private ScriptableObjectData[] _datas;
        private void Start()
        {
            foreach (var data in _datas)
            {
                data.Restore();
            }
        }

        private void OnDestroy()
        {
            foreach (var data in _datas)
            {
                data.Save();
            }
        }
    }
}