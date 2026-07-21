namespace EIA.Domain.Entities.NPC;

public class NpcPersonality
{
    public bool Friendly { get; private set; }

    public bool Patient { get; private set; }

    public bool Curious { get; private set; }

    public bool Motivational { get; private set; }

    public bool Demanding { get; private set; }

    public NpcPersonality(
        bool friendly,
        bool patient,
        bool curious,
        bool motivational,
        bool demanding)
    {
        Friendly = friendly;

        Patient = patient;

        Curious = curious;

        Motivational = motivational;

        Demanding = demanding;
    }
}