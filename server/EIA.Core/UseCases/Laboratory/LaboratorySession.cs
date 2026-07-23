using EIA.Domain.Entities.Laboratories;

namespace EIA.Core.UseCases.Laboratory;

public class LaboratorySession
{
    public LaboratorySession(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        Laboratory = laboratory;

        Records = new();
    }

    public Domain.Entities.Laboratories.Laboratory Laboratory { get; }

   public List<LaboratoryDataRow> Records { get; }

    public bool Finished { get; private set; }

    public void AddRecord(
    LaboratoryDataRow row)
    {
    Records.Add(row);
    }

    public void Finish()
    {
        Finished = true;
    }
}