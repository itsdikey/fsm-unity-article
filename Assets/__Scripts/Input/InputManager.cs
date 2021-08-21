using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace Demo.Input
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputDelegator _inputDelegator;

        public void Move(CallbackContext callbackContext)
        {
            var moveVector = callbackContext.ReadValue<Vector2>();
            _inputDelegator.OnMove(moveVector);
        }

        public void PointerMove(CallbackContext callbackContext)
        {
            var pointerVector = callbackContext.ReadValue<Vector2>();
            _inputDelegator.OnPointerMove(pointerVector);
        }
    }
}
