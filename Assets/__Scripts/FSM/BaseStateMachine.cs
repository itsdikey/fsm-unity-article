using UnityEngine;

namespace Demo.FSM
{
    public class BaseStateMachine : MonoBehaviour
    {
        public BaseState CurrentState { get; set; }

        private void Update()
        {
            CurrentState.Execute(this);
        }
    }
}