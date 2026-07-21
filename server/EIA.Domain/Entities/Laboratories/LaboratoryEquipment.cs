namespace EIA.Domain.Entities.Laboratories;

public class LaboratoryEquipment
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public LaboratoryEquipment(
        string name,
        string description)
    {
        Id = Guid.NewGuid();

        Name = name;

        Description = description;
    }
}