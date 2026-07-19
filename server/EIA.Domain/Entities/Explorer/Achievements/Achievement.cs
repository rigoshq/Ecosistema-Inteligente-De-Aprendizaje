namespace EIA.Domain.Entities.Explorer.Achievements;

public class Achievement
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Code { get; set; } = "";

    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    public DateTime UnlockedAt { get; set; } = DateTime.UtcNow;
}