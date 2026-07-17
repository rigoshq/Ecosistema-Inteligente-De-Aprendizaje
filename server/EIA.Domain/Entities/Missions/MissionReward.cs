namespace EIA.Domain.Entities.Missions;

public class MissionReward
{
    public int Experience { get; set; }

    public int Coins { get; set; }

    public List<string> Badges { get; set; } = new();
}