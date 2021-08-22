using System.Linq;
using UnityEngine;
using XNode;

namespace Demo.FSM.Graph
{
    [CreateAssetMenu(menuName = "FSM/FSM Graph")]
    public sealed class FSMGraph : NodeGraph
    {
        private StateNode _initialState;

        public StateNode InitialState
        {
            get
            {
                if (_initialState != null)
                    return _initialState;

                var initialNode = nodes.FirstOrDefault(x => x is FSMInitialNode);
                if(initialNode!=null)
                {
                    _initialState = (initialNode as FSMInitialNode).NextNode;
                }
                return _initialState;
            }
        }
    }
}