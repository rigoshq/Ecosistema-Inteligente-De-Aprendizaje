using EIA.Core.Memory;

namespace EIA.Core.Events;

public class KnowledgeMemoryHandler
    : IEventHandler<KnowledgeConceptLearnedEvent>
{
    private readonly EducationalMemoryEngine _memory;

    public KnowledgeMemoryHandler(
        EducationalMemoryEngine memory)
    {
        _memory = memory;
    }

    public Task HandleAsync(
        KnowledgeConceptLearnedEvent learningEvent)
    {
        _memory.Remember(

            new LearningMemory(

                "Concepto aprendido",

                learningEvent.ConceptName,

                $"El explorador aprendió el concepto {learningEvent.ConceptName}.")
        );

        return Task.CompletedTask;
    }
}