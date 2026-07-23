using EIA.Core.Intelligence;

namespace EIA.Core.Cognitive;

public class CognitiveTwinEngine
{
    public CognitiveTwin Build(
        Guid explorerId,
        ExplorerAcademicRecord record)
    {
        var twin =
            new CognitiveTwin(
                explorerId);

        var profile =
            record.LearningProfile;

        twin.UpdateKnowledge(
            profile.AverageScore);

        twin.UpdateAutonomy(
            profile.IndependentSolutions);

        twin.UpdatePersistence(
            profile.CompletedActivities);

        twin.UpdateCuriosity(
            profile.HelpRequests);

        twin.UpdateConfidence(
            profile.AverageScore);

        return twin;
    }
}