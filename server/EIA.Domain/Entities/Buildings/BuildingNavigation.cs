namespace EIA.Domain.Entities.Buildings;

public class BuildingNavigation
{
    public bool MiniMapEnabled { get; private set; }

    public bool ShowSigns { get; private set; }

    public BuildingNavigation()
    {
        MiniMapEnabled = true;

        ShowSigns = true;
    }

    public void EnableMiniMap()
    {
        MiniMapEnabled = true;
    }

    public void DisableMiniMap()
    {
        MiniMapEnabled = false;
    }

    public void EnableSigns()
    {
        ShowSigns = true;
    }

    public void DisableSigns()
    {
        ShowSigns = false;
    }
}