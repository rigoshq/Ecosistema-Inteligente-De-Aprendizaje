using EIA.Domain.Entities.World;
using ExplorerSessionModel = EIA.Core.ExplorerSession.ExplorerSession;

namespace EIA.Core.Engine;

public class WorldNavigationEngine
{
    //---------------------------------------------------------
    // Mover al Explorador hacia un Distrito
    //---------------------------------------------------------

    public bool MoveToDistrict(
        ExplorerSessionModel session,
        KnowledgeDistrict district)
    {
        if (!session.IsActive)
            return false;

        session.MoveTo(district.Name);

        return true;
    }

    //---------------------------------------------------------
    // Mover al Explorador hacia un Edificio
    //---------------------------------------------------------

    public bool MoveToBuilding(
        ExplorerSessionModel session,
        KnowledgeBuilding building)
    {
        if (!session.IsActive)
            return false;

        session.MoveTo(building.Name);

        return true;
    }
}