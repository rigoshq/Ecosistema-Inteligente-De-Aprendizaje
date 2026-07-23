using EIA.Domain.Entities.Dialogue;

namespace EIA.Infrastructure.Seed;

public static class DialogueSeeder
{
    public static List<Dialogue> Create()
    {
        var dialogues = new List<Dialogue>();

        //----------------------------------------------------------
        // DIÁLOGO 1
        //----------------------------------------------------------

        var welcome = new Dialogue(
            title: "Bienvenida de Newton",
            condition: new DialogueCondition(
                minimumLevel: 1,
                missionCompleted: false));

        var node1 = new DialogueNode(
            """
            Bienvenido, joven explorador.

            Soy Isaac Newton.

            Muchos creen que una simple manzana cambió el mundo.

            Hoy descubrirás que lo importante no fue la manzana,
            sino la pregunta que nació al verla caer.

            ¿Estás preparado para comenzar?
            """);

        node1.AddOption(
            new DialogueOption(
                "Sí profesor, estoy listo.",
                null));

        node1.AddOption(
            new DialogueOption(
                "Antes quisiera conocer este lugar.",
                null));

        welcome.AddNode(node1);

        dialogues.Add(welcome);

        //----------------------------------------------------------
        // DIÁLOGO 2
        //----------------------------------------------------------

        var laboratory = new Dialogue(
            title: "Entrada al laboratorio",
            condition: new DialogueCondition(
                minimumLevel: 1,
                missionCompleted: false));

        var node2 = new DialogueNode(
            """
            Excelente.

            Ahora entraremos al Laboratorio de Física.

            Allí comprobarás que la naturaleza puede describirse
            mediante modelos matemáticos.
            """);

        node2.AddOption(
            new DialogueOption(
                "Ingresar al laboratorio.",
                null));

        laboratory.AddNode(node2);

        dialogues.Add(laboratory);

        return dialogues;
    }
}