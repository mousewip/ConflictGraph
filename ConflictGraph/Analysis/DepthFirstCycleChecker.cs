using System.Collections.Generic;

namespace ConflictGraph.Analysis
{
	/// <summary>
	/// A recursive depth first search to determine if a graph has a cycle.
	/// </summary>
	public class DepthFirstCycleChecker : ICycleChecker
	{
		public bool HasCycles(DependencyGraphNode node)
		{
			return HasCycles(node, new List<DependencyGraphNode>());
		}

		private bool HasCycles(DependencyGraphNode node, List<DependencyGraphNode> seenNodes)
		{
			if (seenNodes.Contains(node))
			{
				return true;
			}

			seenNodes.Add(node);

			foreach (var dependency in node.Dependencies)
			{
				var seenNodesClone = new List<DependencyGraphNode>(seenNodes);

				if (HasCycles(dependency, seenNodesClone))
				{
					return true;
				}
			}

			return false;
		}
	}
}
