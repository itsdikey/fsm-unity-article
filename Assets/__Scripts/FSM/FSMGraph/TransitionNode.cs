namespace Demo.FSM.Graph
{
    [CreateNodeMenu("Transition")]
    public class TransitionNode : FSMNodeBase
    {
        public Decision Decision;

        [Output] public BaseStateNode TrueState;

        [Output] public BaseStateNode FalseState;

        public void Execute(BaseStateMachineGraph stateMachine)
        {
            var trueState = GetFirst<BaseStateNode>(nameof(TrueState));
            var falseState = GetFirst<BaseStateNode>(nameof(FalseState));
            if (Decision.Decide(stateMachine) && !(trueState is RemainInStateNode))
            {
                stateMachine.CurrentState = trueState;
            }
            else if(!(falseState is RemainInStateNode))
                stateMachine.CurrentState = falseState;
        }
    }
}