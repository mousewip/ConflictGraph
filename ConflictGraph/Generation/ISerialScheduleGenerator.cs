namespace ConflictGraph.Generation
{
	public interface ISerialScheduleGenerator
	{
		Schedule GetSerialSchedule(Schedule originalSchedule);
	}
}
