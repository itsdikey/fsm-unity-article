using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Demo.Enemy
{
    public class PatrolPoints : MonoBehaviour
    {
        [SerializeField] private Transform[] _patrolPoints;

        public Transform CurrentPoint => _patrolPoints[_currentPoint];

        private int _currentPoint = 0;

        /// <summary>
        /// Gets the next point to patrol to
        /// </summary>
        /// <returns></returns>
        public Transform GetNext()
        {
            var point = _patrolPoints[_currentPoint];
            _currentPoint = (_currentPoint + 1) % _patrolPoints.Length;
            return point;
        }

        /// <summary>
        /// Checks if destination reached
        /// </summary>
        /// <param name="agent"></param>
        /// <returns></returns>
        public bool HasReached(NavMeshAgent agent)
        {
            if (!agent.pathPending)
            {
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

