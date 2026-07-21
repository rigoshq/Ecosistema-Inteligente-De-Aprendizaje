namespace EIA.Domain.Entities.Laboratories;

public class LaboratoryExperiment
{
    public Guid Id { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public LaboratoryExperiment(
        string title,
        string description)
    {
        Id = Guid.NewGuid();

        Title = title;

        Description = description;
    }
}