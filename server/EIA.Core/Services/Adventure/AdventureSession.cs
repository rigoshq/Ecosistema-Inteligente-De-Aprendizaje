using EIA.Core.Services.Adventure.Enums;
using EIA.Domain.Entities;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.Services.Adventure;

public class AdventureSession
{
    public Guid Id { get; }

    public Explorer Explorer { get; }

    public LearningWorld World { get; }

    public AdventureState State { get; private set; }

    public DateTime StartedAt { get; }

    public DateTime? FinishedAt { get; private set; }

    public AdventureSession(
        Explorer explorer,
        LearningWorld world)
    {
        Id = Guid.NewGuid();

        Explorer = explorer;

        World = world;

        StartedAt = DateTime.UtcNow;

        State = AdventureState.NotStarted;
    }

    public AdventureResult Start()
    {
        if (State != AdventureState.NotStarted)
            return AdventureResult.Fail(
                "Adventure already started.");

        State = AdventureState.Running;

        return AdventureResult.Ok(
            "Adventure started.");
    }

    public AdventureResult Pause()
    {
        if (State != AdventureState.Running)
            return AdventureResult.Fail(
                "Adventure is not running.");

        State = AdventureState.Paused;

        return AdventureResult.Ok(
            "Adventure paused.");
    }

    public AdventureResult Resume()
    {
        if (State != AdventureState.Paused)
            return AdventureResult.Fail(
                "Adventure is not paused.");

        State = AdventureState.Running;

        return AdventureResult.Ok(
            "Adventure resumed.");
    }

    public AdventureResult Finish()
    {
        if (State == AdventureState.Finished)
            return AdventureResult.Fail(
                "Adventure already finished.");

        FinishedAt = DateTime.UtcNow;

        State = AdventureState.Finished;

        return AdventureResult.Ok(
            "Adventure finished.");
    }
}