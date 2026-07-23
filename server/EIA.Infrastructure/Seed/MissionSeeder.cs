using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.Missions.Enums;

namespace EIA.Infrastructure.Seed;

public static class MissionSeeder
{
    public static List<Mission> Create()
    {
        var missions = new List<Mission>();

        // ===========================================================
        // MISIÓN 1
        // ===========================================================

        var mission1 = new Mission(
            title: "La caída de la manzana",
            description:
                "Descubre cómo Newton llegó a formular la Ley de la Gravitación Universal.",
            narrative:
                """
                Al ingresar al Campus Newton encuentras al gran científico
                observando un antiguo manzano.

                Newton desea demostrar que detrás de la caída de una simple
                manzana existe una ley capaz de explicar el movimiento de la
                Luna, los planetas y los cuerpos celestes.

                Tu misión será acompañarlo durante este descubrimiento.
                """,
            type: MissionType.Tutorial);

        mission1.SetMinimumLevel(1);

        mission1.SetRewards(
            experience: 150,
            coins: 50);

        missions.Add(mission1);

        // ===========================================================
        // MISIÓN 2
        // ===========================================================

        var mission2 = new Mission(
            title: "Midiendo el movimiento",
            description:
                "Aprende a medir distancia, tiempo y velocidad.",
            narrative:
                """
                Newton te conduce al laboratorio de cinemática.

                Allí aprenderás que todo movimiento puede describirse mediante
                modelos matemáticos sencillos utilizando distancia, tiempo y
                velocidad.
                """,
           type: MissionType.Story);

        mission2.SetMinimumLevel(1);

        mission2.SetRewards(
            experience: 250,
            coins: 75);

        missions.Add(mission2);

        // ===========================================================
        // MISIÓN 3
        // ===========================================================

        var mission3 = new Mission(
            title: "Descubre el MRU",
            description:
                "Realiza tu primer experimento sobre Movimiento Rectilíneo Uniforme.",
            narrative:
                """
                El profesor Newton necesita comprobar que un cuerpo puede
                desplazarse con velocidad constante.

                Utiliza el laboratorio virtual para obtener los datos y
                comprobar el modelo físico.
                """,
            type: MissionType.Laboratory);

        mission3.SetMinimumLevel(2);

        mission3.SetRewards(
            experience: 300,
            coins: 100);

        missions.Add(mission3);

        return missions;
    }
}