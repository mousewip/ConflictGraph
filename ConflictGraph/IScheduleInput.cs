namespace ConflictGraph
{
	/// <summary>
	/// Represents a process which can provide a Schedule to be analyzed.
	/// </summary>
	public interface IScheduleInput
	{
		/// <summary>
		/// The schedule to be analyzed.
		/// </summary>
		Schedule Schedule { get; }
	}
}
