using EIA.Core.Intelligence;
using EIA.Core.Pedagogy;

namespace EIA.Core.Meta;

public class MetaEngine
{
    private readonly AdaptivePedagogicalEngine _pedagogy;

    public MetaEngine()
    {
        _pedagogy = new();
    }

    public MetaDecision Think(
        ExplorerAcademicRecord record)
    {
        var pedagogicalDecision =
            _pedagogy.Decide(record);

        //--------------------------------------------------
        // Por ahora el siguiente concepto es MRUA
        // Más adelante será calculado por el
        // Knowledge Graph.
        //--------------------------------------------------

        return new MetaDecision(
            pedagogicalDecision.Strategy,
            "MRUA",
            pedagogicalDecision.Reason);
    }
}