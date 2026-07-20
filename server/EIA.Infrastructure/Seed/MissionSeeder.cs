using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.Missions.Enums;

namespace EIA.Infrastructure.Seed;

public static class MissionSeeder
{
    public static List<Mission> Create()
    {
        return
        [
            new Mission(
                title: "Descubre el Movimiento",
                description: "Realiza tu primer experimento de Movimiento Rectilíneo Uniforme.",
                narrative:
                    "El profesor Newton necesita tu ayuda para demostrar que el movimiento puede describirse mediante modelos matemáticos.",
                type: MissionType.Tutorial)
        ];
    }
}