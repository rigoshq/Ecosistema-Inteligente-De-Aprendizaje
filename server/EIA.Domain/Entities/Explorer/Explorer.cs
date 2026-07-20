using EIA.Domain.Entities.Explorer.Achievements;
using EIA.Domain.Entities.Explorer.Inventory;
using EIA.Domain.Entities.Missions;

namespace EIA.Domain.Entities.Explorer; 

public class Explorer
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string UserName { get; private set; }

    public string Email { get; private set; }

    public int Level { get; private set; }

    public int Experience { get; private set; }

    public int Coins { get; private set; }

    public int MissionsCompleted { get; private set; }

    public int LaboratoriesCompleted { get; private set; }

    public List<InventoryItem> Inventory { get; }

    public List<Achievement> Achievements { get; }

    public List<ExplorerMission> ActiveMissions { get; }

    public Explorer()
    {
        Id = Guid.NewGuid();

        FirstName = "";

        LastName = "";

        UserName = "";

        Email = "";

        Level = 1;

        Experience = 0;

        Coins = 0;

        Inventory = new();

        Achievements = new();

        ActiveMissions = new();
    }

    public Explorer(
        string firstName,
        string lastName,
        string userName,
        string email)
        : this()
    {
        FirstName = firstName;

        LastName = lastName;

        UserName = userName;

        Email = email;
    }

    public void AddExperience(int xp)
    {
        Experience += xp;

        while (Experience >= ExperienceNeeded())
        {
            Experience -= ExperienceNeeded();
            Level++;
        }
    }

    private int ExperienceNeeded()
    {
        return Level * 100;
    }

    public void AddCoins(int coins)
    {
        Coins += coins;
    }

    public void CompleteMission()
    {
        MissionsCompleted++;
    }

    public void CompleteLaboratory()
    {
        LaboratoriesCompleted++;
    }

    public void AddItem(InventoryItem item)
    {
        var existing = Inventory.FirstOrDefault(i => i.Code == item.Code);

        if (existing == null)
        {
            Inventory.Add(item);
            return;
        }

        existing.Quantity += item.Quantity;
    }

    public void UnlockAchievement(Achievement achievement)
    {
        if (Achievements.Any(a => a.Code == achievement.Code))
            return;

        Achievements.Add(achievement);
    }

    public void AcceptMission(Mission mission)
    {
        if (ActiveMissions.Any(m => m.MissionId == mission.Id))
            return;

    ActiveMissions.Add(new ExplorerMission(mission.Id));
    }

    public void CompleteMission(Guid missionId)
    {
        var mission = ActiveMissions
            .FirstOrDefault(m => m.MissionId == missionId);

        if (mission == null)
            return;

        if (mission.Completed)
            return;

        mission.Complete();

        MissionsCompleted++;
    }
    
}