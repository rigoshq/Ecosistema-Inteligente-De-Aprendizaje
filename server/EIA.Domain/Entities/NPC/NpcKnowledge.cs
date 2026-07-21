namespace EIA.Domain.Entities.NPC;

public class NpcKnowledge
{
    public List<string> Subjects { get; }

    public List<string> Laboratories { get; }

    public NpcKnowledge()
    {
        Subjects = new();

        Laboratories = new();
    }

    public void AddSubject(string subject)
    {
        if (!Subjects.Contains(subject))
            Subjects.Add(subject);
    }

    public void AddLaboratory(string laboratory)
    {
        if (!Laboratories.Contains(laboratory))
            Laboratories.Add(laboratory);
    }
}