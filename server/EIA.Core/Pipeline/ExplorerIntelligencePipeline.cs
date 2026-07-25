using EIA.Core.Cognitive;
using EIA.Core.Intelligence;
using EIA.Core.Mastery;
using EIA.Core.Memory;
using EIA.Core.Meta;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.Pipeline;

public class ExplorerIntelligencePipeline
{
    private readonly CognitiveTwinEngine _cognitive;

    private readonly EducationalMemoryEngine _memory;

    private readonly ConceptMasteryEngine _mastery;

    private readonly MetaEngine _meta;

    public ExplorerIntelligencePipeline(
        CognitiveTwinEngine cognitive,
        EducationalMemoryEngine memory,
        ConceptMasteryEngine mastery,
        MetaEngine meta)
    {
        _cognitive = cognitive;

        _memory = memory;

        _mastery = mastery;

        _meta = meta;
    }

    public void Execute(
        ExplorerAcademicRecord record)
    {
        ExecuteTimeline(record);

        ExecuteMemory(record);

        ExecuteCognitive(record);

        ExecuteMastery(record);

        ExecuteMeta(record);
    }

    //--------------------------------------------------------
    // STAGE 1
    //--------------------------------------------------------

    private void ExecuteTimeline(
    ExplorerAcademicRecord record)
    {
    record.AddTimelineEvent(

        new LearningTimelineEvent(

            "Pipeline iniciado",

            "El Ecosistema Inteligente inició el procesamiento del aprendizaje.",

            "System"));
    }

    //--------------------------------------------------------
    // STAGE 2
    //--------------------------------------------------------

    private void ExecuteMemory(
        ExplorerAcademicRecord record)
    {
        // Próximamente
    }

    //--------------------------------------------------------
    // STAGE 3
    //--------------------------------------------------------

    private void ExecuteCognitive(
        ExplorerAcademicRecord record)
    {
        // Próximamente
    }

    //--------------------------------------------------------
    // STAGE 4
    //--------------------------------------------------------

    private void ExecuteMastery(
        ExplorerAcademicRecord record)
    {
        // Próximamente
    }

    //--------------------------------------------------------
    // STAGE 5
    //--------------------------------------------------------

    private void ExecuteMeta(
        ExplorerAcademicRecord record)
    {
        var decision =
            _meta.Think(record);

        _ = decision;
    }
}