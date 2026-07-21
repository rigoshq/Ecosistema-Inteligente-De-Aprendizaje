namespace EIA.Core.UseCases.ExplorerJourney;

public class ScenarioDefinition
{
    public string Code { get; }

    public string Name { get; }

    public string Description { get; }

    public string NpcCode { get; }

    public string DialogueCode { get; }

    public string MissionCode { get; }

    public string LearningExperienceCode { get; }

    public int ExperienceReward { get; }

    public int CoinsReward { get; }

    public ScenarioDefinition(
        string code,
        string name,
        string description,
        string npcCode,
        string dialogueCode,
        string missionCode,
        string learningExperienceCode,
        int experienceReward,
        int coinsReward)
    {
        Code = code;

        Name = name;

        Description = description;

        NpcCode = npcCode;

        DialogueCode = dialogueCode;

        MissionCode = missionCode;

        LearningExperienceCode = learningExperienceCode;

        ExperienceReward = experienceReward;

        CoinsReward = coinsReward;
    }
}