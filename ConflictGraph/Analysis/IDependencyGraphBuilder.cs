using System.Collections.Generic;

namespace ConflictGraph.Analysis
{
	public interface IDependencyGraphBuilder
	{
		IEnumerable<DependencyGraphNode> GetGraph(Schedule schedule);
	}
}