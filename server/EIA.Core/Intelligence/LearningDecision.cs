namespace EIA.Core.Intelligence;

public class LearningDecision
{
    public string Action { get; }

    private LearningDecision(string action)
    {
        Action = action;
    }

    //----------------------------------------------------------
    // Decisiones disponibles
    //----------------------------------------------------------

    public static LearningDecision AssignMission()
        => new("ASSIGN_MISSION");

    public static LearningDecision ContinueMission()
        => new("CONTINUE_MISSION");

    public static LearningDecision RecommendBuilding()
        => new("RECOMMEND_BUILDING");

    public static LearningDecision RecommendLaboratory()
        => new("RECOMMEND_LABORATORY");

    public static LearningDecision RecommendDistrict()
        => new("RECOMMEND_DISTRICT");

    public static LearningDecision FinishJourney()
        => new("FINISH_JOURNEY");
}