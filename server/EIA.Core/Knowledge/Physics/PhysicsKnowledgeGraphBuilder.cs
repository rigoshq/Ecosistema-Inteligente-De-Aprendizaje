namespace EIA.Core.Knowledge.Physics;

public class PhysicsKnowledgeGraphBuilder
{
    public KnowledgeGraph Build()
    {
        var graph = new KnowledgeGraph();

        //--------------------------------------------------
        // Cinemática
        //--------------------------------------------------

        var movement =
            graph.AddNode(
                "Movimiento",
                "Cambio de posición de un cuerpo.");

        var mru =
            graph.AddNode(
                "MRU",
                "Movimiento Rectilíneo Uniforme.");

        var mrua =
            graph.AddNode(
                "MRUA",
                "Movimiento Rectilíneo Uniformemente Acelerado.");

        var freeFall =
            graph.AddNode(
                "Caída Libre",
                "Movimiento vertical bajo gravedad.");

        //--------------------------------------------------
        // Magnitudes
        //--------------------------------------------------

        var distance =
            graph.AddNode(
                "Distancia",
                "Longitud recorrida.");

        var displacement =
            graph.AddNode(
                "Desplazamiento",
                "Cambio de posición.");

        var velocity =
            graph.AddNode(
                "Velocidad",
                "Cambio de posición respecto al tiempo.");

        var acceleration =
            graph.AddNode(
                "Aceleración",
                "Cambio de velocidad.");

        //--------------------------------------------------
        // Relaciones
        //--------------------------------------------------

        graph.Connect(
            movement,
            mru,
            "contains");

        graph.Connect(
            movement,
            mrua,
            "contains");

        graph.Connect(
            mrua,
            freeFall,
            "special_case");

        graph.Connect(
            mru,
            distance,
            "uses");

        graph.Connect(
            mru,
            velocity,
            "uses");

        graph.Connect(
            mrua,
            acceleration,
            "uses");

        graph.Connect(
            mrua,
            displacement,
            "uses");

        graph.Connect(
            freeFall,
            acceleration,
            "gravity");

        return graph;
    }
}