using Demo.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputDelegator _inputDelegator;
        [SerializeField] private CharacterController _characterController;
        [Range(0, 10), SerializeField] private float _movementSpeed;
        [Range(1, 50), SerializeField] private float _rotationSpeed;

        public void Awake()
        {
            _inputDelegator.Move2D += _inputDelegator_Move2D;
            _inputDelegator.PointerMove += _inputDelegator_PointerMove;
        }



        private float _forward;

        private float _right;

        private void _inputDelegator_Move2D(Vector2 value)
        {
            _forward = value.y;
            _right = value.x;
        }

        private void _inputDelegator_PointerMove(Vector2 value)
        {
            _characterController.transform.Rotate(new Vector3(0, value.x * _rotationSpeed * Time.deltaTime,0));
        }

        public void FixedUpdate()
        {
            _characterController.Move((_forward  * this.transform.forward + _right * this.transform.right) * _movementSpeed * Time.deltaTime);
        }

        
    }

}