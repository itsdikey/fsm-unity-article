using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Enemy
{
    public class EnemySightSensor : MonoBehaviour
    {
        public Transform Player { get; private set; }

        [SerializeField] private LayerMask _ignoreMask;

        private Ray _ray;

        private void Awake()
        {
            Player = GameObject.Find("Player").transform;
        }

        public bool Ping()
        {
            if (Player == null)
                return false;

            _ray = new Ray(this.transform.position, Player.position-this.transform.position);

            if (!Physics.Raycast(_ray, out var hit, 100, ~_ignoreMask))
            {
                return false;
            }
            
            if(hit.collider.tag == "Player")
            {
                return true;
            }

            return false;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(_ray.origin, _ray.origin + _ray.direction * 100);
        }
    }
}
