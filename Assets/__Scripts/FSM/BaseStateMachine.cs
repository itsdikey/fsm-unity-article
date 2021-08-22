using UnityEngine;

namespace Demo.FSM
{
    public class BaseStateMachine : MonoBehaviour
    {
        [SerializeField] private BaseState _initialState;

        private void Awake()
        {
            Init();
        }

        public BaseState CurrentState { get; set; }

        private void Update()
        {
            Execute();
        }

        public virtual void Init()
        {
            CurrentState = _initialState;
        }

        public virtual void Execute()
        {
            CurrentState.Execute(this);
        }
    }
}