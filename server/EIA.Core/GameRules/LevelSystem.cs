namespace EIA.Core.GameRules;

public static class LevelSystem
{
    public static int ExperienceForLevel(int level)
    {
        return level * level * 100;
    }

    public static int CalculateLevel(int experience)
    {
        var level = 1;

        while (experience >= ExperienceForLevel(level + 1))
            level++;

        return level;
    }
}