namespace EIA.Core.DTOs;

public class ExplorerProfileDto
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = "";

    public string LastName { get; set; } = "";

    public string UserName { get; set; } = "";

    public int Level { get; set; }

    public int Experience { get; set; }

    public int Coins { get; set; }

    public int MissionsCompleted { get; set; }

    public int LaboratoriesCompleted { get; set; }

    public int InventoryItems { get; set; }

    public int Achievements { get; set; }
}