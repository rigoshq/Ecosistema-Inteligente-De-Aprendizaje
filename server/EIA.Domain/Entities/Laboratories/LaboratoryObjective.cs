namespace EIA.Domain.Entities.Laboratories;

public class LaboratoryObjective
{
    public Guid Id { get; private set; }

    public string Description { get; private set; }

    public bool Completed { get; private set; }

    public LaboratoryObjective(string description)
    {
        Id = Guid.NewGuid();

        Description = description;

        Completed = false;
    }

    public void Complete()
    {
        Completed = true;
    }
}