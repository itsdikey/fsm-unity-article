using System.Collections.Generic;
using XNode;

namespace Demo.FSM.Graph
{
    public abstract class FSMNodeBase : Node
    {
        [Input(backingValue = ShowBackingValue.Never)] public FSMNodeBase Entry;

        protected List<T> GetAllOnPort<T>(string fieldName) where T : FSMNodeBase
        {
            List<T> results = new List<T>();
            NodePort port = GetOutputPort(fieldName);
            for (var portIndex = 0; portIndex < port.ConnectionCount; portIndex++)
            {
                results.Add(port.GetConnection(portIndex).node as T);
            }
            return results;
        }

        protected T GetFirst<T>(string fieldName) where T : FSMNodeBase
        {
            NodePort port = GetOutputPort(fieldName);
            if (port.ConnectionCount > 0)
                return port.GetConnection(0).node as T;
            return null;
        }
    }
}