using EIA.Domain.Entities;
using EIA.Domain.Entities.World;
using EIA.Domain.Entities.World.Enums;

namespace EIA.Infrastructure.Seed;

public static class WorldSeeder
{
    public static LearningWorld Create()
    {
        var world = new LearningWorld("EIA World");


        var city = new KnowledgeCity(
            "Ciudad del Conocimiento"
        );


        var campusType = (CampusType)Enum
            .GetValues(typeof(CampusType))
            .GetValue(0)!;


        var campus = new KnowledgeCampus(
            "Campus Principal",
            campusType
        );


        var buildingCategory = (BuildingCategory)Enum
            .GetValues(typeof(BuildingCategory))
            .GetValue(0)!;


        campus.AddBuilding(
            new KnowledgeBuilding(
                "Edificio de Física",
                buildingCategory
            )
        );


        campus.AddBuilding(
            new KnowledgeBuilding(
                "Edificio de Matemáticas",
                buildingCategory
            )
        );


        campus.AddBuilding(
            new KnowledgeBuilding(
                "Edificio de Química",
                buildingCategory
            )
        );


        campus.AddBuilding(
            new KnowledgeBuilding(
                "Biblioteca",
                buildingCategory
            )
        );


        city.AddCampus(campus);

        world.AddCity(city);


        return world;
    }
}