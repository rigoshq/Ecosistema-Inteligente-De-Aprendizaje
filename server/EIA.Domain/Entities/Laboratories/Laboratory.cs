using EIA.Domain.Entities.Laboratories.Enums;

namespace EIA.Domain.Entities.Laboratories;

public class Laboratory
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public LaboratoryType Type { get; private set; }

    public LaboratoryDifficulty Difficulty { get; private set; }

    public LaboratoryState State { get; private set; }

    public bool Active { get; private set; }

    public List<LaboratoryObjective> Objectives { get; }

    public List<LaboratoryEquipment> Equipments { get; }

    public List<LaboratoryExperiment> Experiments { get; }

    public List<LaboratoryReward> Rewards { get; }

    public List<LaboratoryResult> Results { get; }

    private Laboratory()
    {
        Id = Guid.NewGuid();

        Name = string.Empty;

        Description = string.Empty;

        Type = LaboratoryType.Physics;

        Difficulty = LaboratoryDifficulty.Beginner;

        State = LaboratoryState.Locked;

        Active = true;

        Objectives = new();

        Equipments = new();

        Experiments = new();

        Rewards = new();

        Results = new();
    }

    public Laboratory(
        string name,
        string description,
        LaboratoryType type,
        LaboratoryDifficulty difficulty)
        : this()
    {
        Name = name;

        Description = description;

        Type = type;

        Difficulty = difficulty;

        State = LaboratoryState.Available;
    }

    public void AddObjective(LaboratoryObjective objective)
    {
        Objectives.Add(objective);
    }

    public void AddEquipment(LaboratoryEquipment equipment)
    {
        Equipments.Add(equipment);
    }

    public void AddExperiment(LaboratoryExperiment experiment)
    {
        Experiments.Add(experiment);
    }

    public void AddReward(LaboratoryReward reward)
    {
        Rewards.Add(reward);
    }

    public void AddResult(LaboratoryResult result)
    {
        Results.Add(result);
    }

    public void Start()
    {
        State = LaboratoryState.InProgress;
    }

    public void Complete()
    {
        State = LaboratoryState.Completed;
    }

    public void Activate()
    {
        Active = true;
    }

    public void Deactivate()
    {
        Active = false;
    }
}