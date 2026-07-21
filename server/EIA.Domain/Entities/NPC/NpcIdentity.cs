namespace EIA.Domain.Entities.NPC;

public class NpcIdentity
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Title { get; private set; }

    public string Specialty { get; private set; }

    private NpcIdentity()
    {
        Id = Guid.NewGuid();

        FirstName = string.Empty;

        LastName = string.Empty;

        Title = string.Empty;

        Specialty = string.Empty;
    }

    public NpcIdentity(
        string firstName,
        string lastName,
        string title,
        string specialty)
        : this()
    {
        FirstName = firstName;

        LastName = lastName;

        Title = title;

        Specialty = specialty;
    }

    public string FullName =>
        $"{Title} {FirstName} {LastName}";
}