namespace EIA.Domain.Navigation;

public class NavigationPath
{
    public List<WorldLocation> Locations { get; }

    public NavigationPath()
    {
        Locations = new();
    }

    public void Add(WorldLocation location)
    {
        Locations.Add(location);
    }
}