namespace ConflictGraph
{
	/// <summary>
	/// Represents an analyzation process which can determine whether or not 
	/// a given schedule is conflict serializable.
	/// </summary>
	public interface ISerializabilityAnalyzer
	{
		bool IsConflictSerializable(Schedule schedule);
	}
}