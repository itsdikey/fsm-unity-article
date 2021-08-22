using UnityEngine;

namespace Demo.FSM
{
    public abstract class Decision : ScriptableObject
    {
        public abstract bool Decide(BaseStateMachine state);
    }
}