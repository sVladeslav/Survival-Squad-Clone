using UnityEngine;
using UnityEngine.AI;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyMovement: MonoBehaviour
    {
        private Transform _playerTarget;
        private NavMeshAgent _navMeshAgent;
        public bool IsMoving { get; set; }

        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }
        public void SetActiveMovement(bool isActive, Transform playerTransform)
        {
            _playerTarget = isActive ? playerTransform : null;
        }
        private void Update()
        {
            if (_playerTarget != null)
            {
                _navMeshAgent.SetDestination(_playerTarget.position);
            }
        }
    }
}