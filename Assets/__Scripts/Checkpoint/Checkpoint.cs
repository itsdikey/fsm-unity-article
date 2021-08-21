using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Checkpoint
{
    public class Checkpoint : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(this.gameObject);
        }
    }
}

