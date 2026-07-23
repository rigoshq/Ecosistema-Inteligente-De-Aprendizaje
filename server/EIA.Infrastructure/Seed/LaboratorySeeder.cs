using EIA.Domain.Entities.Laboratories;
using EIA.Domain.Entities.Laboratories.Enums;

namespace EIA.Infrastructure.Seed;

public static class LaboratorySeeder
{
    public static List<Laboratory> Create()
    {
        var laboratories = new List<Laboratory>();

        //----------------------------------------------------------
        // LABORATORIO 1
        //----------------------------------------------------------

        var laboratory = new Laboratory(
            name: "Movimiento Rectilíneo Uniforme",
            description:
                "Estudia el movimiento de un cuerpo que se desplaza con velocidad constante.",
            type: LaboratoryType.Physics,
            difficulty: LaboratoryDifficulty.Beginner);

        //----------------------------------------------------------
        // Objetivos
        //----------------------------------------------------------

        laboratory.AddObjective(
            new LaboratoryObjective(
                "Comprender la relación entre distancia, tiempo y velocidad."));

        laboratory.AddObjective(
            new LaboratoryObjective(
                "Construir una tabla de datos experimentales."));

        laboratory.AddObjective(
            new LaboratoryObjective(
                "Interpretar la gráfica posición-tiempo."));

        //----------------------------------------------------------
        // Equipos
        //----------------------------------------------------------

        laboratory.AddEquipment(
            new LaboratoryEquipment(
                "Cronómetro",
                "Permite medir el tiempo empleado por el móvil durante el experimento."));

        laboratory.AddEquipment(
            new LaboratoryEquipment(
                "Regla",
                "Permite medir la distancia recorrida por el móvil."));

        laboratory.AddEquipment(
            new LaboratoryEquipment(
                "Carro dinámico",
                "Objeto que realizará el movimiento rectilíneo uniforme."));

        laboratory.AddEquipment(
            new LaboratoryEquipment(
                "Sensor de movimiento",
                "Registra automáticamente la posición y el tiempo del móvil."));

        //----------------------------------------------------------
        // Experimento
        //----------------------------------------------------------

        laboratory.AddExperiment(
            new LaboratoryExperiment(
                "Movimiento Rectilíneo Uniforme",
                "Determinar experimentalmente la velocidad constante de un móvil."));

        //----------------------------------------------------------
        // Recompensa
        //----------------------------------------------------------

        laboratory.AddReward(
            new LaboratoryReward(
                experience: 150,
                coins: 50));

        laboratories.Add(laboratory);

        return laboratories;
    }
}