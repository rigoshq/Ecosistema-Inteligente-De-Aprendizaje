using EIA.Domain.Entities.Dialogue;
using EIA.Domain.Entities.LearningExperiences;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.NPC;
using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;

namespace EIA.Core.UseCases.ExplorerJourney;

public class ExplorerJourneyEngine
{
    public ExplorerJourneyResult StartJourney(
        ExplorerJourneyContext context)
    {
        context.Start();

        return ExplorerJourneyResult.Ok(
            "Journey started.");
    }

    public ExplorerJourneyResult MeetNpc(
        ExplorerJourneyContext context,
        Npc npc)
    {
        context.SetNpc(npc);

        return ExplorerJourneyResult.Ok(
            $"Explorer meets {npc.FullName}.");
    }

    public ExplorerJourneyResult StartDialogue(
        ExplorerJourneyContext context,
        DialogueEntity dialogue)
    {
        context.SetDialogue(dialogue);

        return ExplorerJourneyResult.Ok(
            "Dialogue started.");
    }

    public ExplorerJourneyResult AcceptMission(
        ExplorerJourneyContext context,
        Mission mission)
    {
        context.SetMission(mission);

        context.Explorer.AcceptMission(mission);

        return ExplorerJourneyResult.Ok(
            "Mission accepted.");
    }

    public ExplorerJourneyResult StartLearningExperience(
        ExplorerJourneyContext context,
        LearningExperience learningExperience)
    {
        context.SetLearningExperience(
            learningExperience);

        return ExplorerJourneyResult.Ok(
            "Learning experience started.");
    }

    public ExplorerJourneyResult GrantReward(
        ExplorerJourneyContext context,
        int experience,
        int coins)
    {
        context.Explorer.AddExperience(experience);

        context.Explorer.AddCoins(coins);

        context.GrantReward();

        return ExplorerJourneyResult.Ok(
            "Reward granted.");
    }

    public ExplorerJourneyResult CompleteJourney(
        ExplorerJourneyContext context)
    {
        context.Complete();

        return ExplorerJourneyResult.Ok(
            "Journey completed.");
    }
}