using UnityEngine;

namespace UnityTemplateProjects.UI.Screens
{
    public class Screen:MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;

        public void SetActive(bool isActive)
        {
            _canvasGroup.alpha = isActive ? 1 : 0;
            _canvasGroup.blocksRaycasts = isActive;
            _canvasGroup.interactable = isActive;
        }
    }
}