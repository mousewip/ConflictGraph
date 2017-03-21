namespace ConflictGraph.Analysis
{
	public interface ICycleChecker
	{
		bool HasCycles(DependencyGraphNode node);
	}
}
