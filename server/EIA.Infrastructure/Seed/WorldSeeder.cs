using EIA.Domain.Entities;

namespace EIA.Infrastructure.Seed;

public static class WorldSeeder
{
    public static LearningWorld Create()
    {
        var world = new LearningWorld("EIA World");

        var city = new KnowledgeCity(
            "Ciudad del Conocimiento",
            "Ciudad principal del Ecosistema Inteligente de Aprendizaje");

        city.AddBuilding(new KnowledgeBuilding(
            "Edificio de Física",
            "Physics",
            "Aprende Física mediante experimentos"));

        city.AddBuilding(new KnowledgeBuilding(
            "Edificio de Matemáticas",
            "Mathematics",
            "Resuelve desafíos matemáticos"));

        city.AddBuilding(new KnowledgeBuilding(
            "Edificio de Química",
            "Chemistry",
            "Laboratorios virtuales"));

        city.AddBuilding(new KnowledgeBuilding(
            "Biblioteca",
            "Library",
            "Centro de consulta"));

        world.AddCity(city);

        return world;
    }
}