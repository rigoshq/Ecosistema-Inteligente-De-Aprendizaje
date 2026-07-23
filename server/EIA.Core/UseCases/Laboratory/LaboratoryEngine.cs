using EIA.Domain.Entities.Laboratories;

namespace EIA.Core.UseCases.Laboratory;

public class LaboratoryEngine
{
    public void StartLaboratory(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        laboratory.Start();
    }

    public void CompleteLaboratory(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        laboratory.Complete();
    }

    public bool IsAvailable(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        return laboratory.Active;
    }

    public IReadOnlyCollection<LaboratoryObjective> GetObjectives(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        return laboratory.Objectives;
    }

    public IReadOnlyCollection<LaboratoryEquipment> GetEquipments(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        return laboratory.Equipments;
    }

    public IReadOnlyCollection<LaboratoryExperiment> GetExperiments(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        return laboratory.Experiments;
    }

    public IReadOnlyCollection<LaboratoryReward> GetRewards(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        return laboratory.Rewards;
    }
}