namespace EIA.Domain.Entities.Buildings;

public class BuildingTheme
{
    public string PrimaryColor { get; private set; }

    public string SecondaryColor { get; private set; }

    public string AmbientMusic { get; private set; }

    public string Skybox { get; private set; }

    public BuildingTheme(
        string primaryColor,
        string secondaryColor,
        string ambientMusic,
        string skybox)
    {
        PrimaryColor = primaryColor;

        SecondaryColor = secondaryColor;

        AmbientMusic = ambientMusic;

        Skybox = skybox;
    }
}