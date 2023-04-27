using UnityEngine;
using UnityTemplateProjects.Player;

namespace UnityTemplateProjects.View
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Transform pfHealthBar;


        private Transform _cameraTransform;

        private HealthSystem _heathSystem;

        public void Setup(HealthSystem healthSystem)
        {
            _heathSystem = healthSystem;

            _heathSystem.OnHealthChanged += HeathSystem_OnChangeHealth;
        }

        private void HeathSystem_OnChangeHealth()
        {
            pfHealthBar.localScale = new Vector3(_heathSystem.GetHealthPercent(), 1);
        }

        private void Start()
        {
            _cameraTransform = Camera.main.transform;
        }

        private void Update()
        {
            transform.LookAt(new Vector3(_cameraTransform.position.x, transform.position.y, _cameraTransform.position.z));
        }
    }
}