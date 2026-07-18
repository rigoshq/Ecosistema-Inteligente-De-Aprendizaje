using EIA.Domain.Entities.Missions;

namespace EIA.Infrastructure.Seed;

public static class MissionSeeder
{
    public static List<Mission> Create()
    {
        return new List<Mission>
        {
            new Mission(
                "PHY-001",
                "Descubre el Movimiento",
                "Realiza tu primer experimento de MRU.",
                "Physics",
                50)
        };
    }
}