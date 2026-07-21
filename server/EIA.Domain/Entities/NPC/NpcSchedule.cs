namespace EIA.Domain.Entities.NPC;

public class NpcSchedule
{
    public TimeOnly StartTime { get; private set; }

    public TimeOnly EndTime { get; private set; }

    public string CurrentBuilding { get; private set; }

    public bool Available { get; private set; }

    public NpcSchedule()
    {
        StartTime = new TimeOnly(8, 0);

        EndTime = new TimeOnly(17, 0);

        CurrentBuilding = string.Empty;

        Available = true;
    }

    public void MoveTo(string building)
    {
        CurrentBuilding = building;
    }

    public void SetAvailability(bool available)
    {
        Available = available;
    }

    public bool IsWorking(TimeOnly time)
    {
        return time >= StartTime &&
               time <= EndTime &&
               Available;
    }
}