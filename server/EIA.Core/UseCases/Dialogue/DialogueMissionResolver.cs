using EIA.Domain.Entities.Missions;

using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;

namespace EIA.Core.UseCases.Dialogue;

public class DialogueMissionResolver
{
    public Mission? Resolve(
        DialogueEntity dialogue,
        IReadOnlyCollection<Mission> missions)
    {
        if (dialogue.Title == "Bienvenida de Newton")
        {
            return missions.FirstOrDefault(
                x => x.Title == "La caída de la manzana");
        }

        if (dialogue.Title == "Entrada al laboratorio")
        {
            return missions.FirstOrDefault(
                x => x.Title == "Midiendo el movimiento");
        }

        return null;
    }
}