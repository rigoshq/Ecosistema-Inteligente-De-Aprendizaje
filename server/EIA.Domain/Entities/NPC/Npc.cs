using EIA.Domain.Entities.NPC.Enums;
namespace EIA.Domain.Entities.NPC;



public class Npc
{
    public Guid Id { get; private set; }

    public NpcIdentity Identity { get; private set; }

    public NpcPersonality Personality { get; private set; }

    public NpcKnowledge Knowledge { get; private set; }

    public bool Active { get; private set; }
    
    public NpcEmotion Emotion { get; private set; }

    public NpcLocation Location { get; private set; }

    public List<NpcDialogue> Dialogues { get; }

    public NpcMemory Memory { get; private set; }

    public NpcSchedule Schedule { get; private set; }
   
    private Npc()
{
    Id = Guid.NewGuid();

    Identity = null!;

    Personality = null!;

    Knowledge = new();

    Location = new NpcLocation(
        "",
        "",
        "",
        0,
        0,
        0,
        0);

    Active = true;

    Emotion = NpcEmotion.Neutral;

    Dialogues = new();

    Memory = new();

    Schedule = new();
}

    public Npc(
        NpcIdentity identity,
        NpcPersonality personality)
        : this()
    {
        Identity = identity;

        Personality = personality;
    }

    public void Deactivate()
    {
        Active = false;
    }

    public void Activate()
    {
        Active = true;
    }
    public void SetEmotion(NpcEmotion emotion)
    {
    Emotion = emotion;
    }
    public void AddDialogue(NpcDialogue dialogue)
    {
    Dialogues.Add(dialogue);
    }
    public void RegisterInteraction(
    Guid? missionId,
    string topic)
    {
    Memory.RegisterInteraction(
        missionId,
        topic);
    }
    public void MoveToBuilding(string building)
    {
    Schedule.MoveTo(building);
    }

public bool IsAvailable(TimeOnly time)
    {
    return Schedule.IsWorking(time);
    }
}