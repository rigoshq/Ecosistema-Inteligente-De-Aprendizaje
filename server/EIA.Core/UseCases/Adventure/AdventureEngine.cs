using EIA.Domain.Entities.LearningExperiences;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.NPC;

using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;

namespace EIA.Core.UseCases.Adventure;

public class AdventureEngine
{
    public AdventureResult StartAdventure(
        AdventureContext context)
    {
        context.Start();

        return AdventureResult.Ok(
            "Adventure started.");
    }

    public AdventureResult StartExploration(
        AdventureContext context)
    {
        context.Explore();

        return AdventureResult.Ok(
            "Explorer is exploring.");
    }

    public AdventureResult MeetNpc(
        AdventureContext context,
        Npc npc)
    {
        context.SetNpc(npc);

        return AdventureResult.Ok(
            "NPC found.");
    }

    public AdventureResult StartDialogue(
        AdventureContext context,
        DialogueEntity dialogue)
    {
        context.SetDialogue(dialogue);

        return AdventureResult.Ok(
            "Dialogue started.");
    }

    public AdventureResult AcceptMission(
        AdventureContext context,
        Mission mission)
    {
        context.SetMission(mission);

        return AdventureResult.Ok(
            "Mission accepted.");
    }

    public AdventureResult StartLearningExperience(
        AdventureContext context,
        LearningExperience experience)
    {
        context.SetLearningExperience(experience);

        return AdventureResult.Ok(
            "Learning experience started.");
    }

    public AdventureResult EnterLaboratory(
        AdventureContext context)
    {
        context.EnterLaboratory();

        return AdventureResult.Ok(
            "Entering laboratory.");
    }

    public AdventureResult GrantReward(
        AdventureContext context,
        int experience,
        int coins)
    {
        context.Explorer.AddExperience(experience);

        context.Explorer.AddCoins(coins);

        context.GrantReward();

        return AdventureResult.Ok(
            "Reward granted.");
    }

    public AdventureResult FinishAdventure(
        AdventureContext context)
    {
        context.Finish();

        return AdventureResult.Ok(
            "Adventure finished.");
    }
}