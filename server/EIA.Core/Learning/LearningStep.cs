using EIA.Core.Knowledge;

namespace EIA.Core.Learning;

public class LearningStep
{
    public KnowledgeNode Concept { get; }

    public bool Completed { get; private set; }

    public LearningStep(
        KnowledgeNode concept)
    {
        Concept = concept;
    }

    public void Complete()
    {
        Completed = true;
    }
}