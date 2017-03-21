using System.Collections.Generic;

namespace ConflictGraph.Analysis
{
	public class DependencyGraphNode
	{
		public DependencyGraphNode()
		{
			this.Dependencies = new List<DependencyGraphNode>();
		}

		public Transaction Transaction { get; set; }
		public IList<DependencyGraphNode> Dependencies { get; set; }

		public override string ToString()
		{
			return Transaction.ToString();
		}
	}
}
