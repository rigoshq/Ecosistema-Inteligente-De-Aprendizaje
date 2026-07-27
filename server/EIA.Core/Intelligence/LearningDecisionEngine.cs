namespace EIA.Core.Intelligence;

public class LearningDecisionEngine
{
    public LearningDecision Decide(
        LearningContext context)
    {
        if (!context.HasMission())
        {
            return LearningDecision.AssignMission();
        }

        return LearningDecision.ContinueMission();
    }
}