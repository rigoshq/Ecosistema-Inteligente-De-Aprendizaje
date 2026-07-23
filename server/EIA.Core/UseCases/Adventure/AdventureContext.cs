using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.LearningExperiences;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.NPC;

using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;

namespace EIA.Core.UseCases.Adventure;

public class AdventureContext
{
    public Explorer Explorer { get; }

    public Npc? CurrentNpc { get; private set; }

    public DialogueEntity? CurrentDialogue { get; private set; }

    public Mission? CurrentMission { get; private set; }

    public LearningExperience? CurrentLearningExperience { get; private set; }

    public AdventureState State { get; private set; }

    public AdventureContext(
        Explorer explorer)
    {
        Explorer = explorer;

        State = AdventureState.Created;
    }

    public void Start()
    {
        State = AdventureState.Started;
    }

    public void Explore()
    {
        State = AdventureState.Exploring;
    }

    public void SetNpc(
        Npc npc)
    {
        CurrentNpc = npc;

        State = AdventureState.Talking;
    }

    public void SetDialogue(
        DialogueEntity dialogue)
    {
        CurrentDialogue = dialogue;

        State = AdventureState.Talking;
    }

    public void SetMission(
        Mission mission)
    {
        CurrentMission = mission;

        State = AdventureState.MissionRunning;
    }

    public void SetLearningExperience(
        LearningExperience experience)
    {
        CurrentLearningExperience = experience;

        State = AdventureState.Learning;
    }

    public void EnterLaboratory()
    {
        State = AdventureState.Laboratory;
    }

    public void GrantReward()
    {
        State = AdventureState.Reward;
    }

    public void Finish()
    {
        State = AdventureState.Finished;
    }
}