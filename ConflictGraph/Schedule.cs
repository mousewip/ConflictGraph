namespace ConflictGraph
{
	/// <summary>
	/// Represents a schedule of transaction steps.
	/// </summary>
	public class Schedule
	{
		public TransactionStep[] Steps { get; set; }

		public override string ToString()
		{
			return string.Join(", ", (object[])Steps);
		}
	}
}
