using EIA.Domain.Entities.Campus.Enums;

namespace EIA.Domain.Entities.Campus;

public class CampusEnvironment
{
    public CampusSeason Season { get; private set; }

    public bool Daylight { get; private set; }

    public bool Rain { get; private set; }

    public bool Fog { get; private set; }

    public CampusEnvironment()
    {
        Season = CampusSeason.Spring;

        Daylight = true;

        Rain = false;

        Fog = false;
    }

    public void ChangeSeason(CampusSeason season)
    {
        Season = season;
    }

    public void SetRain(bool rain)
    {
        Rain = rain;
    }

    public void SetFog(bool fog)
    {
        Fog = fog;
    }

    public void SetDaylight(bool daylight)
    {
        Daylight = daylight;
    }
}