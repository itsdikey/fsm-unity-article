using UnityEngine;

namespace Demo.FSM
{
    public class BaseStateMachine : MonoBehaviour
    {
        [SerializeField] private BaseState _initialState;

        private void Awake()
        {
            CurrentState = _initialState;
        }

        public BaseState CurrentState { get; set; }

        private void Update()
        {
            CurrentState.Execute(this);
        }
    }
}