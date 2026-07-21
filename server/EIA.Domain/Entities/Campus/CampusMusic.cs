namespace EIA.Domain.Entities.Campus;

public class CampusMusic
{
    public string Theme { get; private set; }

    public float Volume { get; private set; }

    public bool Loop { get; private set; }

    public CampusMusic(
        string theme,
        float volume,
        bool loop)
    {
        Theme = theme;

        Volume = volume;

        Loop = loop;
    }
}