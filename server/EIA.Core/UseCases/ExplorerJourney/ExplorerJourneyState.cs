namespace EIA.Core.UseCases.ExplorerJourney;

public enum ExplorerJourneyState
{
    Created = 0,

    Started = 1,

    TalkingToNpc = 2,

    MissionAccepted = 3,

    LaboratoryUnlocked = 4,

    LearningStarted = 5,

    RewardGranted = 6,

    Completed = 7
}