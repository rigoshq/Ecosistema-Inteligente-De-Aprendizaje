using EIA.Domain.Entities;
using EIA.Domain.Entities.Dialogue;
using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.LearningExperiences;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.NPC;

namespace EIA.Core.UseCases.ExplorerJourney;

public class ExplorerJourneyContext
{
    public Explorer Explorer { get; }

    public LearningWorld World { get; }

    public Npc? CurrentNpc { get; private set; }

    public Dialogue? CurrentDialogue { get; private set; }

    public Mission? CurrentMission { get; private set; }

    public LearningExperience? CurrentLearningExperience { get; private set; }

    public ExplorerJourneyState State { get; private set; }

    public ExplorerJourneyContext(
        Explorer explorer,
        LearningWorld world)
    {
        Explorer = explorer;

        World = world;

        State = ExplorerJourneyState.Created;
    }

    public void Start()
    {
        State = ExplorerJourneyState.Started;
    }

    public void SetNpc(Npc npc)
    {
        CurrentNpc = npc;

        State = ExplorerJourneyState.TalkingToNpc;
    }

    public void SetDialogue(Dialogue dialogue)
    {
        CurrentDialogue = dialogue;
    }

    public void SetMission(Mission mission)
    {
        CurrentMission = mission;

        State = ExplorerJourneyState.MissionAccepted;
    }

    public void SetLearningExperience(
        LearningExperience learningExperience)
    {
        CurrentLearningExperience = learningExperience;

        State = ExplorerJourneyState.LearningStarted;
    }

    public void GrantReward()
    {
        State = ExplorerJourneyState.RewardGranted;
    }

    public void Complete()
    {
        State = ExplorerJourneyState.Completed;
    }
}