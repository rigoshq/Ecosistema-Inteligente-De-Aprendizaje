using EIA.Core.Services.Adventure;
using EIA.Core.Services.Adventure.Enums;
using EIA.Core.Services.AdventureEngine.Enums;
using EIA.Domain.Entities;
using EIA.Domain.Entities.Explorer;
using EIA.Domain.Navigation;

namespace EIA.Core.Services.AdventureEngine;

public class AdventureEngine
{
    public AdventureSession CreateSession(
        Explorer explorer,
        LearningWorld world)
    {
        return new AdventureSession(
            explorer,
            world);
    }

    public AdventureDecision EnterWorld(
        AdventureSession session,
        WorldLocation initialLocation)
    {
        if (session.State != AdventureState.NotStarted)
        {
            return AdventureDecision.Deny(
                "The explorer has already entered the world.");
        }

        session.Explorer.EnterWorld(initialLocation);

        session.Start();

        return AdventureDecision.Allow(
            "Explorer entered the learning world.");
    }

    public AdventureDecision MoveExplorer(
        AdventureSession session,
        WorldLocation destination)
    {
        if (session.State != AdventureState.Running)
        {
            return AdventureDecision.Deny(
                "Adventure session is not running.");
        }

        session.Explorer.MoveTo(destination);

        return AdventureDecision.Allow(
            "Explorer moved successfully.");
    }

    public AdventureEvent RegisterEvent(
        AdventureEventType type,
        string description)
    {
        return new AdventureEvent(
            type,
            description);
    }

    public AdventureAction CreateAction(
        AdventureActionType type,
        string description)
    {
        return new AdventureAction(
            type,
            description);
    }
}