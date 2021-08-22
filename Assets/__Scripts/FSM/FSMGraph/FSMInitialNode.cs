using XNode;

namespace Demo.FSM.Graph
{
	[CreateNodeMenu("Initial Node"), NodeTint("#00ff52")]
	public class FSMInitialNode : Node
	{
		[Output] public StateNode InitialNode;

		public StateNode NextNode
		{
			get
			{
				NodePort port;
				port = GetOutputPort("InitialNode");
				if (port == null)
					return null;
				if (port.ConnectionCount == 0)
					return null;

				return port.GetConnection(0).node as StateNode;
			}
		}
	}
}