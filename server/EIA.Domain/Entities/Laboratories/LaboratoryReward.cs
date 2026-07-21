namespace EIA.Domain.Entities.Laboratories;

public class LaboratoryReward
{
    public int Experience { get; private set; }

    public int Coins { get; private set; }

    public LaboratoryReward(
        int experience,
        int coins)
    {
        Experience = experience;

        Coins = coins;
    }
}