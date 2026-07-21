namespace EIA.Domain.Entities.World.Connections;

public class TravelCost
{
    public int Energy { get; }

    public int Time { get; }

    public TravelCost(
        int energy,
        int time)
    {
        Energy = energy;

        Time = time;
    }
}