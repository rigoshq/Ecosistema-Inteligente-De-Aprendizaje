namespace EIA.Domain.Entities.LearningExperiences;

public class LearningReward
{
    public int Experience { get; private set; }

    public int Coins { get; private set; }

    public LearningReward(
        int experience,
        int coins)
    {
        Experience = experience;

        Coins = coins;
    }
}