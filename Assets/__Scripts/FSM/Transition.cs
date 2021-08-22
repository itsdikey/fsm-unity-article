using UnityEngine;

namespace Demo.FSM
{
    [CreateAssetMenu(menuName = "FSM/Transition")]
    public sealed class Transition : ScriptableObject
    {
        public Decision Decision;
        public BaseState TrueState;
        public BaseState FalseState;

        public void Execute(BaseStateMachine stateMachine)
        {
            if(Decision.Decide(stateMachine))
                stateMachine.CurrentState = TrueState;
            else
                stateMachine.CurrentState = FalseState;
        }
    }
}
