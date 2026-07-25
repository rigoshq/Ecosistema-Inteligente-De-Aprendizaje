using EIA.Core.Memory;

namespace EIA.Core.Events;

public class LaboratoryCompletedMemoryHandler
    : IEventHandler<LaboratoryCompletedEvent>
{
    private readonly EducationalMemoryEngine _memory;

    public LaboratoryCompletedMemoryHandler(
        EducationalMemoryEngine memory)
    {
        _memory = memory;
    }

    public Task HandleAsync(
        LaboratoryCompletedEvent learningEvent)
    {
        _memory.Remember(

            new LearningMemory(

                "Laboratorio terminado",

                learningEvent.LaboratoryId.ToString(),

                "El explorador completó exitosamente un laboratorio.")
        );

        return Task.CompletedTask;
    }
}