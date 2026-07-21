using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.NPC;

namespace EIA.Core.Services.NarrativeEngine;

public class NarrativeContext
{
    public Explorer Explorer { get; }

    public Npc Npc { get; }

    public NarrativeContext(
        Explorer explorer,
        Npc npc)
    {
        Explorer = explorer;

        Npc = npc;
    }
}