namespace EIA.Domain.Entities;

public class Explorer
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string UserName { get; private set; }

    public string Email { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public bool IsActive { get; private set; }

    public Explorer(
        string firstName,
        string lastName,
        string userName,
        string email)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        Email = email;
        CreatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    public void Activate()
    {
        IsActive = true;
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }
}