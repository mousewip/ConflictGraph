namespace ConflictGraph.Analysis
{
	public interface IStepPairInspector
	{
		TransactionStepPair[] GetPairs(Schedule schedule);
	}
}
