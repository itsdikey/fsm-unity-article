using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Demo.Input
{
    [CreateAssetMenu(menuName = "Demo/Input Delegator")]
    public class InputDelegator : ScriptableObject
    {
        public event Action<Vector2> Move2D;
        public event Action<Vector3> Move3D;
        public event Action<Vector2> PointerMove;

        public void OnMove(Vector2 movement)
        {
            Move2D?.Invoke(movement);
            var movement3d = new Vector3(movement.x, 0, movement.y);
            Move3D?.Invoke(movement3d);
        }

        public void OnPointerMove(Vector2 pointerMove)
        {
            PointerMove?.Invoke(pointerMove);
        }
    }
}
