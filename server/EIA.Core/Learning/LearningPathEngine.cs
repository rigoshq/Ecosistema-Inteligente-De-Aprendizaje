using EIA.Core.Intelligence;
using EIA.Core.Knowledge;

namespace EIA.Core.Learning;

public class LearningPathEngine
{
    public LearningPath Build(
        ExplorerAcademicRecord record,
        IEnumerable<KnowledgeNode> concepts)
    {
        var path = new LearningPath();

        foreach (var concept in concepts)
        {
            path.AddStep(
                new LearningStep(concept));
        }

        return path;
    }
}