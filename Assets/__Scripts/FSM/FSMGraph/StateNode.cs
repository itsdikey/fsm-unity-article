using System.Collections.Generic;

namespace Demo.FSM.Graph
{
    [CreateNodeMenu("State")]
    public sealed class StateNode : BaseStateNode
    {
        public List<FSMAction> Actions;
        [Output] public List<TransitionNode> Transitions;

        public void Execute(BaseStateMachineGraph baseStateMachineGraph)
        {
            foreach (var action in Actions)
                action.Execute(baseStateMachineGraph);

            foreach (var transition in GetAllOnPort<TransitionNode>(nameof(Transitions)))
                transition.Execute(baseStateMachineGraph);
        }
    }
}
