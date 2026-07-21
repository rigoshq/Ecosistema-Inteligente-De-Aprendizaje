namespace EIA.Domain.Entities.Dialogue;

public class DialogueReward
{
    public int Experience { get; }

    public int Coins { get; }

    public DialogueReward(
        int experience,
        int coins)
    {
        Experience = experience;

        Coins = coins;
    }
}