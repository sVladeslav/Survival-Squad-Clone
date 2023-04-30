using UnityEngine;
using UnityEngine.AI;

namespace UnityTemplateProjects.Enemy
{
    public class EnemyMovement: MonoBehaviour
    {
        [SerializeField] private Transform _playerTarget;
        
        
        private NavMeshAgent _navMeshAgent;
        
        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }
        
        private void Update()
        {
            _navMeshAgent.SetDestination(_playerTarget.position);
        }
    }
}