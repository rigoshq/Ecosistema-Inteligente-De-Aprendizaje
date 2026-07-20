using EIA.Domain.Entities.Missions.Enums;

namespace EIA.Domain.Entities.Missions;

public class Mission
{
    public Guid Id { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public string Narrative { get; private set; }

    public MissionType Type { get; private set; }

    public MissionDifficulty Difficulty { get; private set; }

    public MissionState State { get; private set; }

    public int MinimumLevel { get; private set; }

    public int ExperienceReward { get; private set; }

    public int CoinsReward { get; private set; }

    public Guid? LaboratoryId { get; private set; }

    public Guid? NpcId { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime UpdatedAt { get; private set; }

    public List<MissionStep> Steps { get; }

    public List<MissionReward> Rewards { get; }

    public List<MissionDialogue> Dialogues { get; }

    public List<MissionRequirement> Requirements { get; }

    private Mission()
    {
        Title = string.Empty;
        Description = string.Empty;
        Narrative = string.Empty;

        Steps = new();
        Rewards = new();
        Dialogues = new();
        Requirements = new();
    }

    public Mission(
        string title,
        string description,
        string narrative,
        MissionType type)
        : this()
    {
        Id = Guid.NewGuid();

        Title = title;
        Description = description;
        Narrative = narrative;

        Type = type;

        Difficulty = MissionDifficulty.Beginner;

        State = MissionState.Available;

        MinimumLevel = 1;

        ExperienceReward = 100;

        CoinsReward = 50;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public bool CanBeAccepted(int explorerLevel)
    {
        if (State != MissionState.Available)
            return false;

        return explorerLevel >= MinimumLevel;
    }

    public bool CanBeCompleted()
    {
        return State == MissionState.InProgress;
    }

    public void Start()
    {
        if (!CanBeAccepted(MinimumLevel))
            return;

        State = MissionState.InProgress;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Complete()
    {
        if (!CanBeCompleted())
            return;

        State = MissionState.Completed;
        UpdatedAt = DateTime.UtcNow;
    }

    public void ClaimReward()
    {
        if (State != MissionState.Completed)
            return;

        State = MissionState.RewardClaimed;
        UpdatedAt = DateTime.UtcNow;
    }

    public void SetRewards(
        int experience,
        int coins)
    {
        ExperienceReward = experience;
        CoinsReward = coins;

        UpdatedAt = DateTime.UtcNow;
    }

    public void SetMinimumLevel(int level)
    {
        MinimumLevel = level;

        UpdatedAt = DateTime.UtcNow;
    }

    public void AddStep(MissionStep step)
    {
        Steps.Add(step);

        UpdatedAt = DateTime.UtcNow;
    }

    public void AddReward(MissionReward reward)
    {
        Rewards.Add(reward);

        UpdatedAt = DateTime.UtcNow;
    }

    public void AddDialogue(MissionDialogue dialogue)
    {
        Dialogues.Add(dialogue);

        UpdatedAt = DateTime.UtcNow;
    }

    public void AddRequirement(MissionRequirement requirement)
    {
        Requirements.Add(requirement);

        UpdatedAt = DateTime.UtcNow;
    }
}